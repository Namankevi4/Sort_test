using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_lib
{
    
        class UserType : IComparable
        {
            public double IntValue { get; private set; }

            public UserType(double value)
            {
                IntValue = value;
            }

            public override string ToString()
            {
                return IntValue.ToString();
            }

            public int CompareTo(object obj)
            {
                return IntValue.CompareTo((obj as UserType).IntValue);
            }
        
    }
}
