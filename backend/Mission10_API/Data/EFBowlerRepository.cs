using System.Collections.Generic;
using System.Linq;

namespace Mission10_API.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private readonly BowlingLeagueContext _context;

        public EFBowlerRepository(BowlingLeagueContext context)
        {
            _context = context;
        }

        public IEnumerable<Bowlers> Bowlers => _context.Bowlers;
        public IEnumerable<Teams> Teams => _context.Teams;

        public IEnumerable<BowlerAndTeam> GetBowlersAndTeams()
        {

            var query = from bowler in _context.Bowlers
                        join team in _context.Teams on bowler.TeamID equals team.TeamID
                        where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                        select new BowlerAndTeam
                        {
                            BowlerId = bowler.BowlerID,
                            BowlerLastName = bowler.BowlerLastName,
                            BowlerFirstName = bowler.BowlerFirstName,
                            BowlerMiddleInit = bowler.BowlerMiddleInit,
                            BowlerAddress = bowler.BowlerAddress,
                            BowlerCity = bowler.BowlerCity,
                            BowlerZip = bowler.BowlerZip,
                            BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                            TeamName = team.TeamName,

                        };

            return query.ToList(); // Execute the query and return results
        }
    }
}
