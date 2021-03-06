﻿using BL.Domain;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System;

namespace BL
{
    public class Read
    {
        public IEnumerable<SocialMediaPost> ReadData()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.bitzfactory.com/json.php");
            request.Method = WebRequestMethods.Http.Get;
            request.Accept = "application/json";
            string text;
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            var tweets = JObject.Parse(text).SelectToken("records").ToObject<List<SocialMediaPost>>();
            return (List<SocialMediaPost>) tweets;
        }
    }
}
