using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Application.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; } 
    }
}
