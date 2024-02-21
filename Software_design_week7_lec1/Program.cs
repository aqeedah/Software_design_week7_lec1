using System;

namespace HelloWorld
{

    class Book
    {
        //Field
        String title;
        String author;
        string Isbn;
        bool isavailable = true;

        //properties

        public string Title {  get { return title; } }
        public string Author { get { return author; } }
        public string isbn { get { return Isbn; } }
        public bool Isavailable { get { return isavailable; } set { isavailable = value; } } 

        public Book(string btitle,string bauthor,string bisbn)
        {
            title = btitle;
            author = bauthor;   
            Isbn = bisbn;
        }
    }
    class Library
    {
        Book[] books = new Book[10];
        int count = 0;

        public void Addbook(Book book)
        {
            books[count++] = book;
        }
        public void Listavailablebook() 
        { 
            for(int i = 0;i<count;i++)
            {
                if (books[i].Isavailable)
                {
                    Console.WriteLine($"{i + 1}. Title : {books[i].Author}");
                }
            }
        }

        public void checkbook(string isbn)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Isbn == isbn && books[i].Isavailable)
                {
                    books[i].Isavailable = false;
                    Console.WriteLine($"Book checkout, here is the remaining avalilable books.");
                }
                
            }
        }
        public void returnbook(string isbn)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Isbn == isbn && books[i].Isavailable)
                {
                    books[i].Isavailable = true;
                    Console.WriteLine($"Book return, here is the remaining avalilable books.");
                    break;
                }

            }
        }
        public void removebook(string isbn)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (books[i].Isbn == isbn)
                {
                    index = 1;
                }
            }
            books[index] = null;
            for(int i = index;i < count-1;i++)
            {
                books[i] = books[i+1];
            }
            count--;
            Listavailablebook();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("1984", "George Orwel", "1a2s4f58");
            Book book2 = new Book("c++", "DEn", "4d58f42d7");
            Book book3 = new Book("C", "Milton", "1d4f8f2f");
           
            Library library = new Library();
            library.Addbook(book1);
            library.Addbook(book2);
            library.Addbook(book3);
            

        }
    }
    //How to create class

    //Access modifiers = by default it is private

    /*class Dealership
    {
        public int inventory = 4;

        //Properties
        public int Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
    }
    class Car
    {
        //fields /class member
        int numDoors = 4;
        int Enginsize;
        string color;

        //Methods

        public void Honk(string model)
        {
            Console.WriteLine($"{model}Honk");
        }
        public Car(int cenginsize,string Ccolor) //Constructer has same name as CLASS name
        {
               Enginsize = cenginsize;
               color = Ccolor; 
        }
        

        static void Main(string[] args)
        {
            //How to create an object
            //classname objectname = new classname()

            Dealership waterloo = new Dealership();
            Console.WriteLine(waterloo.inventory);

            Car lexus = new Car(3500,"red");
            //lexus.Enginsize = 3500;
            //lexus.color = "Red";
            Console.WriteLine(lexus.numDoors);
            Console.WriteLine(lexus.Enginsize);
            lexus.Honk("lexus");

            Car BMW = new Car(4500,"Green");
            //BMW.Enginsize = 4500;
            //BMW.color = "Green";
            Console.WriteLine(BMW.numDoors);
            Console.WriteLine(BMW.Enginsize);
            BMW.Honk("BMW");
        }
    }*/

}