﻿using Aku_Software_Blog.BusinessLayer.Abstract;
using Aku_Software_Blog.DataAccessLayer.Abstract;
using Aku_Software_Blog.DataAccessLayer.EntityFramework;
using Aku_Software_Blog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aku_Software_Blog.BusinessLayer.Concrete
{
    internal class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
