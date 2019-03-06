using System;

namespace TL.Api.SDK.Formats
{
    public interface IBaseApiResponseFormat
    {
        bool Ok { get; set; }

        object Result { get; set; }

        int? ErrorCode { get; set; }

        string Description { get; set; }

        TimeSpan? RequestTime { get; set; }
    }
}
