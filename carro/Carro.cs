namespace carro
{
    public class Carro
    {
        public String cor { get; set; }
        public String modelo { get; set; }
        public double velocidadeAtual { get; private set; } 
        
        public double velocidadeMaxima { get; set; }

        public Carro() // Construtor para inicializar valores
        {
            this.velocidadeAtual = 0;
            this.cor = "Não definida";
            this.modelo = "Não definido";
        }

        public void liga()
        {
            System.Console.WriteLine("Carro ligado");
        }

        public void acelera(double velocidadeAdicionada) 
        {
            System.Console.WriteLine("Acelerando...");
            
            double novaVelocidade = this.velocidadeAtual + velocidadeAdicionada;

            if (novaVelocidade >= this.velocidadeMaxima)
            {
                this.velocidadeAtual = this.velocidadeMaxima;
                System.Console.WriteLine($"Velocidade máxima de {this.velocidadeMaxima} km/h atingida!");
            }
            else if (novaVelocidade < 0)
            {
                this.velocidadeAtual = 0;
                System.Console.WriteLine("O carro parou.");
            }
            else
            {
                this.velocidadeAtual = novaVelocidade;
            }

            System.Console.WriteLine($"Velocidade atual: {this.velocidadeAtual} km/h");
        }

        public int passarMarcha()
        {
            double velocidade = this.velocidadeAtual;

            if (velocidade >= 0 && velocidade <= 20)
            {
                System.Console.WriteLine("Marcha 1");
                return 1;
            }
            else if (velocidade > 20 && velocidade <= 40)
            {
                System.Console.WriteLine("Marcha 2");
                return 2;
            }
            else if (velocidade > 40 && velocidade <= 60)
            {
                System.Console.WriteLine("Marcha 3");
                return 3;
            }
            else if (velocidade > 60 && velocidade <= 80)
            {
                System.Console.WriteLine("Marcha 4");
                return 4;
            }
            else
            {
                System.Console.WriteLine("Marcha 5");
                return 5;
            }
        }
    }
}