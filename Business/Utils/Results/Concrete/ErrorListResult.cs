using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utils.Results.Concrete
{
    public class ErrorListResult<T> : ListResult<T>
    {
        public ErrorListResult(List<T> data, string message) : base(data, false, message)
        {
        }

        public ErrorListResult(List<T> data) : base(data, false)
        {
        }

        public ErrorListResult(string message) : base(default, false, message)
        {
        }

        public ErrorListResult() : base(default, true)
        {
        }
    }
}
