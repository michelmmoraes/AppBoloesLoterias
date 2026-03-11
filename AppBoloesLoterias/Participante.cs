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

    [Column("historico_saldo")]
    public object HistoricoSaldo { get; set; } // Armazenado como JSONB no banco

    [Column("criado_em")]
    public DateTime? CriadoEm { get; set; }
}