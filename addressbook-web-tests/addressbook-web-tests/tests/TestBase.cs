﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium;
//using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using System.Runtime.CompilerServices;

namespace WebAddressbookTests
{
        public class TestBase
    {
        protected ApplicationManager app;
        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
