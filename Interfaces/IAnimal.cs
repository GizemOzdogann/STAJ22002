using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Interfaces
{
    // ID, Gender, Age
    public interface IAnimal
    {
        public int Id { get; set; }
        string? Gender { get; set; }
        int Age { get; set; }
        int LifeSpan { get; }
        int lifeTick { get; set; }
        int productTick { get; set; }
    }
    public enum Gender
    {
        Female,
        Male
    }
}
