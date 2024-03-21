using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Models;

namespace tranhoangkhai_project1.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly DataContext _context;

        public AuthenticationService(DataContext context)
        {
            _context = context;
        }

        public async Task LoginAsync(string maDangNhap, string khoID)
        {
            bool isAuth = await _context.tbl_DM_Kho_User.AnyAsync(u => u.Ma_Dang_Nhap.Equals(maDangNhap) && u.Kho_ID.Equals(khoID));
            if (isAuth)
            {
                IsAuthStatic.MarkUserAsAuthenticated();
                IsAuthStatic.MarkAccountUserAsAuthenticated(maDangNhap, khoID);
            }
            else
            {
                IsAuthStatic.MarkUserAsLoggedOut();
            }            
        }
    }

}
