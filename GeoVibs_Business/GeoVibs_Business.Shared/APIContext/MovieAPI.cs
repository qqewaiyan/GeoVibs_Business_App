using DataEntity;
using GeoVibs_Business.Shared.Services;

namespace GeoVibs_Business.Shared.APIContext
{
    public class MovieAPI
    {
        private readonly ApiClient _api;

        public MovieAPI(ApiClient api)
        {
            _api = api;
        }

        public async Task<List<Movie>?> GetAllAsync(VenueParam param)
        {
            return await _api.GetAsync<List<Movie>>(
                 $"{ApiRoutes.Movie}?venueId={param.VenueId}");
        }

        public async Task<Movie?> GetByIdAsync(IdParam param)
        {
            return await _api.GetAsync<Movie>(
                $"{ApiRoutes.Movie}/by-id?id={param.Id}&venueId={param.VenueId}");
        }

        public async Task SaveAsync(Movie room)
        {
            await _api.PostAsync(ApiRoutes.Movie, room);
        }

        public async Task DeleteAsync(IdParam param)
        {
            await _api.DeleteAsync($"{ApiRoutes.Movie}?id={param.Id}&venueId={param.VenueId}");

        }
    }

}
