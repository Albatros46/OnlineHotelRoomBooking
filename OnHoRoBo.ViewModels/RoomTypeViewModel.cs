using OnHoRoBo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHoRoBo.ViewModels
{
    public class RoomTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public RoomTypeViewModel()
        {
             
        }
        public RoomTypeViewModel(RoomTypes model)
        {
            Id=model.Id;
            Name=model.Name;
        }

        public RoomTypes ConvertModel(RoomTypeViewModel vm)
        {
            return new RoomTypes()
            {
                Id = vm.Id,
                Name = vm.Name,
            };
        }
    }
}
