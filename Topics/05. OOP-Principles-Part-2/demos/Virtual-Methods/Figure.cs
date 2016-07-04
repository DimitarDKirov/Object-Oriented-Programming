using System;

internal abstract class Figure
{
    public virtual void Draw()
    {
        Console.WriteLine("I am a figure of unknown kind:");
        Console.WriteLine(this.GetType().Name);
    }
<<<<<<< HEAD
=======

    public abstract void Important()
    {

    }
>>>>>>> 5e254e5f6fd82629fd5a4f04e2385d94382f27e1
}
