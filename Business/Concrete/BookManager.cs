using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public void Add(Book book)
        {
            //iş kodları
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);

        }

        public List<Book> GetAll()
        {
            return _bookDal.GetList().ToList();
        }

        public List<Book> GetByAuthor(int id)
        {
            return _bookDal.GetList(b=>b.Id==id).ToList();

        }

        public Book GetById(int id)
        {
            return _bookDal.Get(b=>b.Id==id);

        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
