using Shop.Model.Models;
using Shop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVm)
        {

            postCategory.PostCategoryID = postCategoryVm.PostCategoryID;
            postCategory.Name = postCategoryVm.Name;
            postCategory.Description = postCategoryVm.Description;
            postCategory.Alias = postCategoryVm.Alias;
            postCategory.ParentID = postCategoryVm.ParentID;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.Image = postCategoryVm.Image;
            postCategory.HomeFlag = postCategoryVm.HomeFlag;

            postCategory.CreatedDate = postCategoryVm.CreatedDate;
            postCategory.CreateBy = postCategoryVm.CreateBy;
            postCategory.UpdatedDate = postCategoryVm.UpdatedDate;
            postCategory.UpdateBy = postCategoryVm.UpdateBy;
            postCategory.MetaKeyword = postCategoryVm.MetaKeyword;
            postCategory.MetaDescription = postCategoryVm.MetaDescription;
            postCategory.Status = postCategoryVm.Status;
        }
        public static void UpdatePost(this Post post, PostViewModel postVm)
        {

            post.ID = postVm.ID;
            post.Name = postVm.Name;
            post.description = postVm.description;
            post.Alias = postVm.Alias;
            post.PostCategoryID = postVm.PostCategoryID;
            post.Content = postVm.Content;
            post.Image = postVm.Image;
            post.HomeFlag = postVm.HomeFlag;
            post.ViewCount = postVm.ViewCount;

            post.CreatedDate = postVm.CreatedDate;
            post.CreateBy = postVm.CreateBy;
            post.UpdatedDate = postVm.UpdatedDate;
            post.UpdateBy = postVm.UpdateBy;
            post.MetaKeyword = postVm.MetaKeyword;
            post.MetaDescription = postVm.MetaDescription;
            post.Status = postVm.Status;

        }

        public static void PostTag(this PostTag postTag, PostTagViewModel postTagVm)
        {
            postTag.TagID = postTagVm.TagID;
            postTag.PostID = postTagVm.PostID;

        }

        public static void Tag(this Tag tag, TagViewModel tagVm)
        {
            tag.TagID = tagVm.TagID;
            tag.Name = tagVm.Name;
            tag.Type = tagVm.Type;

        }
    }
}