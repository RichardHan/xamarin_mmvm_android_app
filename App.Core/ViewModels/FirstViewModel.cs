using MvvmCross.Core.ViewModels;

namespace App.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        {
            get { return _hello; }
            set { SetProperty(ref _hello, value); }
        }


        //##Action-1
        private bool _isCheck = false;

        public bool IsCheck
        {
            get { return _isCheck; }
            set { SetProperty(ref _isCheck, value); }
        }

    }
}
