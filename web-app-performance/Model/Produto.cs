namespace web_app_performance.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade_Estoque { get; set; }
        public DateTime Data_Criacao { get; set; }
    }
}
