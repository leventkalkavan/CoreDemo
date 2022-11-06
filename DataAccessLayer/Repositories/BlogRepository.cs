﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        Context c = new Context();
        public void AddBlog(Blog blog)
        {
            c.Add(blog);
            c.SaveChanges();
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetByID(int id)
        {
           return c.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            return c.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
