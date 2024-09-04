using FarmManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Interfaces
{
    public interface IAnimal
    {
        public int Id { get; set; }
        //string? Gender { get; set; }
        //int Age { get; set; }
        //int LifeSpan { get; }
        int LifeTick { get; set; }
        int ProductTick { get; set; }
        
    }
    public enum Gender
    {
        Female,
        Male
    }
}
