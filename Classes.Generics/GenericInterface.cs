using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Generics
{
    public interface ISomeInterfaceType
    {
        void Do();
    }

    public class SomeInterfaceTypeExample : ISomeInterfaceType
    {
        public void Do()
        {
            Console.WriteLine("Реализую ISomeInterfaceType");
        }
    }

    public class SomeClassInterface
    {
        public ISomeInterfaceType SomeInterfaceType { get; set; }
    }

    public class SomeClassGeneric<T>
        where T: ISomeInterfaceType
    {
        public T SomeInterfaceType { get; set; }
    }

    internal class AnotherClass
    {
        public void Example()
        {
            ISomeInterfaceType someInterfaceType = new SomeInterfaceTypeExample();


            SomeClassInterface s1 = new SomeClassInterface();
            s1.SomeInterfaceType = someInterfaceType;


            SomeClassGeneric<ISomeInterfaceType> s2 = new SomeClassGeneric<ISomeInterfaceType>();
            s2.SomeInterfaceType = someInterfaceType;
        }
    }

    public class SomeClassGenericExtended<T>
        where T : class, ISomeInterfaceType, IComparable<T>, 
        IEquatable<T>, IFormattable, IDisposable, new()
    {
        public T SomeInterfaceType { get; set; }
    }
}
