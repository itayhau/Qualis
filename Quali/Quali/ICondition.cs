namespace Quali
{
    public interface ICondition
    {
        bool Check(int number, out string passText);
    }
}