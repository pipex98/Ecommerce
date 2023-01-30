using ecommerce.Common;
using ecommerce.Models;

namespace ecommerce.Helpers
{
    public interface IOrdersHelper
    {
        Task<Response> ProcessOrderAsync(ShowCartViewModel model);
        Task<Response> CancelOrderAsync(int id);
    }
}
