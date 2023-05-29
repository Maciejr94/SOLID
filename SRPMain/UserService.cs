using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRPMain
{
    internal class UserService
    {
        private readonly SmtpClient _smtpClient;
        private readonly UserDbContext _dbContext;

        public UserService(SmtpClient smtpClient, UserDbContext dbContext)
        {
            _smtpClient = smtpClient;
            _dbContext = dbContext;
        }

        public void Register(string email, string password)
        {
            if (ValidateEmail(email))
            {
                var user = new User(email, password);
                _dbContext.Save(user);
                SendEmail(new MailMessage(email, email) { Subject = "User created." });
                Log("User Created.");
            }
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(MailMessage message) => _smtpClient.Send(message);

        public void Log(string message) => Console.WriteLine(message);
    }
}
