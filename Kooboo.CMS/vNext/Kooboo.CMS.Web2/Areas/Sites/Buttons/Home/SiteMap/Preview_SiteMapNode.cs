﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kooboo.CMS.Web2.Areas.Sites.Buttons.Home.SiteMap
{
    public class Preview_SiteMapNode : SiteMapNodeButtonBase
    {
        public override string DisplayText
        {
            get { return "Preview"; }
        }


        public override string Name
        {
            get { return "Preview_SiteMapNode"; }
        }

        public override int Order
        {
            get { return 1; }
        }


    }
}