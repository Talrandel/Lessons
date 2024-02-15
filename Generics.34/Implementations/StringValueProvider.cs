using Generics._34.Interfaces;

namespace Generics._34.Implementations
{
    internal class StringValueProvider : IArrayValueProvider<string>
    {
        private char[] _letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        private static Random random = new Random();

        public int Length { get; set; }

        public StringValueProvider(int length)
        {
            Length = length;
        }

        public string GetRandomValue()
        {
            char[] result = new char[Length];
            for (int i = 0; i < result.Length; i++)
            {
                int index = random.Next(0, _letters.Length);
                result[i] = _letters[index];
            }

            return new string(result);
        }
    }
}
