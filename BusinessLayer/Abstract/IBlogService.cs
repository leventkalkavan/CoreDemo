using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetList();
        Blog GetByID(int id);
        List<Blog> GetBlogListWithCategory();        
        List<Blog> GetBlogListByWriter(int id);        
    }
}
