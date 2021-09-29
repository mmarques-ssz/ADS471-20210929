using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLista2
{
    class Coisa
    {
        private int x;
        private string y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
       
        public string Y
        {
            get { return y; }
            set { y = value; }
        }

        public Coisa(int x, string y)
        {
            this.x = x;
            this.y = y;
        }

        public Coisa(int x)
        {
            this.x = x;
        }

        public Coisa()
            : this(0, "")
        { }

        public override string ToString()
        {
            return "X=" + this.x.ToString() + " - Y=" + this.y + '\n';
        }
        
        public override bool Equals(object obj)
        {
            return this.X.Equals(((Coisa)obj).X);
        }
        
    }
}
