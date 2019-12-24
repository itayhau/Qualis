namespace Quali
{
    public interface IFizzBuzzGamer
    {
        void PlayFizzBuzz(IWriter writer, params ICondition[] conditions);
    }
}