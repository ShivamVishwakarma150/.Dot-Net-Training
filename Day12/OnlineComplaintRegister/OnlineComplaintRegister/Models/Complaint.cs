using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineComplaintRegister.Models
{
    public class Complaint
    {
        private int _id;
        private string _name;
        private string _address;
        private string _complain;
        private string _date;
        private bool _status;

        public Complaint(int id, string name, string address, string complaint, string date, bool status)
        {
            Id = id;
            Name = name;
            Address = address;
            Complain = complaint;
            Date = date;
            Status = status;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }
        public string Complain { get => _complain; set => _complain = value; }
        public string Date { get => _date; set => _date = value; }
        public bool Status { get => _status; set => _status = value; }
    }
}