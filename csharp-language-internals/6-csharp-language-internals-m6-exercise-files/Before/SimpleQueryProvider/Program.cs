using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SimpleQueryProvider
{
    class Program
    {
        static void Main()
        {
            var source = new MyQuery<string>();

            // IQueryable<T> implementation provides operators
            // we may not be able to support, e.g. Select.

            var query = from x in source
                        where x.Length > 0
                        select x + "!";

            foreach (var item in query)
            {
                // Process item
            }
        }
    }

    class MyQuery<T> : IQueryable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
