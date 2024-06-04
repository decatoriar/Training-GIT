using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class LivingThing
    {
        public virtual void Grow()
        {
            Console.WriteLine("LivingThing is growing.");
        }

        public virtual void Move()
        {
            Console.WriteLine("LivingThing is moving.");
        }

        public virtual void Response()
        {
            Console.WriteLine("LivingThing is responding.");
        }

        public virtual void Reproduce()
        {
            Console.WriteLine("LivingThing is reproducing.");
        }

        public virtual void Respire()
        {
            Console.WriteLine("LivingThing is respiring.");
        }

        public virtual void Excrite()
        {
            Console.WriteLine("LivingThing is excriting.");
        }
    }
}
