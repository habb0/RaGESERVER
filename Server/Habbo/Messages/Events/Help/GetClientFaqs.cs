using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;

namespace RageServer.Server.Habbo.Messages.Events.Help
{
    class GetClientFaqs : IMessageEvent
    {
        // INCOMING ID: 416
        public void Handle(Session client, ClientMessage parser)
        {
            throw new NotImplementedException();
        }
    }
}