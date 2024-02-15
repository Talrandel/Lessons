using Generics._34.Interfaces;

namespace Generics._34.Implementations
{
    internal class BoolValueProvider : IArrayValueProvider<bool>
    {
        private static Random random = new Random();

        public bool GetRandomValue()
        {
            return random.Next(0, 2) == 0
                ? false
                : true;
        }
    }
}
