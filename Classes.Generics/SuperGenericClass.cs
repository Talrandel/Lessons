using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Generics
{
    class SuperGenericClass<T, U, V, E>
        where T : struct
        where U : class
        where V : U
        where E : Enum
    {
        public T FieldOne { get; set; }
        public U FieldTwo { get; set; }
        public V FieldThree { get; set; }
        public E FieldFour { get; set; }
    }
}
