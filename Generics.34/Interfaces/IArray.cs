using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics._34.Interfaces
{
    internal interface IArray<T> : IPrinter
    {
        int Length { get; }
        T this[int index] { get; }
        void ReCreate(int length);
    }
}
