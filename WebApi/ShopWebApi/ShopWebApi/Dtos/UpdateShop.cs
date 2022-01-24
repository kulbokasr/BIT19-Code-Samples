using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWebApi.Dtos
{
    public class UpdateShop
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
    }
}
