﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidMujezin.Platforms.Windows
{
    public class MessageTest : IMessage
    {
        public void ShowMessageAndCatchAction(string Message, Action<string> ToClick)
        {
            Console.WriteLine(Message);

        }
    }
}
