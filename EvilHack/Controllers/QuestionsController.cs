﻿using EvilHack.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvilHack.Controllers
{
    public class QuestionsController : Controller
    {
        // GET: Questions
        [AllowAnonymous]
        public ActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            var quiz = Db.GetQuiz();
            return View(quiz);
        }
        // GET: Results
        [AllowAnonymous]
        public ActionResult Results(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            var quiz = Db.GetQuiz();
            return View(quiz);
        }
    }
}