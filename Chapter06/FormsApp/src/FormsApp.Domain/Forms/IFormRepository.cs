using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace FormsApp.Forms
{
    public interface IFormRepository :  IRepository<Form, Guid>
    {
        Task<List<Form>> GetListAsync(string name, bool includeDrafts);
        public Task DeleteAllDraftsAsync();

        Task<Form> GetWithQuestionsAsync(Guid formId);
    }


}