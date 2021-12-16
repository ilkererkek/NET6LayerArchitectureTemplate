using Business.Utils.Results.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITemplateService
    {
        IDataResult<Template> Add(Template template);

        IResult Delete(Guid Id);

        IDataResult<Template> Update(Template template);

        IDataResult<Template> GetById(Guid templateId);

        IDataResult<Template> GetWithInclude(Expression<Func<Template, bool>> filter = null,
            List<string> includes = null);

        IListResult<Template> GetList(Expression<Func<Template, bool>> filter = null);

        IListResult<Template> GetListWithInclude(Expression<Func<Template, bool>> filter = null,
            List<string> includes = null);

    }
}
