﻿using Shop.Data.Infrastructure;
using Shop.Data.Repositories;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public interface IMenuGroupService
    {
        void Add(MenuGroup menuGroup);
        void Delete(int id);
        void Update(MenuGroup menuGroup);

        IEnumerable<MenuGroup> GetAll();
        MenuGroup GetById(int id);
        void save();
    }
    public class MenuGroupService : IMenuGroupService
    {
        IMenuGroupRepository _menuGroupRepository;
        IUnitOfWork _unitOfWork;
        public MenuGroupService(IMenuGroupRepository menuGroupRepository, IUnitOfWork unitOfWork)
        {
            this._menuGroupRepository = menuGroupRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(MenuGroup menuGroup)
        {
            _menuGroupRepository.Add(menuGroup);
        }

        public void Delete(int id)
        {
            _menuGroupRepository.Delete(id);
        }

        public IEnumerable<MenuGroup> GetAll()
        {
            return _menuGroupRepository.GetAll();
        }

        public MenuGroup GetById(int id)
        {
            return _menuGroupRepository.GetSingleById(id);
        }

        public void save()
        {
            _unitOfWork.Commit();
        }

        public void Update(MenuGroup menuGroup)
        {
            _menuGroupRepository.Update(menuGroup);
        }
    }
}
