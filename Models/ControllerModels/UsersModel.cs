﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace TJ_Games.Models
{
    public class BuyerSignUpModel
    {
        public string BuyerID;
        public string BuyerName;
        public DateTime Birthday;
        public string Mail;
        public string Password;
        public string UserType = "1";//代表为用户
    }

    public class PublisherSignUpModel
    {
        public string PublisherID;
        public string PublisherName;
        public DateTime StartTime;
        public string Description;
        public string Password;
        public string UserType = "2";//代表为发行商
        public string HomepageURL;
    }
}
