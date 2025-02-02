﻿using CsvHelper.Configuration;

namespace ReadCsv
{
    public  class VendasMap : ClassMap<Venda>
    {
        public VendasMap()
        {
            Map(v => v.Id).Name("id");
            Map(v => v.NomeCliente).Name("nome_cliente");
            Map(v => v.NomePacote).Name("nome_pacote");
            Map(v => v.DataNascimento).Name("data_nascimento");
            Map(v => v.DataAtendimento).Name("data_atendimento");
            Map(v => v.CidadeEstado).Name("cidade_estado");
        }
    }
}
