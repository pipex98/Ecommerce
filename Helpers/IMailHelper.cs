﻿using ecommerce.Common;

namespace ecommerce.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string toName, string toEmail, string subject, string body);
    }
}
