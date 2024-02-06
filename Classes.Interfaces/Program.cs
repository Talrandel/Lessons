using Classes.Interfaces;
using Classes.Interfaces.Study;

using System;

using Workers.Interfaces;
using Workers.Interfaces.Study;

namespace Classes.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            StudyClassNew studyClassNew = new StudyClassNew();

            studyClassNew.

            ((ISchool)studyClassNew).Study();

            ((IUnivercity)studyClassNew).Study();
        }
    }
}