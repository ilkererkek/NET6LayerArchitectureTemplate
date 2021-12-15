using Business.Abstract;
using Business.Utils.Results.Abstract;
using Business.Utils.Results.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TemplateManager : ITemplateService
    {
        private readonly ITemplateRepository _templateDal;

        public TemplateManager(ITemplateRepository templateDal)
        {
            _templateDal = templateDal;
        }

        public IDataResult<Template> Add(Template template)
        {
            _templateDal.Add(template);
            return new SuccessDataResult<Template>(template);
        }

        public IDataResult<Template> Update(Template template)
        {
            var res = GetById(template.Id);
            if (res.Success && res.Data != null)
            {

                template.UpdatedAt = DateTime.UtcNow.AddHours(3);
                template.CreatedAt = res.Data.CreatedAt;
                _templateDal.Update(template);

                return new SuccessDataResult<Template>(template);
            }

            return new ErrorDataResult<Template>();
        }

        public IResult Delete(Guid AccountId)
        {
            var res = GetById(AccountId);
            if (res.Success && res.Data != null)
            {
              
                res.Data.UpdatedAt = DateTime.UtcNow.AddHours(3);

                _templateDal.Delete(res.Data);

                return new SuccessResult();
            }

            return new ErrorResult();
        }

        public IDataResult<Template> GetById(Guid templateId)
        {
            return new SuccessDataResult<Template>(_templateDal.Get(t => t.Id == templateId));
        }

        public IDataResult<Template> GetWithInclude(Expression<Func<Template, bool>> filter = null,
            List<string> includes = null)
        {
            return new SuccessDataResult<Template>(_templateDal.GetWithInclude(filter, includes));
        }

        public IListResult<Template> GetList(Expression<Func<Template, bool>> filter = null)
        {
            return new SuccessListResult<Template>(_templateDal.GetList(filter).ToList());
        }

        public IListResult<Template> GetListWithInclude(Expression<Func<Template, bool>> filter = null, List<string> includes = null)
        {
            return new SuccessListResult<Template>(_templateDal.GetListWithInclude(filter, includes).ToList());
        }

    }
}
