using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;

namespace mvc_entity.Models
{
    public class Cliente
    {
        [Key]
        [Column("id")]
        public int Id { get; set;}

        [Column("nome", TypeName = "varchar")]
        [Required]
        [MaxLength(150)]
        public string Nome { get; set;}

        [Column("Data/Nascimento", TypeName = "Datetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataDeNascimento { get; set;}

        [Column("telefone", TypeName = "varchar")]
        [MaxLength(11)]
        public string Telefone {get; set;}

        [Column("rua", TypeName = "varchar")]
        [MaxLength(150)]
        public string Rua {get; set;}
        [Column("numero", TypeName = "varchar")]
        [MaxLength(6)]
        public string numero {get; set;}
        [Column("bairro", TypeName = "varchar")]
        [MaxLength(150)]
        public string Bairro {get; set;}
        [Column("cidade", TypeName = "varchar")]
        [MaxLength(150)]
        public string Cidade {get; set;}
        [Column("estado", TypeName = "varchar")]
        [MaxLength(2)]
        public string Estado {get; set;}
    }
}