using System.Collections;

namespace Collections
{
    internal class EnumeratorExample : IEnumerable
    {
        private int counter;

        public EnumeratorExample()
        {
            counter = 10;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        struct MyEnumerator : IEnumerator
        {
            EnumeratorExample _ee;

            public MyEnumerator(EnumeratorExample ee)
            {
                _ee = ee;
            }
            public object Current => _ee.counter;

            public bool MoveNext()
            {
                bool canMoveNext = _ee.counter-- > 0;
                if (!canMoveNext)
                    Reset();
                return canMoveNext;
            }

            public void Reset()
            {
                _ee.counter = 10;
            }
        }
    }
}
