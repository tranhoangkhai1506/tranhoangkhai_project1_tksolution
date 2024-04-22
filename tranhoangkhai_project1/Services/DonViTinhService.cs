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
            if (donViTinh.Ghi_Chu is null)
            {
                donViTinh.Ghi_Chu = "U/N";
            }
            _dataContext.tbl_DM_Don_Vi_Tinh.Add(donViTinh);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteDonViTinhAsync(int donViTinhID)
        {
            var donViTinh = await _dataContext.tbl_DM_Don_Vi_Tinh.FindAsync(donViTinhID);
            if (donViTinh != null)
            {
                _dataContext.tbl_DM_Don_Vi_Tinh.Remove(donViTinh);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<DonViTinhModel>> GetAllDonViTinhAsync()
        {
            return await _dataContext.tbl_DM_Don_Vi_Tinh.ToListAsync();
        }

        public async Task<DonViTinhModel> GetByIdAsync(int donViTinhID)
        {
            return await _dataContext.tbl_DM_Don_Vi_Tinh.FindAsync(donViTinhID);
        }

        public async Task<DonViTinhModel> GetByNameAsync(string Ten_Don_Vi_Tinh)
        {
            return await _dataContext.tbl_DM_Don_Vi_Tinh.FirstOrDefaultAsync(p => p.Ten_Don_Vi_Tinh.Equals(Ten_Don_Vi_Tinh));
        }

        public async Task UpdateDonViTinhAsync(DonViTinhModel donViTinh, int donViTinhID)
        {
            var dbDonViTinh = await _dataContext.tbl_DM_Don_Vi_Tinh.FindAsync(donViTinhID);
            if (dbDonViTinh != null)
            {
                dbDonViTinh.Ten_Don_Vi_Tinh = donViTinh.Ten_Don_Vi_Tinh;
                if (donViTinh.Ghi_Chu is null || donViTinh.Ghi_Chu == "")
                {
                    dbDonViTinh.Ghi_Chu = "U/N";
                }
                else
                {
                    dbDonViTinh.Ghi_Chu = donViTinh.Ghi_Chu;
                }
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
