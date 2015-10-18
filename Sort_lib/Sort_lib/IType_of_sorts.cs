using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_lib
{
   
    interface IType_of_sorts<T>
    {
       IEnumerable<T> sort(IEnumerable<T> mass);
    }
}
