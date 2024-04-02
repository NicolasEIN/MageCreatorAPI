using MageCreatorAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MageCreatorAPI.Services.MageServices
{
    public interface IMageService
    {
        Task<List<Magician>> GetAllMages();
        Task<Magician> GetMage(int id);
        Task<List<Magician>> AddMage(Magician mage);
        Task<List<Magician>> RemoveMage(int id);
        Task<List<Magician>> UpdateMage(int id, Magician request);

    }
}
