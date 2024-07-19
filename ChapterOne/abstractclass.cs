using System;
namespace ChapterOne
{
    abstract class AbstractClass
    {
        public abstract void AbstractMethod();

        public void NormalMethod()
        {
            Console.WriteLine("Normal Method!");
        }
    }

    class NormalClass : AbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract called and overridden.");
        }
    }
}

