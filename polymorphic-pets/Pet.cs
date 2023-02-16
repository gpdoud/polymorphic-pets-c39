using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphic_pets;
internal class Pet {

    public virtual void Speak() {
        Console.WriteLine("NO SOUND!");
    }

}

internal class Dog : Pet {

    public override void Speak() {
        Console.WriteLine("Bark!");
    }

}

internal class Cat : Pet {

    public override void Speak() {
        Console.WriteLine("Meow!");
    }

}
