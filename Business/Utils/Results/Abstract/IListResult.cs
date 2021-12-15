using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utils.Results.Abstract
{
    public interface IListResult<T> : IResult
    {
        public List<T> Data { get; }

        public int Length { get; }
    }
}
