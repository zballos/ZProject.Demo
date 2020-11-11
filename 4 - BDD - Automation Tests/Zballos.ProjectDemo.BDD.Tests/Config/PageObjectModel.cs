using System;
using System.Collections.Generic;
using System.Text;

namespace Zballos.ProjectDemo.BDD.Tests.Config
{
    public abstract class PageObjectModel
    {
        protected readonly SeleniumHelper Helper;

        protected PageObjectModel(SeleniumHelper helper)
        {
            Helper = helper;
        }

        public string GetUrl()
        {
            return Helper.GetUrl();
        }

        //public void GoToUrl(string.)_{
    }
}
