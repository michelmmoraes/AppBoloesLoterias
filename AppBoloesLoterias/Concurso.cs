using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace AppBoloesLoterias;

[Table("concurso")]
public class Concurso : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("tipo")]
    public string Tipo { get; set; } // Representa o seu tipo 'loteria' (Mega-Sena, Lotofácil, etc)

    [Column("numero")]
    public int Numero { get; set; }

    [Column("data_sorteio")]
    public DateTime? DataSorteio { get; set; }

    [Column("resultado_dezenas")]
    public int[] ResultadoDezenas { get; set; } // O SQL integer[] mapeia direto para int[] no C#

    [Column("resultado_secundario")]
    public int[] ResultadoSecundario { get; set; }

    [Column("criado_em")]
    public DateTime? CriadoEm { get; set; }
}