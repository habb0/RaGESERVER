using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;

namespace RageServer.Server.Habbo.Messages.Events.Handshake
{
    class UniqueID : IMessageEvent
    {
        // INCOMING ID: 813
        public void Handle(Session client, ClientMessage parser)
        {
            throw new NotImplementedException();
        }
    }
}