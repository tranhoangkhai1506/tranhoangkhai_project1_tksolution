﻿using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public interface iPhieuNhapKhoService
    {
        Task<List<PhieuNhapKhoModel>> GetAlPhieuNhapKhoAsync();
        Task<PhieuNhapKhoModel> GetByIdAsync(string So_Phieu_Nhap_Kho);

        Task AddPhieuNhapKhoAsync(PhieuNhapKhoModel phieuNhapKho);
        //Task UpdatePhieuNhapKhoAsync(PhieuNhapKhoModel phieuNhapKho, string So_Phieu_Nhap_Kho);
        Task DeletePhieuNhapKhoAsync(string So_Phieu_Nhap_Kho);
    }
}
