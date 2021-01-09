using ACADEMY.Application.Enums.Common;

namespace ACADEMY.Application.Requests.Common
{
    public class GetStatisticRequest
    {
        public int? Payload { get; set; }

        public Criteria? Criteria { get; set; }
    }
}