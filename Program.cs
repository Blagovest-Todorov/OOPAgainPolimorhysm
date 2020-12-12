using System;

namespace OOPLections
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Inheritance -> child class -inherites members from the parent class//
    //        // Abstracton - > Define and execute an abstract actions. // We can defin abstract actions and abstr. classess- what to do ?
    //        // Encapsulation - > Hide the (members) data of the class .// Expose to the outside what is needed not more.
    //        // Polymorhism - >Access a class through its parent interface !
    //        // interfaces--much like a class wottout any content in it, .//empty class/  kust declare method, property, they say what will be implemented // 
    //        //!by child classes !
    //        // interface is implemented -> interface does not have its own object, can not instantiated, othe class implements the interface //
    //        // classes implement interface, they dont inherit it . they implement it. //follow the set of rules
    //        // derived interface ---- implements -> base interface 
    //        // 
    //        // inheritance -->  benefits -> provides --extensibility, Reusability , provide abstrsactoin, eleiminaters the redundant code
    //        // inheritans  use, "is a" relation, Dog is aanumal/ dont use  "has -relation".
    //        // Inheritance leads to  hierarchy of classess ! //whick classes are realted to chich classes, who is interiting who ?
    //        // single inheritance in C# , one class can inherits, can derive from jsut one class.
    //        // multiple inheritance is implemented by interfaces ! //a class can implements several interfaces !
    //        // public class Shape {..Construcot base(x).}
    //        //public class Circle : Shape 
    //        // {..public(int x, int y) :  base(x). --we call into the derived class constructor-we call invopke the base() class constructor .}
    //        // we can make constructor calls another constructor!
    //        //Console.WriteLine(Sleep("call sleel method"); 
    //    }
    //}
    public class Mammal 
    {
        
        public int Age { get; set; }
        public Mammal(int age)
        {
            this.Age = age;
        }

        public void Sleep()
        {
               Console.WriteLine("Shhh!, i am trying to sleep!");
        }
        
    }
    public class Dog : Mammal 
    {
       public string Breed { get; set; }

        public Dog(int age, string breed) : base(age)
        {
            this.Breed = breed;
        }
        public void WagTail()
        {
            Console.WriteLine("Tail waggling");
        } // inheriting classes can access protected members,  cannot privsate members !

    }  // no entry point here available, no /main Method found !


    
   


}
