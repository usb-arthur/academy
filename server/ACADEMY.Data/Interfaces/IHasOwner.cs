using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T CreatedBy { get; set; }
        
        T UpdatedBy { get; set; }
    }
}
