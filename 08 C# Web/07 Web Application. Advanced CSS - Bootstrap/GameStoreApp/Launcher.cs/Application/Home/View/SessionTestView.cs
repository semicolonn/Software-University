﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Contracts;

namespace Launcher.cs.Application.Home.View
{
    public class SessionTestView : IView
    {
        private readonly DateTime dateTime;

        public SessionTestView(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public string View()
        {
            return $"<h1>Saved date: {dateTime}</h1>";
        }
    }
}