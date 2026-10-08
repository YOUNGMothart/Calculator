using lesson2;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subjects
{
    public class MMmath : Math
    {
        void test1()
        {
            Sum(4, 5);
        }

        private void Sum(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        protected int count(int[] elementArray)
        {
            return elementArray.Count();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}