namespace LAB07
{
    public class Desempenho
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public string Bimestre { get; set; }
        public string Materia { get; set; }
        public decimal Nota { get; set; }
        public Aluno Aluno { get; set; }
    }
}