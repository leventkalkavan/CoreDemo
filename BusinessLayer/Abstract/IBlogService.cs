using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetList();
        List<Blog> GetBlogByID(int id);
        public List<Blog> GetLast3Blog();
        List<Blog> GetBlogListWithCategory();        
        List<Blog> GetBlogListByWriter(int id);        
    }
}
