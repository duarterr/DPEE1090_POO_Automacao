namespace Course
{
    internal class Carro
    {
        public Lataria Lataria { get; set; }
        public List<Roda> Rodas { get; set; } = new List<Roda>();
        public List<Banco> Bancos { get; set; } = new List<Banco>();
        public Motor Motor { get; set; }

        public Carro(Lataria lataria, Motor motor)
        {
            Lataria = lataria;
            Motor = motor;
        }

        public void AdicionarRoda(Roda roda)
        {
            if (Rodas.Count < 5) // Considerando que um carro pode ter no máximo 5 rodas (incluindo o estepe)
            {
                Rodas.Add(roda);
            }
            else
            {
                Console.WriteLine("Número máximo de rodas atingido.");
            }
        }

        public void AdicionarBanco(Banco banco)
        {
            if (Bancos.Count < 3) // Considerando que um carro pode ter no máximo 3 bancos
            {
                Bancos.Add(banco);
            }
            else
            {
                Console.WriteLine("Número máximo de bancos atingido.");
            }
        }

        public override string ToString()
        {
            string descricao = "Carro:\n";
            descricao += Lataria.ToString() + "\n";
            descricao += Motor.ToString() + "\n";
            descricao += "Rodas:\n";
            foreach (Roda roda in Rodas)
                descricao += "  " + roda.ToString() + "\n";
            descricao += "Bancos:\n";
            foreach (Banco banco in Bancos)
                descricao += "  " + banco.ToString() + "\n";

            return descricao;
        }
    }
}
