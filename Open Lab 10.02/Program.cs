using System;

namespace Open_Lab_10._02
{

    class Book
    {
        string title;
        int pages;
        string category;
        string autor;
        int releaseDate;
        public void F(string a)
        {
            title = a;

        }
        public void G(int b)
        {
            pages = b;

        }
        public void H(string c)
        {
            category = c;

        }
        public void J(string e)
        {
            autor = e;

        }
        public void K(int f)
        {
            releaseDate = f;

        }
        public void MusimBytViacKreativnySNazvami()
        {
            Console.WriteLine(title + " " + pages + " " + category + " " + autor + " " + releaseDate);
        }

    }

    class Program
    {
        

     
        
            static void Main(string[] args)
            {
                Book LOTR = new Book();

                LOTR.F("Abeceda");
                LOTR.G(5);
                LOTR.H("komédia");
                LOTR.J("Jožo");
                LOTR.K(1985);
                LOTR.MusimBytViacKreativnySNazvami();
                
            }
        
    }
}
