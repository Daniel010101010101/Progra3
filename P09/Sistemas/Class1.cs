using static System.Console;

namespace Sistemas
{
    public class Class1
    {
        public void Mensaje()
        {
            WriteLine("Hola Mundo");
        }
    }
    public class Class2
    {
        void Mensaje() 
        { 
            Class1 c = new Class1();
            c.Mensaje();
        }
    }
}