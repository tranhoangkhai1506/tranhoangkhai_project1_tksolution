namespace tranhoangkhai_project1.Services
{
    public interface IAuthenticationService
    {
        Task LoginAsync(string maDangNhap, string khoID);
    }

}
