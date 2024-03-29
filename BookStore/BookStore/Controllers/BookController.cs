﻿using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController:Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var obj= _bookRepository.GetAllBooks();
            return View(obj);
        }
        public ViewResult GetBook(int id)
        {
            //return _bookRepository.GetBookById(id);
            return View();
        }
        public List<BookModel>SearchBook(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
        
    }
}
