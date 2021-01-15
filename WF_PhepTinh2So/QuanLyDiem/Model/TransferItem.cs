using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Model
{
    class TransferItem : Parcel
    {
        public double Weight;

        public TransferItem(string receiver, string toAddress, double weight)
        {
            Receiver = receiver;
            ToAddress = toAddress;
            Weight = weight;
        }

        public override double GetTransferCost()
        {
            return 10000 * Weight;
        }
    }
}
