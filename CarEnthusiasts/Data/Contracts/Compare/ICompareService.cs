using CarEnthusiasts.Models;

namespace CarEnthusiasts.Data.Contracts.Compare
{
    public interface ICompareService
    {
        Task<ComparisonViewModel> GettAllCars();
        Task<bool> CarExist(int id);
        Task<bool> EngineExist(int carId, int engineId);
        Task<ComparedCarViewModel> GetCar(int carId, int engineId);
    }
}
