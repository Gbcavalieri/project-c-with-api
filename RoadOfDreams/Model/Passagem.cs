using System.ComponentModel.DataAnnotations.Schema;

namespace RoadOfDreams.Model
{

    [Table("Passagens")]
    public class Passagem
    {

        [Column("id_passagens")]
        public int Id { get; set; }

        [Column("agencia")]
        public string Agencia { get; set; } = string.Empty;


        [Column("data_ida")]
        public string Ida { get; set; } = string.Empty;

        [Column("data_volta")]
        public string Volta { get; set; } = string.Empty;

        [Column("destino")]
        public string Destino { get; set; } = string.Empty;

        [Column("origem")]
        public string Origem { get; set; } = string.Empty;

        [Column("quantidade_lugares")]
        public string Lugares { get; set; } = string.Empty;





    }

}
