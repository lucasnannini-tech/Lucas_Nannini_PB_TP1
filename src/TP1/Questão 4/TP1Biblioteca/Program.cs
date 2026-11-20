using System;

int limiteEmprestimos = 3;
int emprestimosAtivosMembro = 2;
int exemplaresDisponiveisLivroX = 0;
bool executando = true;

Console.WriteLine("=== GESTÃO DE BIBLIOTECA ===");

while (executando)
{
    Console.WriteLine("\n1. Simular Empréstimo");
    Console.WriteLine("2. Simular Reserva");
    Console.WriteLine("0. Sair");
    Console.Write("Escolha: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            if (emprestimosAtivosMembro < limiteEmprestimos)
            {
                emprestimosAtivosMembro++;
                Console.WriteLine($"Empréstimo liberado! Você agora tem {emprestimosAtivosMembro} livros.");
            }
            else
            {
                Console.WriteLine("Bloqueado: Limite máximo de 3 empréstimos atingido.");
            }
            break;

        case "2":
            if (exemplaresDisponiveisLivroX == 0)
            {
                Console.WriteLine("Reserva efetuada com sucesso. Todos os exemplares estão ocupados.");
            }
            else
            {
                Console.WriteLine("Não é possível reservar. Há exemplares disponíveis na prateleira.");
            }
            break;

        case "0":
            executando = false;
            Console.WriteLine("Encerrando...");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
