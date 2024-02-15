using Generics._34.Implementations;
using Generics._34.Interfaces;

namespace Generics._34
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 7;

            IArrayValueProvider<int> arrayValueProviderInt = new IntValueProvider();
            IArrayValueProvider<int> arrayValueProviderIntBig = new BigIntValueProvider();
            IArrayValueProvider<bool> arrayValueProviderBool = new BoolValueProvider();
            IArrayValueProvider<string> arrayValueProviderString = new StringValueProvider(length);

            IArray<int> odArrayInt = new OneDimensionalArray<int>(length, arrayValueProviderInt);
            IArray<int> odArrayIntBig = new OneDimensionalArray<int>(length, arrayValueProviderIntBig);
            IArray<bool> odArraybool = new OneDimensionalArray<bool>(length, arrayValueProviderBool);
            IArray<string> odArrayString = new OneDimensionalArray<string>(length, arrayValueProviderString);

            IPrinter[] printers = { odArrayInt, odArraybool, odArrayString, odArrayIntBig };

            for (int i = 0; i < printers.Length; i++)
            {
                printers[i].Print();
            }
        }
    }
}