using RouletteGame.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RouletteGame.BetsData
{
    public interface IBetsData
    {

        List<Bets> GetPreviousSpins ( Guid id); 
       // List<Bets> GetNextSpins (); 
        Bets GetBestSpins ();
        Bets GetNextSpins();
        Bets GetPreviousSpins();
        Bets GetPayOut();
        Bets AddBets( Guid id );
        // object GetPreviousSpins();
        //object AddBets();
    }
}
