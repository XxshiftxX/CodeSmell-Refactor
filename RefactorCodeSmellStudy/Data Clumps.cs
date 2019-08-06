using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCodeSmellStudy
{
    class Bad
    {
        // these are a data clumps because they related each other
        public int TaskStart;
        public int TaskEnd;
        public int Today;

        public int GetTaskLength()
        {
            return TaskEnd - TaskStart;
        }

        public bool OnTaskNow()
        {
            return TaskStart <= Today && TaskEnd >= Today;
        }
    }

    class Good
    {
        // Extract data clumps to seperate class
        class Range
        {
            public int Start;
            public int End;

            // Move methods depended on data clumps
            public int Length
            {
                get
                {
                    return End - Start;
                }
            }

            public bool IsInRange(int value)
            {
                return Start <= value && End >= value;
            }
        }

        // Change data clumps into extracted class
        public Range Task;
        public int Today;
        
        public bool OnTaskNow()
        {
            return Task.IsInRange(Today);
        }
    }
}
