using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRPMain
{
    internal class BetterUserService
    {
        private readonly EmailSerivce _emailService;
        private readonly UserDbContext _dbContext;
        private readonly LogService _logService;
        private const string USER_CREATED = "User created";

        public BetterUserService(EmailSerivce emailSerivce, UserDbContext dbContext, LogService logService)
        {
            _emailService = emailSerivce;
            _dbContext = dbContext;
            _logService = logService;
        }

        public void Register(string email, string password)
        {
            if (_emailService.ValidateEmail(email))
            {
                var user = new User(email, password);
                _dbContext.Save(user);
                _emailService.SendEmail(new MailMessage(email, email) { Subject = USER_CREATED });
                _logService.Log(USER_CREATED);
            }
        }

    }

    internal class EmailSerivce
    {
        SmtpClient _smtpClient;
        public EmailSerivce(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(MailMessage message) => _smtpClient.Send(message);
    }

    internal class LogService
    {
        public LogService()
        {
        }

        public virtual void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}
