using MageCreatorAPI.Models;
using Microsoft.VisualBasic;

namespace MageCreatorAPI.Services.MageServices
{
    public class MageServices : IMageService
    {
        private readonly MageData _data;

        public MageServices(MageData data) 
        {
            _data = data;
        }

        public async Task<List<Magician>> AddMage(Magician mage)
        {
            _data.Magicians.Add(mage);

            await _data.SaveChangesAsync();

            return await _data.Magicians.ToListAsync();
        }

        public async Task<List<Magician>> GetAllMages()
        {
            var mages = await _data.Magicians.ToListAsync();
            return mages;
        }

        public async Task<Magician?> GetMage(int id)
        {
            var mage = await _data.Magicians.FindAsync(id);
            if (mage is null)
            {
                return null;
            }

            return mage;
        }

        public async Task<List<Magician>?> RemoveMage(int id)
        {
            var mage = await _data.Magicians.FindAsync(id);
            if (mage is null)
            {
                return null;
            }

            _data.Magicians.Remove(mage);
            await _data.SaveChangesAsync();
            return await _data.Magicians.ToListAsync();
        }

        public async Task<List<Magician>?> UpdateMage(int id, Magician request)
        {
            var mage = await _data.Magicians.FindAsync(id);
            if (mage is null)
            {
                return null;
            }

            mage.id = request.id;// - Resulta em um erro devido ao requerimento de mudança no ID, é necessário colocar o mesmo ID durante a modificação
            mage.Name = request.Name;
            mage.MagicType = request.MagicType;
            mage.Specialization = request.Specialization;

            await _data.SaveChangesAsync();

            return await _data.Magicians.ToListAsync();
        }
    }
}
