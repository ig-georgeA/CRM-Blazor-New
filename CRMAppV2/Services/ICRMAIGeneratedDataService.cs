using CRMAppV2.Models.CRMAIGeneratedData;

namespace CRMAppV2.CRMAIGeneratedData
{
    public interface ICRMAIGeneratedDataService
    {
        Task<List<SupportTicketsType>> GetSupportTicketsList();
    }
}
