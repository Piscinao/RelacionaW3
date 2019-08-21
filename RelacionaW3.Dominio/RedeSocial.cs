namespace RelacionaW3.Dominio
{
    public class RedeSocial
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string URL { get; set; }
//?nulo q a rede social pode ser nulo e o palestrante tambem
        public int? EventoId { get; set; }

        public Evento Evento { get; set; }

        public int? PalestranteId { get; set; }

        public string Palestrante { get; set; }
    }
}