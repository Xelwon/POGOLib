using System;
using System.Net;

namespace POGOLib.Official.Util
{
    internal class WebProxy : IWebProxy
    {
        private string proxy;
        private bool v;

        public WebProxy(string proxy, bool v)
        {
            this.proxy = proxy;
            this.v = v;
        }

        public ICredentials Credentials { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Uri GetProxy(Uri destination)
        {
            throw new NotImplementedException();
        }

        public bool IsBypassed(Uri host)
        {
            throw new NotImplementedException();
        }
    }
}