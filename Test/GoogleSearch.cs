using Interview.Page;
using NUnit.Framework;

namespace Interview.Test
{
    public class GoogleSearch : GooglePage
    {
        [Test]
        public void ValidateGoogleSearch()
        {            
            FillSearch();
            ClickSearchButton();
            ValidateSearch();
        }

        [Test]
        public void ClickOnAGoogleSearchAndValidatePage()
        {
            FillSearch();
            ClickSearchButton();
            ValidateSearch();
            ClickOnFirstLink();
            ValidatePage();


        }
    }
}
