using System.Collections.Generic;

namespace EFCurso.WebAPI.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta identidadeSecreta { get; set; }
        public List<HeroiBatalha> HeroisBatalhas { get; set; }
        public List<Arma> Armas { get; set; }
    }
}
