namespace HW3_1._3_2._3_3
{
    sealed class TwoDimensionalArray : ArrayBase
    {
        private int[,] _array;

        public TwoDimensionalArray(bool isFillUser = false)
        {
            ReCreate(isFillUser);
        }

        public override void Print()
        {

        }

        protected override void FillUser()
        {

        }

        protected override void FillRandom()
        {

        }
    }
}