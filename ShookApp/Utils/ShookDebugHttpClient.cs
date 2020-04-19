﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShookApp.Utils
{
    /// <summary>
    /// A HTTP Client for debugging only. It does not care about certificates which is helpful
    /// if you want to run the ShookREST project in VisualStudio in combination with "Conveyor by Keyoti"
    /// https://marketplace.visualstudio.com/items?itemName=vs-publisher-1448185.ConveyorbyKeyoti
    /// </summary>
    class ShookDebugHttpClient : RestClient
    {
        /// <summary>
        /// Constructor that changes the RemoteCertificationValidationCallback and adds a timeout
        /// of 30 seconds. Throws an EndOfDocument Exception if the timout is reached. 
        /// </summary>
        /// <param name="baseUrl">The URL of the ShookREST API</param>
        public ShookDebugHttpClient(string baseUrl) : base(baseUrl)
        {
            RemoteCertificateValidationCallback = delegate { return true; };
            Timeout = 30000;
        }
    }
}
