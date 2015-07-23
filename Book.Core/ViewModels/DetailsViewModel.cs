using System.Collections.Generic;
using Books.Core.Services;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace Books.Core.ViewModels
{
    /// <summary>
    /// TODO implement Details view model to download and hold detail information about the book
    /// Also you need to implement views for each platform for this model
    /// </summary>
    public class DetailsViewModel 
        : MvxViewModel
    {
        private readonly IBooksService _books;

        public string BookId { get; set; }

        private BookSearchItem _result;

        public BookSearchItem Result
        {
            get { return _result; }
            set { _result = value; RaisePropertyChanged(()=>Result); }
        }
        public DetailsViewModel(IBooksService books)
        {
            _books = books;
        }

        protected override void InitFromBundle(IMvxBundle parameters)
        {
            // TODO get and cast incomming bundle to the parameter passed from FirstViewModel
            // details here
            // https://github.com/MvvmCross/MvvmCross/wiki/ViewModel--to-ViewModel-navigation
           
            base.InitFromBundle(parameters);

            BookId = parameters.Data["id"];
            _books.GetBookItem(BookId, 
                result => Result = result, 
                error => { });
        }
    }
}
