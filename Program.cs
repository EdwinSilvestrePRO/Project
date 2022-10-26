using System;

namespace Codevelp 
{
    public enum Subyasent 
    {
        one,
        two,
        tree,
        four,
        five
    }
    public class Initial : object 
    {
        private Subyasent numbers;
        public Subyasent Number 
        {
            get { return this.numbers; }
            set { this.numbers = value; }
        }
        public static void Main (string[] Arguments)
        {
            Initial Beginning = new Initial();
            /* 
            Las enumeraciones son un conjunto de valores subyasentes
            que son valores int (enteros), uint (no enteros pero si naturales), short, etc...
            para proveer orden en las consulta de la enumeracion o de la coleccion de 
            valores que estan enumerados por su nombre. 

            En una clase se puede crear una propiedad de tipo enumeracion para que contenga
            el primer valor subyasente que este tega en la enumeracion si no se le asigna por el programador, pasa 
            si se le asigna entonces empieza con el valor 0, esta variable solo 
            acepta valores subyacentes de la coleccion en la cual se baso.

            ejemplo: 
            */
            Beginning.Number = Subyasent.two;
            // Beginning.Number = Subyasent.two;
            Console.WriteLine((uint)Beginning.Number);
        }
    }
}