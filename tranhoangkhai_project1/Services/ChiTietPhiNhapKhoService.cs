﻿using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class ChiTietPhiNhapKhoService : iChiTietPhieuNhapKhoService
    {
        private readonly DataContext _dataContext;
        public ChiTietPhiNhapKhoService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task AddChiTietPhieuNhap(ChiTietPhieuNhapKho chitietPHK)
        {
            _dataContext.tbl_DM_Nhap_Kho_Raw_Data.Add(chitietPHK);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteChiTietPhieuNhapAsync(int Id)
        {
            var chiTietPhieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho_Raw_Data.FirstOrDefaultAsync(p => p.Id == Id);
            if (chiTietPhieuNhapKho != null)
            {
                _dataContext.tbl_DM_Nhap_Kho_Raw_Data.Remove(chiTietPhieuNhapKho);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<List<ChiTietPhieuNhapKho>> GetAllChiTietByKhoIDAsync(string Nhap_Kho_ID)
        {
            var result = await _dataContext.tbl_DM_Nhap_Kho_Raw_Data.Where(p => p.Nhap_Kho_ID.Equals(Nhap_Kho_ID)).ToListAsync();
            return result;
        }

        public async Task<List<ChiTietPhieuNhapKho>> GetAllChiTietPhieuNhapKhoAsync()
        {
            var result = await _dataContext.tbl_DM_Nhap_Kho_Raw_Data.ToListAsync();
            return result;
        }

        public async Task<ChiTietPhieuNhapKho> GetByIdAsync(int Id)
        {
            var chiTietPhieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho_Raw_Data.FirstOrDefaultAsync(p => p.Id == Id);
            return chiTietPhieuNhapKho;
        }

        public async Task<ChiTietPhieuNhapKho> GetByNhapKhoIDSanPhamIdAsync(string Nhap_Kho_ID, int San_Pham_ID)
        {
            var chiTietPhieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho_Raw_Data.FirstOrDefaultAsync(p => p.Nhap_Kho_ID.Equals(Nhap_Kho_ID) && p.San_Pham_ID == San_Pham_ID);
            return chiTietPhieuNhapKho;
        }

        public async Task<ChiTietPhieuNhapKho> GetBySanPhamIDAsync(int maSanPham)
        {
            var chiTietPhieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho_Raw_Data.FirstOrDefaultAsync(p => p.San_Pham_ID == maSanPham);
            return chiTietPhieuNhapKho;
        }

        public async Task<ChiTietPhieuNhapKho> GetChiTietByKhoIDAsync(string Nhap_Kho_ID)
        {
            var chiTietPhieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho_Raw_Data.FirstOrDefaultAsync(p => p.Nhap_Kho_ID.Equals(Nhap_Kho_ID));
            return chiTietPhieuNhapKho;
        }


        public async Task UpdateChiTietPhieuNhapAsync(ChiTietPhieuNhapKho chitietPHK, int Id)
        {
            var dbChiTietPhieuNhapKho = await _dataContext.tbl_DM_Nhap_Kho_Raw_Data.FirstOrDefaultAsync(p => p.Id == Id);
            if(dbChiTietPhieuNhapKho != null)
            {
                dbChiTietPhieuNhapKho.SL_Nhap = chitietPHK.SL_Nhap;
                dbChiTietPhieuNhapKho.Don_Gia_Nhap = chitietPHK.Don_Gia_Nhap;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
