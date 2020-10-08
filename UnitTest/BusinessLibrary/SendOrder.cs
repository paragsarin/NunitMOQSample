using EmailLibrary;
using System;

namespace BusinessLibrary
{
    public class SendOrder
    {
        public bool Send(int orderid, IEmail emailinfo)
        {

            if (orderid > 0)
            {
               emailinfo.subject = orderid.ToString();
               return emailinfo.SendEmail();
            }
              
            return false;
        }

    
    }
}
