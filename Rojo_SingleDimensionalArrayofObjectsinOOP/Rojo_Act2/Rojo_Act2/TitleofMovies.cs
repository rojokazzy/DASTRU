using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojo_Act2
{
    class TitleofMovies //Base class
    {
        //Stores the movie info
        public string title;
        public string genre;

        //Constructor that initializes the title and genre
        public TitleofMovies(string ktitle, string kgenre)
        {
            title = ktitle;
            genre = kgenre;
        }
        
        public virtual void Info() //Constructor that initializes the title and genre
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Genre: " + genre);
        }
    }
    class Protagonist : TitleofMovies //Derived class
    {
        //Stores the protagonist's character name
        public string characterName;

        //Constructor that passes title and genre to the base class
        public Protagonist(string ktitle, string kgenre, string kcharacterName) : base(ktitle, kgenre)
        {
            characterName = kcharacterName;
        }
        //Overrides the Info method to include protagonist details
        public override void Info()
        {
            Console.WriteLine("\n--Protagonist--");
            base.Info(); //Calls the base class Info method
            Console.WriteLine("Character Name: " + characterName);
        }
    }
    class Director : TitleofMovies //Derived class
    {
        //Stores the director's character name
        public string name;

        //Constructor that passes title and genre to the base class
        public Director(string ktitle, string kgenre, string kname) : base(ktitle, kgenre)
        {
            name = kname;
        }
        //Overrides the Info method to include director details
        public override void Info()
        {
            Console.WriteLine("\n--Director--");
            base.Info(); //Calls the base class Info method
            Console.WriteLine("Name: " + name);
        }
    }
}
