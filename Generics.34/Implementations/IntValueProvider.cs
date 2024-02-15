using Generics._34.Interfaces;

namespace Generics._34.Implementations
{
    class IntValueProvider : IArrayValueProvider<int>
    {
        private static Random random = new Random();

        public int GetRandomValue()
        {
            return random.Next(0, 101);
        }
    }
    class BigIntValueProvider : IArrayValueProvider<int>
    {
        private static Random random = new Random();

        public int GetRandomValue()
        {
            return random.Next(1_000_000, 1_000_000_000);
        }
    }
}
