using Business.Utils.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utils.Results.Concrete
{
    public class ListResult<T> : Result, IResult, IListResult<T>
    {
        public ListResult(List<T> data, bool success, string message) : base(success, message)
        {
            Data = data;
            Length = (data == null ? 0 : data.Count);
        }

        public ListResult(List<T> data, bool success) : base(success)
        {
            Data = data;
            Length = (data == null ? 0 : data.Count);
        }


        public List<T> Data { get; }

        public int Length { get; }
    }
}
