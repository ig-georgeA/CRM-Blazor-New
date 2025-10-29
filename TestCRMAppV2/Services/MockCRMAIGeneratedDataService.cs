using CRMAppV2.Models.CRMAIGeneratedData;

namespace CRMAppV2.CRMAIGeneratedData
{
    public class MockCRMAIGeneratedDataService : ICRMAIGeneratedDataService
    {
        public Task<List<SupportTicketsType>> GetSupportTicketsList()
        {
            return Task.FromResult<List<SupportTicketsType>>(new());
        }
    }
}
