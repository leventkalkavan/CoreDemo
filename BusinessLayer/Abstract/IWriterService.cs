using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
  public interface IWriterService: IGenericService<Writer>
    {       
        List<Writer> GetList();
        List<Writer> GetWriterByID(int id);
        Writer GetByID(int id);
    }
}
