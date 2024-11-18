using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Application.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Name { get; set; }

    }
}
