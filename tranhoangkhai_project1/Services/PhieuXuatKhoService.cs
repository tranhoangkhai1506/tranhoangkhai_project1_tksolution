﻿using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class PhieuXuatKhoService : iPhieuXuatKhoService
    {
        private readonly DataContext _dataContext;
        public PhieuXuatKhoService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task AddPhieuXuatKhoAsync(PhieuXuatKhoModel phieuXuatKho)
        {
            _dataContext.tbl_DM_Xuat_Kho.Add(phieuXuatKho);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeletePhieuXuatKhoAsync(string So_Phieu_Xuat_Kho)
        {
            var phieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Xuat_Kho.Equals(So_Phieu_Xuat_Kho));
            if (phieuXuatKho != null)
            {
                _dataContext.tbl_DM_Xuat_Kho.Remove(phieuXuatKho);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<PhieuXuatKhoModel>> GetAllPhieuXuatKhoAsync()
        {
            var result = await _dataContext.tbl_DM_Xuat_Kho.ToListAsync();
            return result;
        }

        public async Task<PhieuXuatKhoModel> GetByIdAsync(string So_Phieu_Xuat_Kho)
        {
            var phieuXuatKho = await _dataContext.tbl_DM_Xuat_Kho.FirstOrDefaultAsync(p => p.So_Phieu_Xuat_Kho.Equals(So_Phieu_Xuat_Kho));
            return phieuXuatKho;
        }
    }
}
