using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class KhoUserService : iKhoUserService
    {
        private readonly DataContext _dataContext;
        public KhoUserService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task AddKhoUser(KhoUserModel kho)
        {
            try
            {
                _dataContext.tbl_DM_Kho_User.Add(kho);
                await _dataContext.SaveChangesAsync();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteKhoUserAsync(int khoId, string madangnhap)
        {
            var kho = await _dataContext.tbl_DM_Kho_User.FirstOrDefaultAsync(p => p.Kho_ID == khoId && p.Ma_Dang_Nhap.Equals(madangnhap));
            if (kho != null)
            {
                _dataContext.tbl_DM_Kho_User.Remove(kho);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<KhoUserModel>> GetAllKhoUserAsync()
        {
            try
            {
                var result = await _dataContext.tbl_DM_Kho_User.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public async Task<KhoUserModel> GetByIdAsync(int khoId, string madangnhap)
        {
            try
            {
                var khoUser = await _dataContext.tbl_DM_Kho_User.FirstOrDefaultAsync(p => p.Kho_ID == khoId && p.Ma_Dang_Nhap.Equals(madangnhap));
                return khoUser;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<KhoUserModel>> GetUsersByKhoIdAsync(int khoId)
        {
            try
            {
                var result = await _dataContext.tbl_DM_Kho_User.Where(p => p.Kho_ID == khoId).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateKhoUserAsync(KhoUserModel kho, int khoId, string madangnhap)
        {
            try
            {
                var dbKhoUser = await _dataContext.tbl_DM_Kho_User.FirstOrDefaultAsync(p => p.Kho_ID == khoId && p.Ma_Dang_Nhap.Equals(madangnhap));
                if (dbKhoUser is not null)
                {
                    dbKhoUser.Ma_Dang_Nhap = kho.Ma_Dang_Nhap;
                    await _dataContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
