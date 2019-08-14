namespace RelacionaW3.API.Model
{
    //6 Propriedads
    public class Evento
    {
        public int EventoId { get; set; }

        public string Local { get; set; }

        public string DataEvento { get; set; }

        public string Tema { get; set; }

        public int QtqPessoas { get; set; }

        public string Lote { get; set; }
    }
}