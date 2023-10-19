using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodHabits
{
    public class HabitsRepository : IHabitRepository
    {
        private int _nextId = 1;
        private readonly List<Habit> _habits = new();

        public HabitsRepository()
        {
            _habits.Add(new Habit() { Id = _nextId++, Name = "Clean toilet", Frequency = 7 });
            _habits.Add(new Habit() { Id = _nextId++, Name = "Change toothbrush", Frequency = 90 });
        }

        public Habit Create(Habit habit)
        {
            habit.Validate();
            habit.Id = _nextId++;
            _habits.Add(habit);
            return habit;
        }

        public IEnumerable<Habit> Read()
        {
            //Copy list
            IEnumerable<Habit> result = new List<Habit>(_habits);
            
            
            return result;
        }

        public Habit? ReadById(int id)
        {
            return _habits.Find(habit => habit.Id == id);
        }
        
        public Habit? Update(int id, Habit habit)
        {
            Habit? habitToUpdate = ReadById(id);
            if (habitToUpdate == null)
            {
                return null;
            }
            habitToUpdate.Name = habit.Name;
            habitToUpdate.Frequency = habit.Frequency;
            return habitToUpdate;
        }

        public Habit? Delete(int id)
        {
            Habit? habitToDelete = ReadById(id);
            if (habitToDelete == null)
            {
                return null;
            }
            _habits.Remove(habitToDelete);
            return habitToDelete;
        }



    }

    
}