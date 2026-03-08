using DataEntity;
using GeoVibs_Business.Shared.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoVibs_Business.Shared.APIContext
{
    public class SessionAPI
    {
        private readonly ApiClient _api;

        public SessionAPI(ApiClient api)
        {
            _api = api;
        }

        public async Task<List<Session>?> GetAllAsync(VenueParam param)
        {
            return await _api.GetAsync<List<Session>>(
                 $"{ApiRoutes.Session}?venueId={param.VenueId}");
        }

        public async Task<Session?> GetByIdAsync(IdParam param)
        {
            return await _api.GetAsync<Session>(
                $"{ApiRoutes.Session}/by-id?id={param.Id}&venueId={param.VenueId}");
        }

        public async Task SaveAsync(Session room)
        {
            await _api.PostAsync(ApiRoutes.Session, room);
        }

        public async Task DeleteAsync(IdParam param)
        {
            await _api.DeleteAsync($"{ApiRoutes.Session}?id={param.Id}&venueId={param.VenueId}");

        }
    }
}

