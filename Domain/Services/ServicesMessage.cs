using Domain.Interfaces;
using Domain.Interfaces.Generics;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServicesMessage : IServiceMessage
    {
        private readonly IMessages _messages;
        public ServicesMessage(IMessages messages)
        {
            _messages = messages;
        }
    }
}
