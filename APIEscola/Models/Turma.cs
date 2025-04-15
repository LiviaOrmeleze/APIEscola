using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; }
        public Guid CursoId { get; set; }

        [Required(ErrorMessage = "O Campo Data de Inicio é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data Informada não é Válida")]
        public DateOnly DataInicio { get; set; }

        [Required(ErrorMessage = "O Campo Data de Fim é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data Informada não é Válida")]
        public DateOnly DataFim { get; set; }

        [Required(ErrorMessage = "O Campo Descricao é Obrigatório")]
        [MaxLength(255, ErrorMessage = "A descrição deve ter no máximo 255 caracteres")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O Campo Sigla é Obrigatório")]
        [MaxLength(10, ErrorMessage = "A sigla deve ter no máximo 10 caracteres")]
        public string? Sigla { get; set; }

    }
}
