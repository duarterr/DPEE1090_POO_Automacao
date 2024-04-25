using System.Text;
using System.Globalization;

namespace Course
{
    // Classe Invoice
    internal class Invoice
    {
        // Atributos da classe. Props autoimplementadas para itens que não necessitam de validação
        public uint Cod { get; set; }
        public string Desc { get; set; }

        // Atributos privados que necessitam de validação.
        // Propriedades Qtd e Price se encarregam disso
        private int _qtd = 0;
        private double _price = 0;

        // Prop para quantidadade
        public int Qtd
        {
            // Getter
            get
            {
                return _qtd;
            }

            // Setter com validação
            set
            {
                if (value >= 0)
                    _qtd = value;
                else
                    _qtd = 0;
            }
        }

        // Prop para preço
        public double Price
        {
            // Getter
            get
            {
                return _price;
            }

            // Setter com validação
            set
            {
                if (value >= 0)
                    _price = value;
                else
                    _price = 0;
            }
        }

        // Construtor com argumentos
        public Invoice(uint cod, string desc, int qtd, double price)
        {
            Cod = cod;
            Desc = desc;
            Qtd = qtd;      // Aqui usamos a prop e não _qtd para que tenhamos validação
            Price = price;  // Aqui usamos a prop e não _price para que tenhamos validação
        }

        // Método que retorna o valor da fatura
        public double GetInvoiceAmount ()
        {
            return Price * Qtd;
        }

        // Método para imprimir todos os dados
        public override string ToString()
        {
            // Exemplo feito com string builder. Poderia ter sido feito com concatenação ou interpolação
            StringBuilder sb = new StringBuilder();

            sb.Append("Cod: ");
            sb.Append(Cod.ToString());
            sb.Append(", Desc: ");
            sb.Append(Desc.ToString());
            sb.Append(", Qtd: ");
            sb.Append(Qtd.ToString());
            sb.Append(", Price: ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", Total: ");
            sb.Append(GetInvoiceAmount().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
