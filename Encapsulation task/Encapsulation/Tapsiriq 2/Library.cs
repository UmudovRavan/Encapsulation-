using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Tapsiriq_2
{
    public class Library
    {
        public Book[] books = Array.Empty<Book>();
        
        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length+1);
            books[^1] = book;
        }

        public Book GetBookById(int id)
        {
            foreach (Book book in books)
            {
                if (book.Id == id)
                    return book;
            }
            return null; 
        }

        public Book GetBookByName(string name)
        {
            foreach (Book book in books)
            {
                if (book.Name == name)
                {
                    return book;
                }
            }
            return null ;
        }

        public Book[] GetBooksByName(string name)
        {
            Book[] wantedBookName = new Book[0];

            foreach (Book book in books)
            {
                if(book.Name.ToLower().Contains(name.ToLower()))
                {
                    Array.Resize(ref wantedBookName, wantedBookName.Length+ 1 );
                    wantedBookName[^1] = book;
                }
            }
            return wantedBookName;
        }

        public Book[] GetFilteredBook(string genre)
        {
            Book[] wantedGenre = new Book[0];
            
            foreach (Book book in books)
            {
                if (book.Genre.ToLower().Contains(genre.ToLower()))
                {
                    Array.Resize(ref wantedGenre, wantedGenre.Length+ 1 );
                    wantedGenre[^1] = book;
                }
            }
            return wantedGenre;
        }

        public List<Book> GetFilteredBook(int minPrice,int maxPrice)
        {
            List<Book> minMaxPricw = new List<Book>();

            foreach (Book book in books)
            {
                if(book.Price >= minPrice && book.Price <= maxPrice)
                {
                    minMaxPricw.Add(book);
                }
            }
            return minMaxPricw;
            
        }
    }
}
