using Accuweather.Core.Models;
using Application.Interfaces;
using Application.Interfaces.Services;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Application.Services
{

    public class GardenService : IGardenService
    {
        private readonly IGardenCalendaryContext _context;
        public GardenService(IGardenCalendaryContext context)
        {
            _context = context;
        }

        public async Task<GardensRecommendationsModel> GetAllByUserId(int userId)
        {
            var httpClient = new HttpClient();
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
            if (user is null)
            {
                throw new NullReferenceException("Пользователь не найден");
            }

            var gardens = await _context.UserGardens.Where(x => x.UserId == userId)
                .Include(x => x.Garden)
                .ThenInclude(x => x.PlantsInGarden)
                .ThenInclude(x => x.Plant)
                .Select(x => x.Garden)
                .ToListAsync();
            
            var resModel = new GardensRecommendationsModel();
            resModel.Gardens = new List<GardensModel>();
            foreach (var garden in gardens)
            {
                var city = await _context.RReestrObjects.FirstOrDefaultAsync(x => x.Id == garden!.ObjectId);
                if (city is null)
                {
                    throw new Exception("Не найден такой город в БД");
                }

                var gardenModel = new GardensModel()
                {
                    Id = garden!.Id,
                    Name = garden.Name,
                    CityName = city!.Name!,
                    PlantsWithRecommendations = new()
                };
                
                foreach (var plant in garden.PlantsInGarden)
                {
                    var response = await httpClient
                        .GetAsync($"https://localhost:7162/Recommendation/GetRecommendationByPlantId" +
                        $"/GardenId?gardenId={gardenModel.Id}&plantId={plant.RPlantId}");
                    response.EnsureSuccessStatusCode();
                    // Получение ответа и извлечение имени города
                    string recommendation = await response.Content.ReadAsStringAsync();

                    var thisPlant = plant.Plant;
                    var plantWithRecommendation = new PlantWithRecommendations();
                    plantWithRecommendation.Id = plant.Id;
                    plantWithRecommendation.Name = thisPlant!.Name;
                    plantWithRecommendation.RPlantId = plant.RPlantId;
                    plantWithRecommendation.Recommendation = JsonConvert.DeserializeObject<RecommendationModel>(recommendation)!;
                    gardenModel.PlantsWithRecommendations.Add(plantWithRecommendation);
                }

                resModel.Gardens.Add(gardenModel);
            }

            return resModel;
        }
    }
}
