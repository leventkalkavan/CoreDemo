﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
   public interface IMessageService : IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string p);
    }
}