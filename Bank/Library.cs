using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Library
    {
        private Book[] _books = new Book[0];
        public void ListOfBooks()
        {
            foreach (Book book in _books)
            {
                book.GetInfo();
            }
        }

        public void DeleteBook(Book book)
        {
            string name = Console.ReadLine();
            if (_books.Length > 0)
            {
                Book[] books2 = new Book[_books.Length - 1];
                for (int i = -1; i < _books.Length; i++)
                {
                    if (_books[i].GetName() == name)
                    {
                        books2[i] = _books[i];
                    }
                }
                _books = books2;
            }

        }

        public void AddBook(Book book)
        {
            if (_books.Length == 0)
            {
                _books = new Book[] { book };
            }

            else if (_books.Length > 0)
            {
                Book[] books2 = new Book[_books.Length + 1];
                for (int i = 0; i < _books.Length; i++)
                {
                    books2[i] = _books[i];
                }
                books2[books2.Length - 1] = book;
                _books = books2;
            }
        }
    }
}