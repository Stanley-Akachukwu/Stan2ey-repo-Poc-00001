using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.DTO
{
    public class Response
    {
        public string ResponseMessage { get; set; }
        public bool Succeeded { get; set; }
        public int ResponseCode { get; set; }
    }
}
