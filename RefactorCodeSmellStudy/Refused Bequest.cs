using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCodeSmellStudy
{
    class Bad
    {
        abstract class Animal
        {
            public int legs;
            public void Breath() { }
        }

        class Bird : Animal
        {
            public void Fly() { }
        }

        // this class don't use superclass's Breath method
        class Chair : Animal
        {
            
        }
    }

    class Good
    {
        // Make another superclass
        abstract class Leggable
        {
            public int legs;
        }

        abstract class Animal : Leggable
        {
            public void Breath() { }
        }

        class Bird : Animal
        {
            public void Fly() { }
        }

        // Make chair class to sibling class with animal
        class Chair : Leggable
        {

        }
    }
}
