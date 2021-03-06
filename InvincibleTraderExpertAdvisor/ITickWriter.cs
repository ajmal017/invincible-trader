﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InvincibleTraderExpertAdvisor
{
    public interface ITickWriter
    {
        (bool success, long tsDateTime, int tsMilliseconds, double bid, double ask) LastTick { get; }
        string TickUri { get; }
        (bool success, string message) Write(long tsDateTime, int tsMilliseconds, double bid, double ask);
    }
}
