using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SydneyOnlineBookStore.Models;

namespace SydneyOnlineBookStore.Repository
{
    public class MessageRepository: IMessageRepository
    {
        private readonly IOptionsMonitor<NewBookAlertConfig> _newBookAlertconfiguration;

        public MessageRepository(IOptionsMonitor<NewBookAlertConfig> newBookAlertconfiguration)
        {
            _newBookAlertconfiguration = newBookAlertconfiguration;

        }
        public string GetName()
        {
            return _newBookAlertconfiguration.CurrentValue.BookName;
        }
    }
}
