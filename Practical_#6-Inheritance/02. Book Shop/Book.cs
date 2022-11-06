﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Book_Shop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            protected set
            {
                //Знаходимо індекс фамілії 
                int indexOfSecondNme = value.IndexOf(' ');

                //Якщо перша буква фамілії починається з цифри - виняток 
                if (char.IsDigit(value[indexOfSecondNme + 1]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }

        public string Title
        {
            get { return this.title; }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title is not valid!");
                }
                this.title = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        { 
            return $"Type: {this.GetType().Name}\n" +
                $"Title: {this.Title}\n" +
                $"Author: {this.Author}\n" +
                $"Price: {this.Price:f2}";
        }

    }
}
