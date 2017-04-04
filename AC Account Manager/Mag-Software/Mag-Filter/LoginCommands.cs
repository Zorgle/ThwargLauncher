﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MagFilter
{
    class LoginCommands
    {
        const int DefaultMillisecondsToWaitAfterLoginComplete = 3000;
        const int UnspecifiedWait = 9999;

        public readonly Queue<string> MessageQueue = new Queue<string>();
        private int _millisecondsToWaitAfterLoginComplete = UnspecifiedWait;

        public void ClearWait() { _millisecondsToWaitAfterLoginComplete = UnspecifiedWait; }
        public int WaitMillisencds
        {
            get
            {
                if (_millisecondsToWaitAfterLoginComplete == UnspecifiedWait)
                {
                    return DefaultMillisecondsToWaitAfterLoginComplete;
                }
                else
                {
                    return _millisecondsToWaitAfterLoginComplete;
                }
            }
            set
            {
                _millisecondsToWaitAfterLoginComplete = value;
            }
        }
        public int GetInternalWaitValue() { return _millisecondsToWaitAfterLoginComplete; }
        public bool IsWaitSpecified() { return _millisecondsToWaitAfterLoginComplete != UnspecifiedWait; }
    }
}
