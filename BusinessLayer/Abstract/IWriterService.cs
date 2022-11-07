using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
  public interface IWriterService
    {
        void WriterAdd(Writer writer);
        void WriterDelete(Writer writer);
        void WriterUpdate(Writer writer);
        List<Writer> GetList();
        Writer GetByID(int id);
    }
}
