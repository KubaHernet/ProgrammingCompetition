using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCBack.Api.Settings
{
    public class CompilerApiSettings
    {
        public const string Path = "CompilerApi";

        public string Url { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
