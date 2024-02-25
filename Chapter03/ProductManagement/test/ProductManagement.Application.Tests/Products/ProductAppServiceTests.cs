using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Modularity;
using Xunit;

namespace ProductManagement.Products
{
    public abstract class ProductAppServiceTests<TStartupModule> : ProductManagementApplicationTestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {


        private readonly IProductAppService _productAppService;

        public ProductAppServiceTests()
        {
            _productAppService = GetRequiredService<IProductAppService>();
        }

        [Fact]
        public async Task Should_Get_Product_List()
        {
            var result = await _productAppService.GetPagedListAsync(new PagedAndSortedResultRequestDto());

            result.TotalCount.ShouldBe(3);
            result.Items.ShouldContain(i => i.Name.Contains("Acme Monochrome Laser Printer"));
        }


    }
}