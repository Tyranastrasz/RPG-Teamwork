using System;

namespace RpgGame
{
    class EndBattleException : Exception
    {
        private string p;

        public EndBattleException(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        
    }
}
