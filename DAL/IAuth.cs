namespace DAL
{
    public interface IAuth<out TX>
    {
        TX Authenticate(string uname, string pass);
    }
}