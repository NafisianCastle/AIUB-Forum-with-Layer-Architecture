namespace DAL
{
    public interface IAuth<X>
    {
        X Authenticate(string username, string password);
    }
}