using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void NewsLetterAdd(NewsLetter newsLetter)
        {
            _newsLetterDal.Insert(newsLetter);
        }
    }
}
