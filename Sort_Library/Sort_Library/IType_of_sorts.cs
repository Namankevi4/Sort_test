using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Library
{
    public interface IType_of_sorts<T>
    {
        IList<T> sort(IList<T> mass);
    }
}
