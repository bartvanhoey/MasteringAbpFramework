using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace FormsApp.Forms
{
    public class FormService2 : ITransientDependency
    {
        private readonly IRepository<Form, Guid> _formRepository;
        private readonly IAsyncQueryableExecuter _asyncExecuter;

        public FormService2(IRepository<Form, Guid> formRepository, IAsyncQueryableExecuter asyncExecuter)
        {
            _formRepository = formRepository;
            _asyncExecuter = asyncExecuter;
        }

        public async Task<List<Form>> GetOrderedFormAsync(string name)
        {
            var queryable = await _formRepository.GetQueryableAsync();
            var query = from form in queryable
                        where form.Name.Contains(name)
                        orderby form.Name
                        select form;
            return await _asyncExecuter.ToListAsync(query);
        }

        public async Task<int> GetCountAsync() 
        => await _formRepository.CountAsync(x => x.Name != null && x.Name.StartsWith("A"));
    }
}