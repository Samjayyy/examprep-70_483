using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2._47
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Base
    {
        protected virtual void Execute() { }
    }

    class Derived : Base
    {
        protected override void Execute()
        {
            this.Log("Before executing");
            base.Execute();
            this.Log("After executing");
        }

        private void Log(string message) { /* Some logging code */ }
    }
}
