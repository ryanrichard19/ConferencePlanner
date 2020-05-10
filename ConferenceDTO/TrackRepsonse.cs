using System;
using System.Collections.Generic;

namespace ConferenceDTO
{
    public class TrackRepsonse: Track
    {
        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
