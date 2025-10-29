using CRMAppV2.Models.CRMApp;

namespace CRMAppV2.CRMApp
{
    public interface ICRMAppService
    {
        Task<List<MeetingsTasksType>> GetMeetingsTasksList();
    }
}
