using System;

namespace ClubOneMVC.Models
{
    public class UserViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string SongRequest { get; set; }
    }
}