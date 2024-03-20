namespace Delegates
{
    internal class Delegates
    {
        delegate void MyDelegate();

        delegate void MyDelegate2(int parameter);

        delegate int MyDelegate3();

        delegate int MyDelegate4(int parameter);

        delegate void MyDelegate5<T>(T parameter);

        delegate T MyDelegate6<T>();

        delegate TResult MyDelegate7<T, TResult>(T parameter);

        // delegate void Action<T>(T parameter);
        // delegate void Action<T1, T2>(T1 parameter1, T2 parameter2);

        // delegate TResult Func<T>(T parameter);
        // delegate void Action<T1, T2>(T1 parameter1, T2 parameter2);

        // delegate bool Predicate<T>(T parameter);
        // delegate bool Func<T, bool>(T parameter);
    }
}