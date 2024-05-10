using CsvHelper.Configuration.Attributes;

namespace ReadCsv
{
    public  class Venda
    {
        //[Name("id")]
        public int Id { get; set; }
       // [Name("name_cliente")]
        public string NomeCliente { get; set; }
       // [Name("nome_projato")]
        public string NomePacote { get; set; }
        //[Name("data_nascimento")]
        public DateTime DataNascimento { get; set; }
       // [Name("data_nascimento")]
        public DateTime DataAtendimento { get; set; }
       // [Name("cidade_estado")]
        public string CidadeEstado { get; set; }

    }
}

//podemos fazer o mapeamento com as anotações porem a mesma fica muito poluida. Para resolver isso podemos criar um Mpa
//vind Class VendasMap