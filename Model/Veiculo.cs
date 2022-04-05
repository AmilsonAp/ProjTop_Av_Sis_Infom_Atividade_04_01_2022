namespace Model
{
    public abstract class Veiculo
    {
        public string Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }       
        public int AnoModelo { get; set; } 
        public int AnoMarca { get; set; }
        public string Cor { get; set; }
    };
}