﻿using AutoMapper;
using Shop.Model.Models;
using Shop.Service;
using Shop.Web.Infrastructure.Core;
using Shop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shop.Web.Infrastructure.Extensions;

namespace Shop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listCategory = _postCategoryService.GetAll();

                var listPostCategoryVm = Mapper.Map<List<PostCategoryViewModel>>(listCategory);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listPostCategoryVm);
                return response;
            });
        }
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request,PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if(ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostCategory newPostCategory = new PostCategory();
                    newPostCategory.UpdatePostCategory(postCategoryVm);
                  var category =  _postCategoryService.Add(newPostCategory);
                    _postCategoryService.save();

                    response = request.CreateResponse(HttpStatusCode.OK, category);
                }
                return response;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCategoryDb = _postCategoryService.GetById(postCategoryVm.PostCategoryID);
                    postCategoryDb.UpdatePostCategory(postCategoryVm); 
                    _postCategoryService.Update(postCategoryDb);
                    _postCategoryService.save();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request,int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var category = _postCategoryService.Delete(id);
                    _postCategoryService.save();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
    }
}