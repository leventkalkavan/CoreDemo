using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public Notification GetByID(int id)
        {
            return _notificationDal.GetByID(id);
        }

        public List<Notification> GetList()
        {
            return _notificationDal.GetListAll();
        }

        public void TAdd(Notification t)
        {
            _notificationDal.Insert(t);
        }

        public void TDelete(Notification t)
        {
            _notificationDal.Delete(t);
        }

        public void TUpdate(Notification t)
        {
            _notificationDal.Update(t);
        }
    }
}
