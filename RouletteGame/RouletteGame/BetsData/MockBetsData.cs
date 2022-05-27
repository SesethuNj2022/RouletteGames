using RouletteGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouletteGame.BetsData
{
    public class MockBetsData : IBetsData
    {
        public Bets AddBets(Bets bets)
        {
            return bets;
        }

 
        public List<Bets> GetNextSpins()
        {
            return bets;
        }



        public async Task<IEnumerable<Bets>> GetPreviousSpins( Guid Id)
        {
            return bets;
        }

        public async Task<IEnumerable< Bets>> GetPayOut()
        {
           return bets;
        }

       

        public async Task<IEnumerable<Bets>> AddBets(Guid id)
        {
           return   bets;
        }

   
        public async Task <IEnumerable< Bets>> GetBestSpins()
        {
           return bets;
        }

        List<Bets> IBetsData.GetPreviousSpins(Guid id)
        {
            throw new NotImplementedException();
        }

        Bets IBetsData.GetBestSpins()
        {
            throw new NotImplementedException();
        }

        Bets IBetsData.GetNextSpins()
        {
            throw new NotImplementedException();
        }

        public Bets GetPreviousSpins()
        {
            throw new NotImplementedException();
        }

        Bets IBetsData.GetPayOut()
        {
            throw new NotImplementedException();
        }

        Bets IBetsData.AddBets(Guid id)
        {
            throw new NotImplementedException();
        }

        private List<Bets> bets = new List<Bets>() {
            
             new Bets()
             {
                 Id = Guid.NewGuid(),
                 Name = "Bet 1"
             },   new Bets()
             {
                 Id = Guid.NewGuid(),
                 Name = "Bet 2"
             },   new Bets()
             {
                 Id = Guid.NewGuid(),
                 Name = "Bet 3"
             },   new Bets()
             {
                 Id = Guid.NewGuid(),
                 Name = "Bet 4"
             },
        };
            
    }
}
