using CsvHelper;
using CsvHelper.Configuration;
using ReadCsv;
using System.Globalization;

var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    HasHeaderRecord = true,
};

List<Venda> vendas;
using (var reader = new StreamReader("../../../Venda.csv"))
using(var csv = new CsvReader(reader, config))
{
    csv.Context.RegisterClassMap<VendasMap>();
 
     vendas = csv.GetRecords<Venda>().ToList();

    foreach (var venda in vendas)
    {
        Console.WriteLine($"Cliente: {venda.NomeCliente} Pacote: { venda.NomePacote}");
    }
}

using( var writer = new StreamWriter("dados_vendas.csv"))
using(var csv = new CsvWriter(writer, config))
{
    csv.Context.RegisterClassMap<VendasMap>();
    csv.WriteHeader<Venda>();

    csv.NextRecord();

    csv.WriteRecords(vendas);
}

Console.ReadLine();
