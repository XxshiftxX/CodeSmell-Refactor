using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCodeSmellStudy
{
    class Bad
    {
        // AWord and BWord is almost duplicated function but it's separated
        class A
        {
            public void getAWord() { }
        }

        class B
        {
            public void getBWord() { }
        }
    }

    class Good
    {
        // Extract duplicated function into class
        class Word
        {
            public void getWord(char kind) { }
        }

        class A { }
        class B { }
    }
}
