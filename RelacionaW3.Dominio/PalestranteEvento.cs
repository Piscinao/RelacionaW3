namespace RelacionaW3.Dominio
{
    public class PalestranteEvento
    {
        public int PalestranteId { get; set; }
        //propriedade
        public Palestrante Palestrante { get; set; }

        public int EventoId { get; set; }

        public Evento Evento { get; set; }
    }


    //
}