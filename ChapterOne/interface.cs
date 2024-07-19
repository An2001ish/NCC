using System;
namespace ChapterOne
{
    interface myInterface
    {
        void Method();
    }

    class Class : myInterface
    {
        public void Method()
        {
            Console.WriteLine("Method in myInterface was called.");
        }
    }

}

