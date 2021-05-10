using BlazorProducts.Features;
using Entities.Models;
using Entities.RequestFeatures;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProducts.HttpRepository
{
    public interface IProductHttpRepository
    {
        Task<PagingResponse<Product>> GetProducts(ProductParameters productParameters);
    }
}