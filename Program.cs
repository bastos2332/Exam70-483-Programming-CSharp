using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70_483
{
    class Program
    {
        static IList<MenuItem> menuItems;
        static void Main(string[] args)
        {
            menuItems = GetMenuItems();
            while (true)
            {
                ImprimirMenuItems(menuItems);
                var opcao = Console.ReadLine();
                Executar(opcao);
                Console.ReadKey();
            }
        }

        private static void Executar(string valorOpcao)
        {
            int opcao = Convert.ToInt32(valorOpcao);

            IAulaItem aulaSelecionada;
            MenuItem menuItem = menuItems[opcao - 1];
            Type tipoClasse = menuItem.TipoClasse;
            aulaSelecionada = (IAulaItem)Activator.CreateInstance(tipoClasse);

            Console.WriteLine();
            string titulo = $"EXECUTANDO: {menuItem.Titulo}";
            Console.WriteLine(titulo);
            Console.WriteLine(new string('=', titulo.Length));

            new Controlador().ExecutarAula(aulaSelecionada);
            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
        }

        private static void ImprimirMenuItems(IList<MenuItem> menuItems)
        {
            int i = 1;
            Console.WriteLine("SELECIONE UMA OPÇÃO");
            Console.WriteLine("===================");
            Console.WriteLine("0 - Sair");
            foreach (var menuItem in menuItems)
            {
                Console.WriteLine((i++).ToString() + " - " + menuItem.Titulo);
            }
        }

        private static IList<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem("Tipos de Valor", typeof(TiposDeValor)),
                new MenuItem("Tipos Inteiros", typeof(TiposInteiros)),
                new MenuItem("Ponto Flututante", typeof(PontoFlutuante)),
                new MenuItem("Decimal", typeof(Decimal)),
                new MenuItem("Booleanos", typeof(Booleanos)),
                new MenuItem("Estruturas", typeof(Estruturas)),
                new MenuItem("Enumeracoes", typeof(Enumeracoes)),
                new MenuItem("Tipos de Refêrencia", typeof(TiposDeReferencia)),
                new MenuItem("Classes", typeof(Classes)),
                new MenuItem("Interfaces", typeof(Interfaces)),
                new MenuItem("Delegates", typeof(Delegates)),
                new MenuItem("Objetos", typeof(Objetos)),
                new MenuItem("Dinâmicos", typeof(Dinamicos)),
                new MenuItem("Strings", typeof(Strings)),
                //new MenuItem("Metodos", typeof(Metodos)),
                //new MenuItem("Parâmetros Nomeados", typeof(ParametrosNomeados)),
                //new MenuItem("Parâmetros Opcionais", typeof(ParametrosOpcionais)),
                //new MenuItem("Métodos de Extensão", typeof(MetodosDeExtensao)),
                //new MenuItem("Propriedades Indexadas", typeof(PropriedadesIndexadas)),
                //new MenuItem("Sobrecargas", typeof(Sobrecargas)),
                //new MenuItem("Métodos Substituidos", typeof(MetodosSubstituidos)),
                //new MenuItem("Boxing", typeof(Boxing)),
                //new MenuItem("Unboxing", typeof(Unboxing)),
                //new MenuItem("Conversoes Implícitas", typeof(ConversoesImplicitas)),
                //new MenuItem("Conversoes Explícitas", typeof(ConversoesExplicitas)),
                //new MenuItem("Operadores IS e AS", typeof(OperadoresISeAS)),
                //new MenuItem("Operadores de Conversão", typeof(OperadoresDeConversao)),
                //new MenuItem("Métodos Auxiliares de Conversão", typeof(MetodosAuxiliares)),
                //new MenuItem("Usando Dynamic", typeof(UsandoDynamic)),
                //new MenuItem("Conversões de Dynamic", typeof(ConversoesDeDynamic)),
                //new MenuItem("Resolucão de Sobrecarga", typeof(ResolucaoSobrecarga)),
                //new MenuItem("Usando ExpandObject", typeof(UsandoExpandObject)),
                //new MenuItem("Interoperabilidade COM", typeof(InteropCOM))                
            };
        }
    }

    class MenuItem
    {
        public MenuItem(string titulo, Type tipoClasse)
        {
            Titulo = titulo;
            TipoClasse = tipoClasse;
        }

        public string Titulo { get; set; }
        public Type TipoClasse { get; set; }
    }
}
