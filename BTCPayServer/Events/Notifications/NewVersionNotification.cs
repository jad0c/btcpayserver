﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCPayServer.Events.Notifications
{
    public class NewVersionNotification : NotificationEventBase
    {
        public string Version { get; set; }
    }
}
