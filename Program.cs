using Propriedades__Métodos_e_Construtores.Model;
using System.Globalization; //Importando o uso de localização da regiao que quer trabalhar


//Declarando o Tipo Date para receber a data e hora atual
//Tipo DateTime tambem aceita o Parse para conversão

string dataString = "25-01-2007 15:25";

//Validando a conversão do DateTime usando o TryParseExact e validando na condicional para tratamento de erro.
bool Sucess = DateTime.TryParseExact(dataString,"dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture,DateTimeStyles.None,out DateTime data);

if (Sucess){
    Console.WriteLine($"Conversão realizada com Sucesso: {data}");
}else{
    Console.WriteLine($"{dataString} não é uma data válida!");
}

Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));//Dessa forma eu to formatando para mostrar exatamente do jeito que quero esse retorno.

// Console.WriteLine(data.ToShortDateString());//Para receber apenas a data

// Console.WriteLine(data.ToShortTimeString());//Para receber apenas a hora

























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");//Informando qual a região que será usada para poder usar a moeda local. Isso vai ser aplicado a TODO O SISTEMA.

// //Quando quiser representar valores de moedas, adicione o " M "para trabalar com o tipo decimal que é o adequado para manipular vamores monetarios
// decimal valorMonetario = 94.70M;

// //Voce deve usar a interpolaçao e informar ao final da variável qual a moeda esta trabalhando. Nesse caso o Real brasileiro seria representado pelo " C "
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("es-US")));//Aqui estou especificando uma cultura específica, mesmo a cultura global do codigo sendo outra.































// //Essas variáveis são do tipo String 
// string numero1 = "10";
// string numero2 = "20";

// //Aqui é feito uma concatenação e não uma operação de soma.
// string resultado = numero1 + numero2;

// //Veja o resultado 
// Console.WriteLine(resultado);


// //Aqui temos 2 tipos diferentes
// string numero3 = "10";
// int numero4 = 20;

// //Mas o resultado será o mesmo que o anterior
// //Isso por que na operação a String tem prioridade e por isso irá retornar uma String como resultado
// //Logo não será feio uma soma,mas sim uma concatenação novamente.
// string resultado2 = numero3 + numero4;

// Console.WriteLine(resultado2);





















// Pessoa p1 = new Pessoa(Nome:"Leandresson",Sobrenome:"Fulco");


// Pessoa p2 = new Pessoa(Nome:"Cleiton",Sobrenome:"Moreira");


// Curso logicaEalgoritmo = new Curso();

// logicaEalgoritmo.Nome = "Logica e Algoritmo em C";
// logicaEalgoritmo.Alunos = new List<Pessoa>();


// Console.WriteLine($"Alunos do curso de: {logicaEalgoritmo.Nome}");
// logicaEalgoritmo.AdicionarAluno(p2);
// logicaEalgoritmo.AdicionarAluno(p1);


// logicaEalgoritmo.ListarAlunos();

