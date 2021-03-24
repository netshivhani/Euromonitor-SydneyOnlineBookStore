using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SydneyOnlineBookStore.Models;

namespace SydneyOnlineBookStore.Service
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptions userEmailOptions);

        Task SendEmailForEmailConfirmation(UserEmailOptions userEmailOptions);

        Task SendEmailForForgotPassword(UserEmailOptions userEmailOptions);
    }
}
