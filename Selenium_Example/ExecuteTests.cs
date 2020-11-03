using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Example
{
    class ExecuteTests
    {
        public static void Main(String[] args)
        {
            TestCases Tests = new TestCases();
            Tests.Initialize();
            Tests.LoginOpenTest();
            Tests.RegisterTest();
            Tests.SignupOpenTest();
            Tests.InvalidLoginTest();
            Tests.SearchWithEnterTest();
            Tests.SearchWithClickTest();
            Tests.AddToCartTest();
            Tests.ViewCartTest();
            Tests.AddQuestionTest();
            Tests.CleanUp();
        }
    }
}
