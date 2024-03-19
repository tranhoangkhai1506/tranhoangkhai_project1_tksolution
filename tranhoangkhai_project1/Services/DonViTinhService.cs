using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class DonViTinhService : iDonViTinhService
    {
        private readonly DataContext _dataContext;
        public DonViTinhService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task AddDonViTinh(DonViTinhModel donViTinh)
        {
            _dataContext.tbl_DM_Don_Vi_Tinh.Add(donViTinh);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteDonViTinhAsync(string Ten_Don_Vi_Tinh)
        {
            var donViTinh = await _dataContext.tbl_DM_Don_Vi_Tinh.FirstOrDefaultAsync(p => p.Ten_Don_Vi_Tinh.Equals(Ten_Don_Vi_Tinh));
            if (donViTinh != null)
            {
                _dataContext.tbl_DM_Don_Vi_Tinh.Remove(donViTinh);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<DonViTinhModel>> GetAllDonViTinhAsync()
        {
            var result = await _dataContext.tbl_DM_Don_Vi_Tinh.ToListAsync();
            return result;
        }

        public async Task<DonViTinhModel> GetByIdAsync(string Ten_Don_Vi_Tinh)
        {
            var donViTinh = await _dataContext.tbl_DM_Don_Vi_Tinh.FirstOrDefaultAsync(p => p.Ten_Don_Vi_Tinh.Equals(Ten_Don_Vi_Tinh));
            return donViTinh;
        }

        public async Task UpdateDonViTinhAsync(DonViTinhModel donViTinh, string Ten_Don_Vi_Tinh)
        {
            var dbDonViTinh = await _dataContext.tbl_DM_Don_Vi_Tinh.FirstOrDefaultAsync(p => p.Ten_Don_Vi_Tinh.Equals(Ten_Don_Vi_Tinh));
            if (dbDonViTinh != null)
            {
                dbDonViTinh.Ghi_Chu = donViTinh.Ghi_Chu;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
