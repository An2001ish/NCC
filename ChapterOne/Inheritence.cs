using System;

namespace lab1
{
    class Cook
    {
        public void skill1()
        {
            Console.WriteLine("Chef can cook basic food.");
        }
    }
    class Chef : Cook 
    {
     public void skill2() 
        {
            Console.WriteLine("Chef can cook continental.");
        }
    }
}
