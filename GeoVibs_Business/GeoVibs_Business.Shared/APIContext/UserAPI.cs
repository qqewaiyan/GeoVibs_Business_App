using DataEntity;
using GeoVibs_Business.Shared.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoVibs_Business.Shared.APIContext
{
    public class UserAPI
    {
        private readonly ApiClient _api;

        public UserAPI(ApiClient api)
        {
            _api = api;
        }

        public async Task<List<User>?> GetAllAsync(VenueParam param)
        {
            return await _api.GetAsync<List<User>>(
                 $"{ApiRoutes.User}?venueId={param.VenueId}");
        }

        public async Task<User?> GetByIdAsync(IdParam param)
        {
            return await _api.GetAsync<User>(
                $"{ApiRoutes.User}/by-id?id={param.Id}&venueId={param.VenueId}");
        }

        public async Task SaveAsync(User room)
        {
            await _api.PostAsync(ApiRoutes.User, room);
        }

        public async Task DeleteAsync(IdParam param)
        {
            await _api.DeleteAsync($"{ApiRoutes.User}?id={param.Id}&venueId={param.VenueId}");

        }
    }
}
