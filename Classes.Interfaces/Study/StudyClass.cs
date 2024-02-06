using Classes.Interfaces.Study;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers.Interfaces.Study
{
    internal class StudyClassOld : ISchool, IUnivercity
    {
        public void Study()
        {
            Console.WriteLine("Какой интерфейс я реализую?");
        }
    }

    internal class StudyClassNew : ISchool, IUnivercity
    {
        void ISchool.Study()
        {
            Console.WriteLine("Учусь в школе");
        }

        void IUnivercity.Study()
        {
            Console.WriteLine("Учусь в институте");
        }
    }
}
