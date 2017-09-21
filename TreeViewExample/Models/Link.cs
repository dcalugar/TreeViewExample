using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeViewExample.Helpers;

namespace TreeViewExample.Models
{
    public class Link
    {
        public Link(string text)
        {
            this.Text = text;
            this.DataText = StringUtil.RemoveNonAlphaNumberic(text);
        }
        public Link(string text, string href)
        {
            this.Text = text;
            this.Href = href;
            this.DataText = StringUtil.RemoveNonAlphaNumberic(text);
        }
        public Link(string text, string href, string cssClass)
        {
            this.Text = text;
            this.Href = href;
            this.CssClass = cssClass;
            this.DataText = StringUtil.RemoveNonAlphaNumberic(text);
        }

        public string Text { get; set; }
        public string Href { get; set; }
        public string CssClass { get; set; }
        public string DataText { get; set; }
    }
}
