
using polymorphic_pets;

Pet p1 = new Pet();

Dog d1 = new Dog();

Cat c1 = new Cat();

Pet[] pets = new Pet[] { d1, c1 };

foreach(Pet pet in pets) {
    pet.Speak();
}