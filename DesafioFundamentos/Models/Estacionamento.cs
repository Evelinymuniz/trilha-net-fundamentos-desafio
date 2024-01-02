namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine("Digite a placa do veículo para estacionar: \n");
            string placa = "";
            placa = Console.ReadLine().Trim().ToUpperInvariant();
            // Verifica se a placa já foi adicionada anteriormente
            if (veiculos.Contains(placa))
            {
                Console.WriteLine($"Esta placa {placa} já foi adicionada anteriormente. Por favor, insira uma placa diferente.\n");
            }
            else
            {
                // Verifica se a entrada da placa é válida (não vazia)
                if (!string.IsNullOrEmpty(placa))
                {
                    // Adiciona a placa à lista de veículos
                    veiculos.Add(placa);

                    // Confirmação para o usuário
                    Console.WriteLine($"Veículo com a placa {placa} adicionado com sucesso!\n");
                }
                else
                {
                    // Mensagem de erro se a placa for vazia
                    Console.WriteLine("Placa inválida. Certifique-se de inserir uma placa válida.\n");
                }
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = "";
            placa = Console.ReadLine().Trim().ToUpperInvariant();
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal;
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                if (int.TryParse(Console.ReadLine(), out horas) && horas >= 0)
                {
                    valorTotal =  precoInicial + (precoPorHora * horas);

                    // TODO: Remover a placa digitada da lista de veículos
                    // *IMPLEMENTE AQUI*
                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Quantidade de horas inválida. Certifique-se de inserir um valor numérico válido.");
                }


            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                int cont = 1;
                foreach (var item in veiculos)
                {
                    Console.WriteLine($"{cont} - {item}");
                    cont++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
