using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace FormsApp.Forms
{
    public class FormService : ITransientDependency
    {
        private readonly IRepository<Form, Guid> _formRepository;

        public FormService(IRepository<Form, Guid> formRepository)
        {
            _formRepository = formRepository;
        }

        public async Task<List<Form>> GetDraftFormsAsync()
            => await _formRepository.GetListAsync(f => f.IsDraft);

        public async Task<Form> GetFormAsync(Guid formId)
            => await _formRepository.GetAsync(formId);

        public async Task<Form> GetFormByNameAsync(string name)
            => await _formRepository.GetAsync(f => f.Name == name);

        public async Task<Form> GetFormContainsNameAsync(string name)
            => await _formRepository.GetAsync(f => f.Name != null && f.Name.Contains(name));
    }
}