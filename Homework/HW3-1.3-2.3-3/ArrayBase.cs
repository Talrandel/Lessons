namespace HW3_1._3_2._3_3
{
    abstract class ArrayBase
    {
        // protected ArrayBase(bool isFillUser = false)
        // {
        // }

        public abstract void Print();

        public virtual void ReCreate(bool isFillUser = false)
        {
            if (isFillUser)
            {
                FillUser();
            }
            else
            {
                FillRandom();
            }
        }

        protected abstract void FillUser();

        protected abstract void FillRandom();
    }
}