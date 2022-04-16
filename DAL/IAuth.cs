namespace DAL
{
    public interface IAuth<TX>
    {
        TX Authenticate(string uname, string pass);
    }
}