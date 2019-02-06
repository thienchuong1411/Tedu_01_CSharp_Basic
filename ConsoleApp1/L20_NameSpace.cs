using System;

namespace NP_L20_First
{
    class A
    {
        public void Display()
        {
            Console.WriteLine("This is method of class A in First NameSpace");
        }
    }
}

namespace NP_L20_Second
{
    class A
    {
        public void Display()
        {
            Console.WriteLine("This id method of class A in Second NameSpace");
        }
    }
}

namespace NP_L20_Parent
{
    namespace NP_L20_Children
    {
        class A
        {
            public void Display()
            {
                Console.WriteLine("This is nested namespace");
            }
        }
    }
}