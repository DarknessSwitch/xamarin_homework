using System;
using System.Globalization;

namespace Books.Core.Services
{
    public interface IBooksService
    {
        void StartSearchAsync(string whatFor, Action<BookSearchResult> success, Action<Exception> error);
        void GetBookItem(string id, Action<BookSearchItem> success, Action<Exception> error);
    }
}