using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;

namespace AppBoloesLoterias;

[Table("participante")]
public class Participante : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("nome")]
    public string Nome { get; set; }

    [Column("nome_completo")]
    public string NomeCompleto { get; set; }

    [Column("telefones")]
    public List<string> Telefones { get; set; }

    [Column("saldo")]
    public decimal Saldo { get; set; }

    [Column("criado_em")]
    public DateTime? CriadoEm { get; set; }

    // Mapeamento correto do JSONB para a nossa Lista tipada em C#
    [Column("historico_saldo")]
    public List<RegistroSaldo> HistoricoSaldo { get; set; } = new List<RegistroSaldo>();
}

public class RegistroSaldo
{
    public DateTime Data { get; set; }
    public decimal ValorAnterior { get; set; }
    public decimal ValorNovo { get; set; }
    public decimal Diferenca { get; set; }
    public string Motivo { get; set; }
}