using System;
using System.Collections.Generic;
using System.Text;

namespace ZadacaLV
{
    class WebPage : IAdmin
    {
        int numberOfVisitors;
        int numberOfArticles;
        List<string> sponsors;

        public WebPage(int numberOfVisitors, int numberOfArticles, List<string> sponsors)
        {
            if (numberOfVisitors < 0) throw new VisitorsException(numberOfVisitors, "Number of visitors must be positive!");
            this.numberOfVisitors = numberOfVisitors;
            this.numberOfArticles = numberOfArticles;
            this.sponsors = sponsors;
        }
    }
}
