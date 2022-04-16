namespace DAL
{
    public interface IAuth<TX>
    {
        TX Authenticate(string username, string password);
    }
}