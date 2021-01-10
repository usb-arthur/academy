using System.Runtime.Serialization;

namespace ACADEMY.Application.Enums.Common
{
    public enum Criteria
    {
        [EnumMember(Value = "popular")]
        Popular,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "new")]
        New,
        [EnumMember(Value = "most subscribe")]
        MostSubscribe
    }
}