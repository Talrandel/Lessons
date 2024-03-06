namespace Generics._34
{
    class ValueProvider
    {
        public object GetRandomValue(Type currentType)
        {
            currentType = currentType.GenericTypeArguments[0];
            Random rand = new Random();
            if (currentType == typeof(int))
            {
                return rand.Next();
            }
            if (currentType == typeof(double))
            {
                return rand.Next();
            }
            if (currentType == typeof(bool))
            {
                return rand.Next();
            }
            if (currentType == typeof(string))
            {
                return rand.Next();
            }
            if (currentType == typeof(BankAccount))
            {

            }
        }
    }
}