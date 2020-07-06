
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication.Functions;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        ArthematicFunctions arthematicFunctions = new ArthematicFunctions();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Calculator()
        {
            float a = 3;
            float b = 5;
            string cal = "+";
            var c = arthematicFunctions.Calculation(a, b, cal);
            var output = JsonConvert.SerializeObject(c);
            return Json(output, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ReverseStr()
        {
            string s = "Hello";
            arthematicFunctions.revString(s);
            string output = JsonConvert.SerializeObject(arthematicFunctions);
            return Json(output, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Palindrom()
        {
            string s = "aabbaa";
            var obj = arthematicFunctions.Palindrom(s);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CountSameWords()
        {
            string s = "Use camel case for all JSON property names";
            var obj = arthematicFunctions.CountSimilarWords(s);
           // string output = JsonConvert.SerializeObject(obj);
            return Json(JsonConvert.SerializeObject(obj), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdatedArray()
        {
            int a = 7, b = 2; 
            int[] array = {1,2,3,4,5};
            var s = arthematicFunctions.AddNumber(array, a , b);
            string output = JsonConvert.SerializeObject(s);

            arthematicFunctions.AddNumber(array, a, b);                           //Q) result is empty  Why we can not use
            //string result = JsonConvert.SerializeObject(arthematicFunctions);

            return Json(arthematicFunctions.AddNumber(array, a, b), JsonRequestBehavior.AllowGet);
        }

        public JsonResult SumOfPrimeNum()
        {
            int[] array = {1,4,3,5,7,9,11};
            var s = arthematicFunctions.sumPrimNum(array);
            var result = JsonConvert.SerializeObject(s);      //Q)Without this line result is in diff format but is in json
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult Table()
        {
            var a = arthematicFunctions.Table(2);
            var result = JsonConvert.SerializeObject(a);      
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Swap()
        {
            int x = 5;
            int y = 10;
            int b;
            var number = arthematicFunctions.Swap(x, y, out b);
            var a = new { number = number, b = b };
            //var result = JsonConvert.SerializeObject(numbers);      
            return Json(a, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CountSimilarWords()
        {
            String s = "muhammad haris";
            var str = arthematicFunctions.CountSimilarWords(s);
            return Json(str, JsonRequestBehavior.AllowGet);
        }

        
        public JsonResult Car()
        {
            Vehicle v = new Vehicle();
            Vehicle v1 = new Vehicle();
            v.ID = 1;
            v.Name = "mehran";
            v.Model = "2010";
            v.ownerName = "Haris";
            v.price = 10000;
            int a = Vehicle.Num;
            Vehicle.numberofcars = 123;
            var result = JsonConvert.SerializeObject(v);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        
    }
}