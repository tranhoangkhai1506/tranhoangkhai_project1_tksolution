namespace tranhoangkhai_project1.Models
{
    public static class IsAuthStatic
{
    private static bool isAuth = false;
    private static KhoUserModel userModel = new KhoUserModel();

    public static bool IsAuthenticated => isAuth;
    public static KhoUserModel UserLogin => userModel;

    public static void MarkAccountUserAsAuthenticated(string Ma_Dang_Nhap, string Kho_ID)
    {
        userModel.Ma_Dang_Nhap = Ma_Dang_Nhap;
        userModel.Kho_ID = Kho_ID;
    }
    public static void MarkAccountUserAsLoggedOut()
    {
            userModel.Ma_Dang_Nhap = "";
            userModel.Kho_ID = "";
    }

    public static void MarkUserAsAuthenticated()
    {
        isAuth = true;
    }

    public static void MarkUserAsLoggedOut()
    {
        isAuth = false;
    }
}

}
