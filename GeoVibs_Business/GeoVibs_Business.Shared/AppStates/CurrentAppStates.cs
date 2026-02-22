using DataEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoVibs_Business.Shared.AppStates
{
    public class CurrentAppStates
    {
        public User? CurrentUser { get; set; }
        public UserLevel? CurrentUserLevel { get; set; }
        public Venue? CurrentVenue { get; set; }
    }
}
