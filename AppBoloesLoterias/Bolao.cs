using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace AppBoloesLoterias;

[Table("bolao")]
public class Bolao : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("concurso_id")]
    public long ConcursoId { get; set; }

    [Column("bolao_origem_id")]
    public long? BolaoOrigemId { get; set; } // Nullable, pois nem todo bolão tem origem

    [Column("valor_cota")]
    public decimal ValorCota { get; set; }

    [Column("status")]
    public string Status { get; set; } // ABERTO, FECHADO ou CANCELADO

    [Column("palpites_sugeridos")]
    public int[] PalpitesSugeridos { get; set; }

    [Column("criado_em")]
    public DateTime? CriadoEm { get; set; }

    [Column("percentual_fundo")]
    public decimal PercentualFundo { get; set; }

    [Column("premio_total")]
    public decimal PremioTotal { get; set; }
}