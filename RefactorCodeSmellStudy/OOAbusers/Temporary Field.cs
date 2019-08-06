using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCodeSmellStudy
{
    class Bad
    {
        // Except when using getValue, switchTemp isn't used
        private int switchTemp;

        public int getValue()
        {
            /* DO SOMETHING WITH switchTemp */
            return 10;
        }

        public int getResult()
        {
            return getValue() * 10;
        }
    }

    class Good
    {
        // Extract switchTemp and related method to class
        class ValueMaker
        {
            private int switchTemp;
            public int Value
            {
                get
                {
                    /* DO SOMETHING WITH switchTemp */
                    return 10;
                }
            }
        }

        public int getResult()
        {
            return new ValueMaker().Value * 10;
        }
    }
}
