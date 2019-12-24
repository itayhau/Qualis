using System;

namespace Quali
{
    public interface IFizzBuzzGamer
    {
        void PlayFizzBuzz(IWriter writer, ICondition[] conditionsPlayer1, ICondition[] conditionPlayer2, Func<int, int> whichPlayer);
    }
}