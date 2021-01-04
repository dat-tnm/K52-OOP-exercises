using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_ThapHaNoi
{
    class Plaform
    {
        public float x;
        public float y;
        public float w;
        public float h;

        public PlafColumn plafColumn;
        public MyStack stack;

        public Plaform(float x, float y, float w, float h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;

            stack = new MyStack();
        }
    }

    class PlafColumn
    {
        public float x;
        public float y;
        public float w;
        public float h;

        public PlafColumn(float x, float y, float w, float h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
    }
}
