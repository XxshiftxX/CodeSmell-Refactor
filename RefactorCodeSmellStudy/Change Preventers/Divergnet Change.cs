using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCodeSmellStudy.Change_Preventers
{
    // It have functions about address, post, delivery. So many changes make this class should be modified.
    class Bad
    {
        public bool isDelivered;
        private string address;
        private string addressDetail;
        private string postContent;
        private string postTitle;

        public void SetAddress(string address, string addressDetail)
        {

        }

        public void SendPost(string reciever)
        {

        }

        public void ModifyPost(string title, string content)
        {

        }

        public void Delivery()
        {

        }
    }

    class Good
    {
        // Split a big class to make each class can do one own behavior
        class Address
        {
            public string Address;
            public string AddressDetail;

            public void SetAddress(string address, string addressDetail)
            {

            }
        }

        class Post
        {
            public string Title;
            public string Content;

            public void ModifyPost(string title, string content)
            {

            }
        }

        class Delivery
        {
            public bool isDelivered;

            public static Delivery MakeDelivery(Post conetnt)
            {
                return new Delivery();
            }
        }

        class MainClass
        {
            private Address address;
            private Post post;

            public void sendPost(string reciever)
            {

            }
        }
    }
}
