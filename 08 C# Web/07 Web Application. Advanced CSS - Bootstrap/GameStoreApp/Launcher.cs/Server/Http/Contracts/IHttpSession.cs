﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs.Server.Http.Contracts
{
    public interface IHttpSession
    {
        string Id { get; }

        object Get(string key);

        T Get<T>(string key);

        bool Contains(string key);

        void Add(string key, object value);

        void Clear();
    }
}