using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace Redirects
{
    public class Tests
    {
        [TestCase(@"K:\Users\maria.levchuk\Documents\Rockwool\redirects_RU_ru_urls.txt")]
        public void RedirectUrl_ShouldMatch_NewUrlFromFile(string filepath)
        {
            OpenFile(filepath);
            string newUrlFromFile = ReadNewUrlFromFile();
            Client.Get(oldUrl);
            GetStatusCode();
            string redirect = GetRedirectedUrl();
            var targetStatusCode = GetStatusCode();
            redirect.Should().Contain(newUrlFromFile);
        }


    }
}
