namespace Delegates
{
    public delegate void MyDelegate();

    public delegate void MyDelegate2(int parameter);

    public delegate int MyDelegate3();

    public delegate int MyDelegate4(int parameter);

    public delegate void MyDelegate5<T>(T parameter);

    public delegate T MyDelegate6<T>();

    public delegate TResult MyDelegate7<T, TResult>(T parameter);

    // delegate void Action<T>(T parameter);
    // delegate void Action<T1, T2>(T1 parameter1, T2 parameter2);

    // delegate TResult Func<T>(T parameter);
    // delegate void Action<T1, T2>(T1 parameter1, T2 parameter2);

    // delegate bool Predicate<T>(T parameter);
    // delegate bool Func<T, bool>(T parameter);
}