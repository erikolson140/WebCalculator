﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public JsonResult Calculate(float firstNum, float secondNum, string oper)
        {
            float result = 0;

            switch(oper)
            {
                case "+":
                {
                    result = firstNum + secondNum;
                    break;
                }
                case "-":
                {
                    result = firstNum - secondNum;
                    break;
                }
                case "*":
                {
                    result = firstNum * secondNum;
                    break;
                }
                case "/":
                {
                    result = firstNum / secondNum;
                    break;
                }
            }
            return Json(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}