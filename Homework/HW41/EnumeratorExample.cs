using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW41
{
    internal class EnumeratorExample
    {
        private int counter;

        public EnumeratorExample()
        {
            counter = 100;
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
                return _ee.counter-- > 0;
            }

            public void Reset()
            {
                _ee.counter = 100;
            }
        }
    }
}
