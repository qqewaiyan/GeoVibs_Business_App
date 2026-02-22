using DataEntity;
using GeoVibs_Business.Shared.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoVibs_Business.Shared.APIContext
{
    public class UserLevelAPI
    {
        private readonly ApiClient _api;

        public UserLevelAPI(ApiClient api)
        {
            _api = api;
        }

        public async Task<List<UserLevel>?> GetAllAsync(VenueParam param)
        {
            return await _api.GetAsync<List<UserLevel>>(
                 $"{ApiRoutes.UserLevel}?venueId={param.VenueId}");
        }

        public async Task<UserLevel?> GetByIdAsync(IdParam param)
        {
            return await _api.GetAsync<UserLevel>(
                $"{ApiRoutes.UserLevel}/by-id?id={param.Id}&venueId={param.VenueId}");
        }

        public async Task SaveAsync(UserLevel room)
        {
            await _api.PostAsync(ApiRoutes.UserLevel, room);
        }

        public async Task DeleteAsync(IdParam param)
        {
            await _api.DeleteAsync($"{ApiRoutes.UserLevel}?id={param.Id}&venueId={param.VenueId}");

        }
    }
}
