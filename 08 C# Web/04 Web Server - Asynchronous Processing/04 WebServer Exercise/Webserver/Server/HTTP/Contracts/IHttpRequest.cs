﻿using System.Collections.Generic;
using Webserver.Server.Enums;

namespace Webserver.Server.HTTP.Contracts
{
    public interface IHttpRequest
    {
        Dictionary<string, string> FormData { get; }

        IHttpHeaderCollection HeaderCollection { get; }

        IHttpCookieCollection Cookies { get; }

        string Path { get; }

        Dictionary<string, string> QueryParameters { get; }

        HttpRequestMethod RequestMethod { get; }

        string Url { get; }

        Dictionary<string, string> UrlParameters { get; }

        IHttpSession Session { get; set; }

        void AddUrlParameter(string key, string value);
    }
}