using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCodeSmellStudy.Change_Preventers
{
    class Bad
    {
        public interface Engineer
        {
            MileStone MileStone
            {
                get;
                set;
            }
        }
        public interface MileStone { }

        public class ComputerEngineer : Engineer { }
        public class ComputerMileStone : MileStone { }
    }
}
