﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium;
using WordpressTests;
using OpenQA.Selenium;

namespace WordpressAutomation
{
    public class LeftNavigation
    {
        public class Posts
        {
            public class AddNew
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-posts", "Add New");
                }
            }
        }

        public class Pages
        {
            public class AllPages
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-pages", "All Pages");
                }
            }
        }
    }
    
}
