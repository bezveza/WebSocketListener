﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalServer.Server.Messaging.TerminalControl.Events
{
    public class TerminalOutputEvent:TerminalControlEvent
    {
        public static readonly String Command ="terminal-output";

        public String Output { get; private set; }
        public String CurrentPath { get; private set; }
        public TerminalOutputEvent(String terminalId, String output, String currentPath)
            :base(Command,terminalId)
        {
            Output = output;
            CurrentPath = currentPath;
        }
    }
}
