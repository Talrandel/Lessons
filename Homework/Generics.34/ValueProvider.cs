// namespace Generics._34
// {
//     class ValueProvider
//     {
//         public object GetRandomValue(Type currentType)
//         {
//             if (currentType == typeof(string))
//             {
//                 return "";
//             }
//             if (currentType == typeof(int))
//             {
//                 return Random.Shared.Next(-100, 101);
//             }
//             if (currentType == typeof(double))
//             {
//                 return Random.Shared.NextDouble(-100, 101);
//             }
//             if (currentType == typeof(bool))
//             {
//                 return true;
//             }
            
//             return null;
//         }
//     }

//     class StringValueProvider
//     {
//         public string GetRandomValue()
//         {
//             return "1256875498yfg9h";
//         }
//     }
// }