using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScoreGood.Repositories
{
  public class ChoresRepository
  {
    private List<Chore> dbChores = new List<Chore>();

    public ChoresRepository()
    {
      dbChores.Add(new Chore("garbage", 4, "Monday", "bathrooms", 7583740));
      dbChores.Add(new Chore("dishes", 3, "Wednesday", "kitchen", 5397462));
      dbChores.Add(new Chore("vacuum", 5, "Tuesday", "bedrooms", 5255486));
      dbChores.Add(new Chore("dust", 6, "thursday", "bedrooms", 2565913));
    }










    internal List<Chore> GetAllChores()
    {
      return dbChores;
    }
  }
}