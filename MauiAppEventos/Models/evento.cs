namespace MauiAppEventos.Models
{
    internal class Evento
    {
        public required string NomeEvento { get; set; }
        public required string LocalEvento { get; set; }
        public required int Participantes { get; set; }
        public required DateTime DataInicio { get; set; }
        public required DateTime DataFim { get; set; }
        public required double ValorParticipante { get; set; }
        public TimeSpan Duracao
        {
            get
            {
                TimeSpan interval = DataFim - DataInicio;
                return interval;
            }
        }
        public double ValorEvento
        {
            get
            {
                double total = ValorParticipante * Participantes;
                return total;
            }
        }
    }
}
