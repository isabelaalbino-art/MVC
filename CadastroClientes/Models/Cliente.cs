using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace CadastroClientes.Models;

public class Cliente
{
    public int Id {get; set;}

    [Required] // campo obrigatório
    [StringLength(100)] // tamanho máximo do texto em carcater
    public string Nome {get; set;} = string.Empty;
    [StringLength(14)]
    public string? CPF {get; set;} // ? = aceita nulo
    [EmailAddress] // indentifica que o campo é e-mail
    [StringLength(150)] // tamnho máximo do campo com 150 caracteres
    public string? Email {get; set;}
    [Phone] // indentifica que o campo é telefone
    [StringLength(20)]
    public string? Telefone {get; set;}
    [StringLength(200)]
    public string? Endereco {get; set;}
    [StringLength(100)]
    public string? Cidade {get; set;}
    [StringLength(2)]
    public string? UF {get; set;}
    [DataType(DataType.Date)] // indentifica que o campo é data e mostra somente DATA   
    [Display(Name ="Data de nascimento")] // mostra o campo ao usúario de outra forma
    public DateTime? DataNascimento {get; set;}
    public bool Ativo {get; set;} = true; 
}