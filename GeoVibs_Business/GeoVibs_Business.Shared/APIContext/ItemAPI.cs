using DataEntity;
using GeoVibs_Business.Shared.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoVibs_Business.Shared.APIContext
{
    public class ItemAPI
    {
        private readonly ApiClient _api;

        public ItemAPI(ApiClient api)
        {
            _api = api;
        }

        public async Task<List<Item>?> GetAllAsync(VenueParam param)
        {
            return await _api.GetAsync<List<Item>>(
                 $"{ApiRoutes.Item}?venueId={param.VenueId}");
        }

        public async Task<Item?> GetByIdAsync(IdParam param)
        {
            return await _api.GetAsync<Item>(
                $"{ApiRoutes.Item}/by-id?id={param.Id}&venueId={param.VenueId}");
        }

        public async Task SaveAsync(Item room)
        {
            await _api.PostAsync(ApiRoutes.Item, room);
        }

        public async Task DeleteAsync(IdParam param)
        {
            await _api.DeleteAsync($"{ApiRoutes.Item}?id={param.Id}&venueId={param.VenueId}");

        }
    }
}
