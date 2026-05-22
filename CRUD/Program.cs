using CRUD.BancoDeDados;
using CRUD.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem Vindo ao CRUD\n");

        Thread.Sleep(1000);
        while(true){
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Ver Produtos");
            Console.WriteLine("3. Atualizar Produto");
            Console.WriteLine("4. Deletar Produto");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma opção: ");
            int escolha = int.Parse(Console.ReadLine());

            #region Cadastrar Produtos
            if (escolha == 1) // Cadastrar Produtos
            {
                var produtos = new Produtos();

                Console.WriteLine("Escolha um nome para seu produto: ");
                produtos.Nome = Console.ReadLine();

                Console.WriteLine("\nEscolha um preço: ");
                produtos.Preco = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEscolha o estoque: ");
                produtos.Estoque = int.Parse(Console.ReadLine());

                var db = new ProdutoBanco();
                db.Create(produtos);

                Console.WriteLine("Deseja volta ao menu digite 1 ");
                Console.WriteLine("Deseja sair digite -1 ");

                int voltaEscolha = int.Parse(Console.ReadLine());
                if (voltaEscolha == 1)
                {
                    continue;
                }
                else if (voltaEscolha == -1)
                {
                    break;
                }
            }
            #endregion

            #region Ver Produtos
            else if (escolha == 2) // Ver Produtos
            {

                var db = new ProdutoBanco();
                var produtos = db.Read();

                foreach (var produto in produtos)
                {
                    Console.WriteLine($"ID: {produto.Id}");
                    Console.WriteLine($"Nome: {produto.Nome}");
                    Console.WriteLine($"Preço: R$ {produto.Preco}");
                    Console.WriteLine($"Estoque: {produto.Estoque}");
                }
               
                Console.WriteLine("Deseja volta ao menu digite 1 ");
                Console.WriteLine("Deseja sair digite -1 ");

                int voltaEscolha = int.Parse(Console.ReadLine());
                if (voltaEscolha == 1)
                {
                    continue;
                }
                else if (voltaEscolha == -1)
                {
                    break;
                }
            }
            #endregion

            #region Atualizar Produtos
            else if (escolha == 3) // Atualizar Produtos
            {

                var db = new ProdutoBanco();
                var produtos = db.Read();

                Console.WriteLine("Produtos cadastrados");
                Console.WriteLine($"1. Nome: {nome}, Preço: {preco}, Estoque: {estoque}");

                Console.WriteLine("Escolha um produto para atualizar: ");
                int atualizarEscolha = int.Parse(Console.ReadLine());

               if (atualizarEscolha == 1)
                {
                    Console.WriteLine($"1. Nome");
                    Console.WriteLine($"2. Preço");
                    Console.WriteLine($"3. Estoque");
                    Console.WriteLine("Escolha qual elemento quer atualizar: ");
                    int atualizarElemento = int.Parse(Console.ReadLine());
                    if(atualizarElemento == 1)
                    {
                        Console.WriteLine("Qual o novo nome para o produto?");
                        nome = Console.ReadLine();
                        Thread.Sleep(1000);
                        Console.WriteLine("Nome Alterado com sucesso!");
                        continue;
                    }
                    if(atualizarElemento == 2)
                    {
                        Console.WriteLine("Qual o novo preço para o produto?");
                        preco = double.Parse(Console.ReadLine());
                        Thread.Sleep(1000);
                        Console.WriteLine("Preço Alterado com sucesso!");
                        continue;
                    }
                    if(atualizarElemento == 3)
                    {
                        Console.WriteLine("Qual o novo estoque para o produto?");
                        estoque = int.Parse(Console.ReadLine());
                        Thread.Sleep(1000);
                        Console.WriteLine("Estoque Alterado com sucesso!");
                        continue;
                    }
                }

                Console.WriteLine("Deseja volta ao menu digite 1 ");
                Console.WriteLine("Deseja sair digite -1 ");

                int voltaEscolha = int.Parse(Console.ReadLine());
                if (voltaEscolha == 1)
                {
                    continue;
                }
                else if (voltaEscolha == -1)
                {
                    break;
                }
            }
            #endregion

            #region Deletar Produtos
            else if (escolha == 4) // Deletar Produtos
            {
                Console.WriteLine("Escolha um produto para excluir"); 
                Console.WriteLine($"1. Nome: {nome}, Preço: {preco}, Estoque: {estoque}");
                
                int escolhaDeletar = int.Parse(Console.ReadLine());
                if(escolhaDeletar == 1)
                {
                    nome = String.Empty;
                    preco = 0;
                    estoque = 0;

                    Console.WriteLine("Produto Deletado com Sucesso");
                    continue;
                }
            }
            #endregion

            #region Sair
            else if (escolha == 5) // Sair do programa
            {
                break;
            }
            #endregion
        }
    }
}