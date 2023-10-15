using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodHabits
{
    public interface IHabitRepository
    {
        Habit Create(Habit habit);
        IEnumerable<Habit> Read();
        Habit? ReadById(int id);
        Habit? Update(int id, Habit habit);
        Habit? Delete(int id);
    }
}
