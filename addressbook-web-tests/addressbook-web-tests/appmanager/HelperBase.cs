﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        public HelperBase(IWebDriver driver) 
        { 
            this.driver = driver; 
        }
    }
}
