using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace AppBoloesLoterias;

[Table("cota")]
public class Cota : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("bolao_id")]
    public long BolaoId { get; set; }

    [Column("participante_id")]
    public long ParticipanteId { get; set; }

    [Column("quantidade_total")]
    public int QuantidadeTotal { get; set; }

    [Column("qtde_paga_fundo")]
    public int QtdePagaFundo { get; set; }

    [Column("pago")]
    public bool Pago { get; set; }

    [Column("criado_em")]
    public DateTime? CriadoEm { get; set; }
}