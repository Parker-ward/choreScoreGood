using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScoreGood.Models
{
  public class Chore
  {
    public Chore(string name, int time, string day, string location, int id)
    {
      Name = name;
      Time = time;
      Day = day;
      Location = location;
      Id = id;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Time { get; set; }
    public string Day { get; set; }
    public string Location { get; set; }
    public bool Done { get; set; } = false;

    public void IsDone()
    {
      this.Done = true;
    }
  }
}