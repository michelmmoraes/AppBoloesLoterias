using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace AppBoloesLoterias;

[Table("previsao")]
public class Previsao : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("concurso_id")]
    public long ConcursoId { get; set; }

    [Column("palpites")]
    public string Palpites { get; set; } // Armazenado como JSONB (pode ser uma lista de sugestões)

    [Column("dezenas_proibidas")]
    public int[] DezenasProibidas { get; set; } // O integer[] do SQL mapeia para int[]

    [Column("analise_metricas")]
    public string AnaliseMetricas { get; set; } // Armazenado como JSONB (estatísticas calculadas)

    [Column("criado_em")]
    public DateTime? CriadoEm { get; set; }
}