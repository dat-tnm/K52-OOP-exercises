using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Model
{
    class Mail : Parcel
    {
        public MailType Type;

        public Mail(string receiver, string toAddress, MailType type)
        {
            Receiver = receiver;
            ToAddress = toAddress;
            Type = type;
        }

        public override double GetTransferCost()
        {
            return (double)Type;
        }
    }

    enum MailType
    {
        Normal = 2000,
        Fast = 5000
    }
}
