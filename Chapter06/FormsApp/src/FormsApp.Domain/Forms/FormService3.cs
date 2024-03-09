using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FormsApp.Forms
{
    public class FormService3 : ITransientDependency
    {
        private readonly IFormRepository _formRepository;

        public FormService3(IFormRepository formRepository) 
            => _formRepository = formRepository;


            public async Task<List<Form>> GetFormsAsync(string name)
            {
                return await _formRepository.GetListAsync(name, includeDrafts: true);
                
            }
    }
}