using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortableSteam.Infrastructure;

namespace WebApplication1.PortableSteamExtension
{
    public class GetAppDetailsRequest:RequestBase
    {
        public GetAppDetailsRequest(string key) : base(key) { }

        //TODO: to gówno zawiera w sobie id=1630 , wykminić jak to zrobić tak ,żeby pobierało jeszcze id ,które tu wrzucę;
        protected override string EndpointUrl
        {
            get { return "http://store.steampowered.com/api/appdetails?appids=1630"; }
        }
    }
}