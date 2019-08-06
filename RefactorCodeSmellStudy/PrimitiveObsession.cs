using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCodeSmellStudy
{
    // level and phone is Primitive. It's meaning is uncertain without comment or name.
    class BadClass
    {
        // admin = 1, user = 2, no-auth - 3, banned - 0
        private int level = 2;
        private string phone = "010-0000-0000";

        private int GetPhoneNumber()
        {
            return int.Parse(string.Join(string.Empty, phone.Split('-')));
        }
    }


    // Change primitives into class and Level.
    // Dependented methods are also exported to each class
    class GoodClass
    {
        private Level level = Level.USER;
        private PhoneNumber phone = new PhoneNumber(010, 0, 0);
    }

    enum Level
    {
        ADMIN, USER, NOAUTH, BAN
    }

    class PhoneNumber
    {
        public int First;
        public int Second;
        public int Third;

        public PhoneNumber(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public int GetPhoneNumber()
        {
            return (First * 100000000) + (Second * 10000) + Third;
        }

        public string GetPhoneNumberString()
        {
            return GetPhoneNumber().ToString();
        }
    }
}
