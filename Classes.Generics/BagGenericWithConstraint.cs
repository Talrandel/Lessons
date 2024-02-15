using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Generics
{
    class BagGenericClass<T>
        where T: class
    {
    }

    class BagGenericStruct<T>
        where T : struct
    {
    }

    class BagGenericDefaultConstructor<T>
        where T : class, new()
    {
    }

    abstract class ItemBase : IItem
    {
        public int Id { get; }

        public ItemBase(int id)
        {
            Id = id;
        }
    }

    interface IItem
    {
        int Id { get; }
    }

    class BagGenericBaseClass<T>
        where T : ItemBase
    {
    }

    class BagGenericInterface<T>
        where T : IItem
    {
    }
}
