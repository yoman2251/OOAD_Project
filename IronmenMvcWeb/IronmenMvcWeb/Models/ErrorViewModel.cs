using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IronmenMvcWeb.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Member
    {
        public string Username { get; set; }
        public string StudentID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class Pokemon
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishDate { get; set; }
        public string Source { get; set; }
    }

    public class Account
    {
        public int Id { get; set; }
   
        public string Title { get; set; }

        public DateTime PublishDate { get; set; }
    }

    public class Report
    {
        public int RId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishDate { get; set; }
        public string Source { get; set; }
        // public Account Account { get; set; }
        public string Date { get; set; }
    }

    public class Register
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string StudentID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Password_confirm { get; set; }
    }
}
