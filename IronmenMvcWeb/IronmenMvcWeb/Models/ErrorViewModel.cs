using System;

namespace IronmenMvcWeb.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
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
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime PublishDate { get; set; }
    }
}