using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity1.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public string Index(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", ID: " + ID);
        }
        public string Secon()
        {
            return "Wellcome to method....!!";
        }
	}
}