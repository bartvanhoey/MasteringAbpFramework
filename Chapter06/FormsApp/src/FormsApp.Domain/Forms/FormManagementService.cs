using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace FormsApp.Forms
{
    public class FormManagementService : ITransientDependency
    {
        private readonly IRepository<FormManager> _formManagerRepository;

        public FormManagementService(IRepository<FormManager> formManagerRepository)
            => _formManagerRepository = formManagerRepository;

        public async Task<List<FormManager>> GetManagersAsync() 
            => await _formManagerRepository.GetListAsync();

    }
}