using orucluq.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace orucluq.Models
{
    class User
    {
        private static int _id;
        public int Id { get; set; }
        public string UserName { get; set; }

        private List <Status> _statuses;

        public User(string userName)
        {
            _id++;
            Id = _id;
            UserName = userName;
            _statuses = new List<Status>();
        }

        public void ShareStatus(Status status)
        {
            _statuses.Add(status);
        }

        public Status GetStatusById(int? id)
        {
            if(id == null)
            {
                throw new NotFoundException("Id gonderin!");
            }

            if(_statuses.Exists(s=> s.Id == id))
            {
                Status stat = _statuses.Find(s => s.Id == id);

                return stat;
            }

            throw new NotFoundException("Bele bir status yoxdur");
        }

        public List<Status> GetAllStatuses()
        {
            List<Status> StatusCopy = new List<Status>();

            StatusCopy.AddRange(_statuses);

            return StatusCopy;
        }

        public List<Status> FilterStatusByDate(int? id,DateTime serachTime)
        {
            List<Status> filter = new List<Status>();

            if (id == null || serachTime == null)
            {
                throw new NotFoundException("Tarixi ve Id gonderin");
            }

            if (_statuses.Exists(s=> s.SharedDate>serachTime) && User._id==id)
            {
                filter = _statuses.FindAll(s => s.Id == id && s.SharedDate < serachTime);
                return filter;
            }

            throw new NotFoundException("Bele tapsiriq yoxdur");
        }
    }
}
