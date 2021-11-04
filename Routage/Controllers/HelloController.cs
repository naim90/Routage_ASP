using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routage.Controllers
{

    public class HelloController
    {
        [Route("/Say")]
        public String SayHello()
        {
            return "Hello !";
        }
        [Route("/Yell")]
        public String YellHello()
        {
            return "HELLO !";
        }

        public String SayHelloHello()
        {
            return "Hello !";
        }

        public String YellHelloHello()
        {
            return "HELLO !";
        }
    }
}
