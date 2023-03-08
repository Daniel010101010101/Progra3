using System;
using static System.Console;

namespace Practica7
{
    internal class Animal
    {
        private String raza;

        /*public void setRaza(String raza1)
        {
            this.raza = raza1;
        }
        public String getRaza()
        {
            switch (raza)
            {
                case "Pitbull":
                    this.raza += " Perro lindo";
                    break;

                case "Labrador":
                    this.raza += " Perro lindo x2";
                    break;
                case "Franklin":
                    this.raza += " Perro infiel";
                    break;
                case null:
                    this.raza += " No has ingresado raza ";
                    break;
                default:
                    this.raza += " Raza no definida ";
                    break;
                
            }
            return this.raza;
        }*/
        public String Raza
        {
            set { raza = value; }
            get {
                switch (raza)
                {
                    case "Pitbull":
                        this.raza += " Perro lindo";
                        break;

                    case "Labrador":
                        this.raza += " Perro lindo x2";
                        break;
                    case "Franklin":
                        this.raza += " Perro infiel";
                        break;
                    case null:
                        this.raza += " No has ingresado raza ";
                        break;
                    default:
                        this.raza += " Raza no definida ";
                        break;

                }
                return this.raza;
            }
                
               
        }
    }
}
