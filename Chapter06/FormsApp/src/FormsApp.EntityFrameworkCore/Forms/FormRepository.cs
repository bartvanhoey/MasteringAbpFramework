using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormsApp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FormsApp.Forms
{
    public class FormRepository : EfCoreRepository<FormsAppDbContext, Form, Guid>, IFormRepository
    {
        public FormRepository(IDbContextProvider<FormsAppDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task DeleteAllDraftsAsync()
        {
            var dbContext = await GetDbContextAsync();
            await dbContext.Database.ExecuteSqlRawAsync("DELETE FROM Forms WHERE IsDraft = 1");
        }

        public async Task<List<Form>> GetListAsync(string name, bool includeDrafts)
        {
            var dbContext = await GetDbContextAsync();
            return await dbContext.Set<Form>()
                .Where(x => x.Name != null && x.Name.Contains(name))
                .WhereIf(!includeDrafts, x => !x.IsDraft)
                .ToListAsync();
        }


        // public async Task<List<Form>> GetListAsync(string name, bool includeDrafts)
        // {
        //     var dbContext = await GetDbContextAsync();
        //     var query = dbContext.Forms.Where(f => f.Name != null && f.Name.Contains(name));
        //     if (!includeDrafts)
        //     {
        //         query = query.Where(x => !x.IsDraft);
        //     }
        //     return await query.ToListAsync();
        // }




    }
}