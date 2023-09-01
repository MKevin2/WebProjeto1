using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebProjeto1.Models
{
    public class Cliente
    {
        
            [Display(Name = "Nome do Usuário")]
            [Required(ErrorMessage = "Por favor, preencha o Nome.")]
            [MaxLengthAttribute(70)]
            public string Nome { get; set; }

            [Display(Name = "Seu Endereço")]
            [Required(ErrorMessage = "Por favor, preencha o Endereço.")]
            public string End { get; set; }

            //11980987558 - (11 caracteres)
            [Display(Name = "Seu Telefone")]
            [Required(ErrorMessage = "Por favor, preencha o campo Telefone.")]
            [MaxLengthAttribute(11)]
            public string Tel { get; set; }

            [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
            [Display(Name = "Campo E-mail")]
            [Required(ErrorMessage = "Por favor, preencha o campo E-mail corretamente.")]
            public string Email { get; set; }

            [Display(Name = "Campo CPF")]
            [Required(ErrorMessage = "Por favor, preencha o CPF.")]
            public double CPF { get; set; }

            [Display(Name = "Data de Nascimento")]
            [Required(ErrorMessage = "Por favor, preencha a Data de Nascimento.")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
            public DateTime DateNasc { get; set; }

            /*
                Atributos: 
                Código do cliente,
                Nome,
                Endereço,
                Telefone com DDD,
                Email,
                CPF, 
                Data de Nascimento,   
                Pra usar RegularExpreesions e DataAnotation
            */
        }
    }