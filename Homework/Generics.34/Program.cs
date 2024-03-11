using Generics._34.Implementations;
using Lib1.Interfaces;

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

            OneDimensionalArray<int> odArrayInt = new OneDimensionalArray<int>(length, arrayValueProviderInt);
            OneDimensionalArray<int> odArrayIntBig = new OneDimensionalArray<int>(length, arrayValueProviderIntBig);
            OneDimensionalArray<bool> odArraybool = new OneDimensionalArray<bool>(length, arrayValueProviderBool);
            OneDimensionalArray<string> odArrayString = new OneDimensionalArray<string>(length, arrayValueProviderString);

            IPrinter[] printers = { odArrayInt, odArraybool, odArrayString, odArrayIntBig };

            for (int i = 0; i < printers.Length; i++)
            {
                printers[i].Print();
            }
        }
    }
}