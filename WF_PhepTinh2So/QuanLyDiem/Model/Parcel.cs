using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Model
{
    abstract class Parcel
    {
        public string Receiver;
        public string ToAddress;

        public abstract double GetTransferCost();
    }
}
