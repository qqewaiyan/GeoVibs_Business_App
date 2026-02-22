using DataEntity;
using GeoVibs_Business.Shared.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoVibs_Business.Shared.APIContext
{
    public class RoomAPI
    {
        private readonly ApiClient _api;

        public RoomAPI(ApiClient api)
        {
            _api = api;
        }

        public async Task<List<Room>?> GetAllAsync(VenueParam param)
        {
           return await _api.GetAsync<List<Room>>(
                $"{ApiRoutes.Room}?venueId={param.VenueId}");
        }

        public async Task<Room?> GetByIdAsync(IdParam param)
        {
            return await _api.GetAsync<Room>(
                $"{ApiRoutes.Room}/by-id?id={param.Id}&venueId={param.VenueId}");
        }

        public async Task SaveAsync(Room room)
        {
            await _api.PostAsync(ApiRoutes.Room, room);
        }

        public async Task DeleteAsync(IdParam param)
        {
            await _api.DeleteAsync($"{ApiRoutes.Room}?id={param.Id}&venueId={param.VenueId}");

        }
    }

}
