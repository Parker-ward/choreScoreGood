using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScoreGood.Services
{
  public class ChoresService
  {
    private readonly ChoresRepository _repo;

    public ChoresService(ChoresRepository repo)
    {
      _repo = repo;
    }
    public List<Chore> GetAllChores()
    {
      return _repo.GetAllChores();
    }

    internal Chore IsDone(int id)
    {
      Chore chore = this.GetOneChore(id);
      chore.IsDone();
      return chore;
    }

    internal Chore GetOneChore(int id)
    {
      Chore chore = _repo.GetOneChore(id);
      if (chore == null) throw new Exception($"No chore at this id{id}");
      return chore;

    }
  }
}