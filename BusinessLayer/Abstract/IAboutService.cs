using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        void AboutAdd(About about);
        void AboutDelete(About about);
        void AboutUpdate(About about);
        List<About> GetList();
        About GetByID(int id);
    }
}
