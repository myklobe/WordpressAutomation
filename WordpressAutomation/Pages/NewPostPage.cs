using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WordpressTests;

namespace WordpressAutomation
{
    public class NewPostPage
    {
        public static void GoTo()
        {
            LeftNavigation.Posts.AddNew.Select();
        }

        public static CreatePostCommand CreatePost(string title)
        {
            return new CreatePostCommand(title);
        }

        public static void GoToNewPost()
        {
            var message = Driver.Instance.FindElement(By.Id("message"));
            var newPostlink = message.FindElements(By.TagName("a"))[0];
            newPostlink.Click();
        }

        public static bool IsInEditMode()
        {
            return Driver.Instance.FindElement(By.Id("publish")) != null;
        }

        public static string Title
        {
            get 
            {
                var title = Driver.Instance.FindElement(By.Id("title"));
                if (title != null)
                    return title.GetAttribute("value");
                return string.Empty;
            }
        }
    }

        public class CreatePostCommand
        {
            private readonly string title;
            private string body;


            public CreatePostCommand(string title)
            {
                this.title = title;
            }

            public CreatePostCommand WithBody(string body)
            {
                this.body = body;
                return this;
            }

            public void Publish()
            {
                Driver.Instance.FindElement(By.Id("title")).SendKeys(title);
                Driver.Instance.SwitchTo().Frame("content_ifr");
                Driver.Instance.SwitchTo().ActiveElement().SendKeys(body);
                Driver.Instance.SwitchTo().DefaultContent();
                
                Thread.Sleep(3000);

                Driver.Instance.FindElement(By.Id("publish")).Click();

                Driver.Wait(TimeSpan.FromSeconds(1));
                Thread.Sleep(3000);
            }
        }
}
