using CRMAppV2.Models.Financial;

namespace CRMAppV2.Financial
{
    public interface IFinancialService
    {
        Task<List<SalesType>> GetSales();
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}
