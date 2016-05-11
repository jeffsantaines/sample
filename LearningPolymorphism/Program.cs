using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearningPolymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pinoy = new Pinoy("Juan");

            var chinese = new Chinese("Chen");

            var american = new American("Sam");

            pinoy.SayHello();
            chinese.SayHello();
            american.SayHello();
           

            var myListOfShapes = new List<Shape> ();

            myListOfShapes.Add(new Rectangle());
            myListOfShapes.Add(new Rectangle());
            myListOfShapes.Add(new Triangle());
            myListOfShapes.Add(new Circle());
            myListOfShapes.Add(new Circle());


            foreach (var shape in myListOfShapes)
            {
                shape.Draw();
                
            }
            Console.ReadKey();
        }
    }


    public abstract class Person
    {
        private String firstName;

        public Person(string fName)
        {
            this.firstName = fName;

        }
        public void SetName(String fName)
        {
            this.firstName = fName;
        }

        public string GetName()
        {
            return firstName;
        }
 
        public abstract void SayHello();

    }

    public class Pinoy : Person
    {

        public Pinoy(string fName): base(fName)
        {
            
        }
        public override void SayHello()
        {
            Console.WriteLine(string.Format("My name is {0} Im a Filipino we say MABUHAY",GetName()));
            
        }
    }

    public class American : Person
    {
        public American(string fName) : base(fName)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine(string.Format("My name is {0} Im an American we say HELLO", GetName()));
            
        }
    }

    public class Chinese : Person
    {
        public Chinese(string fName) : base(fName)
        {
            
        }
        public override void SayHello()
        {
            Console.WriteLine(string.Format("My name is {0} Im from China we say NI HAO MA", GetName()));
            
        }

    }

    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void  Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
            Console.ReadKey();
        }
    }

    public class Circle : Shape
    {
        public override  void Draw()
        {
            Console.WriteLine("Drawing Cirle");
            
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
          
        }

    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
           
        }
    }

 // containsAorC = intList.Where(x=> x.Contains("a") || x.Contains("c"));  ????????
 // orderAlphabetDescending = intList.OrderbyDesc( x => x);
 // intlist.any
 



}


