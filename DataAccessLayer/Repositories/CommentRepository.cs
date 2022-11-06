using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : IGenericDal<EntityLayer.Concrete.Comment>
    {
        public void Delete(EntityLayer.Concrete.Comment t)
        {
            throw new NotImplementedException();
        }

        public EntityLayer.Concrete.Comment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<EntityLayer.Concrete.Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(EntityLayer.Concrete.Comment t)
        {
            throw new NotImplementedException();
        }

        public void Update(EntityLayer.Concrete.Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
