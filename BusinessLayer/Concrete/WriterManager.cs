﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public void WriterAdd(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            throw new NotImplementedException();
        }

        public void WriterUpdate(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}