using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utils.Results.Concrete
{
    public class SuccessListResult<T> : ListResult<T>
    {
        public SuccessListResult(List<T> data, string message) : base(data, true, message)
        {
        }

        public SuccessListResult(List<T> data) : base(data, true)
        {
        }

        public SuccessListResult(string message) : base(default, true, message)
        {
        }

        public SuccessListResult() : base(default, true)
        {
        }
    }
}
