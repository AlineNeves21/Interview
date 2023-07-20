using Interview.Initial;
using Interview.Test;

namespace Interview.Page
{
    public class GooglePage : Begin
    {
        public void FillSearch()
        {
            WriteText(".gLFyf", "uci kinoplex");
        }

        public void ClickSearchButton()
        {
            ClickElement(".gNO89b");
        }

        public void ValidateSearch()
        {
            ValidateData(".vk_bk.lr_c_h", "Programação UCI Kinoplex Independência");
        }

        public void ClickOnFirstLink()
        {
            ClickElement(".LC20lb.MBeuO.DKV0Md");
        }

        public void ValidatePage()
        {
            ValidateData(".pull-left", "PROGRAMAÇÃO");
        }
    }
}
