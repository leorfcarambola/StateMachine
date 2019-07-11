using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StateMachine
{
    class ChavePrimaria
    {
        [MaxLength(2)]
        public string IdEscrito { get; set; }
        [MaxLength(3)]
        public string TR0 { get; set; }
        [MaxLength(5)]
        public string CodigoDoEvento { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DataDeRegistro { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}")]
        public DateTime HoraDeRegistro { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}")]
        public DateTime Competencia { get; set; }
        [RegularExpression("/d{1,6}")]
        public int Id { get; set; }
    }
}
