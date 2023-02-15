using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class Users
    {
        private int _userId;
        private string _userName;
        private string _password;
        private string _fullName;
        private bool _isActive;
        private string _category;

        public Users(int userId, string userName, string password, string fullName, bool isActive, string category)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            FullName = fullName;
            IsActive = isActive;
            Category = category;
        }

        public int UserId { get => _userId; set => _userId = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }
        public string Category { get => _category; set => _category = value; }
    }
}