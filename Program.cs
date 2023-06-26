decimal faltam; int VLSaque=0 ;
int notas200, notas100, notas50, notas20, notas10, notas5, notas2, notas1;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(" === bradesco === ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Colocando você sempre à frente. \n ");
Console.ResetColor();

Console.WriteLine("Escolha uma opção: ");

Console.WriteLine("B - Biometria ");
 Console.WriteLine("S - Senha ");

char letraBanco = Console.ReadKey().KeyChar;
Console.WriteLine();
string senhaEscolhida;
switch (Char.ToUpper(letraBanco))

{
    case 'B':
    senhaEscolhida = "Biometria";
    Console.WriteLine($"Você escolheu a opção: {senhaEscolhida}.");
    Console.WriteLine("Ensira a biometria... ");
    Console.ReadKey();    
    Console.WriteLine("Verificando a biometria...");
    Thread.Sleep(4500);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Acesso permetido");
    Console.ResetColor();
    Console.WriteLine("\nO máximo de dinheiro possivel de sacar 3000 Reais\n ");
               

void voltar()
{
    Console.Write("Digite o valor a ser sacado..: ");
    string answer = Console.ReadLine()!;
    bool Correto = int.TryParse(answer, out VLSaque);

if (! Correto || int.Parse(answer) <= 10 )
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    CW("\nPor favor, insira apenas números e que sejam maiores que 10 R$.\n");
    Console.ResetColor();
    voltar();

 }else VLSaque = int.Parse(answer);

if ( VLSaque % 1 > 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    CW("\n Este caixa não trabalha com moedas.\n");
    Console.ResetColor();
    voltar();
}

if ( VLSaque > 3000)
    {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("\nPara saques acima de R$ 3 mil, é necessário avisar a agência com antecedência de um dia útil.\n ");
    Console.ResetColor();
voltar();
 }
}
voltar();

faltam = VLSaque;

notas200 = (int)(faltam / 200);
faltam = faltam % 200;

notas100 = (int)(faltam / 100);
faltam = faltam % 100;

notas50 = (int)(faltam / 50);
faltam = faltam % 50;

notas20 = (int)(faltam /20);
faltam = faltam % 20;

notas10 = (int)(faltam / 10);
faltam = faltam % 10;

notas5 = (int)(faltam / 5);
faltam = faltam % 5;

notas2 = (int)(faltam / 2);
faltam = faltam % 2;

notas1 = (int)(faltam / 1);
faltam = faltam % 1;

CW($"\nO caixa deve realizar a entrega das seguintes notas..:\n ");

Console.ForegroundColor = ConsoleColor.Red;
CW("+=========================+");
 Console.ResetColor();

if (notas200 > 0) {B(""); Console.Write($" {notas200.ToString().PadLeft(2,' ')} nota(s) de R$200,00  "); B("l"); }
if (notas100 > 0) {B("");  Console.Write($" {notas100.ToString().PadLeft(2,' ')} nota(s) de R$100,00  "); B("l"); }
if (notas50 > 0) {B("");  Console.Write($" {notas50.ToString().PadLeft(2,' ')} nota(s) de R$50,00   "); B("l"); }
if (notas20 > 0) {B("");  Console.Write($" {notas20.ToString().PadLeft(2,' ')} nota(s) de R$20,00   "); B("l");}
if (notas10 > 0) {B("");  Console.Write($" {notas10.ToString().PadLeft(2,' ')} nota(s) de R$10,00   "); B("l");} 
if (notas5 > 0) {B("");  Console.Write($" {notas5.ToString().PadLeft(2,' ')} nota(s) de R$5,00    "); B("l");} 
if (notas2 > 0) {B("");  Console.Write($" {notas2.ToString().PadLeft(2,' ')} nota(s) de R$2,00    "); B("l");}
if (notas1 > 0) {B("");  Console.Write($" {notas1.ToString().PadLeft(2,' ')} nota(s) de R$1,00    "); B("l");}
Console.ForegroundColor = ConsoleColor.Red;
CW("+=========================+");
Console.ResetColor();

Console.Write("\nObrigado por utilizar os serviços do Banco "); 
Console.ForegroundColor = ConsoleColor.Red;
CW  ("Bradesco");
Console.ResetColor();

//Criação de uma sub rotina onde CW = Console.Writeline
void CW (string CW)
{
    Console.WriteLine(CW);

};
//Criação de uma sub rotina onde B = Console.Writeline("|") red
void B (string type)
{
    Console.ForegroundColor = ConsoleColor.Red;
    if (type == "l")
    {
    Console.WriteLine("|");
    }
    else
    {
    Console.Write("|");
    }
    Console.ResetColor();
}
 break;


 case 'S':

    senhaEscolhida = "Senha";
    CWW($"Você escolheu a opção: {senhaEscolhida}.");
    Console.Write("Digite a senha...........: ");
    string senha = Console.ReadLine()!;
    Thread.Sleep(2500);
    
    Console.WriteLine("Verificando a senha...");
    Thread.Sleep(3000);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nAcesso permetido");
    Console.ResetColor();
    
    CWW("\nO máximo de dinheiro possivel de sacar 300 Reais\n ");
               

 void voltar2 ()
    {
    Console.Write("Digite o valor a ser sacado..: ");
    string answer = Console.ReadLine()!;
    bool Correto = int.TryParse(answer, out VLSaque);

if (! Correto || int.Parse(answer) <= 10 )
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    CWW("\nPor favor, insira apenas números e que sejam maiores que 10 R$.\n");
    Console.ResetColor();
    voltar2();
}else VLSaque = int.Parse(answer);

if ( VLSaque % 1 > 0)
{
Console.ForegroundColor = ConsoleColor.DarkRed;
CWW("\n Este caixa não trabalha com moedas.\n");
Console.ResetColor();
voltar2();
}

if ( VLSaque > 300)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("\nPara saques acima de R$ 300 R$, saque por biomêtria.\n ");
    Console.ResetColor();
    voltar2();
    }
}
voltar2();

faltam = VLSaque;

notas200 = (int)(faltam / 200);
faltam = faltam % 200;

notas100 = (int)(faltam / 100);
faltam = faltam % 100;

notas50 = (int)(faltam / 50);
faltam = faltam % 50;

notas20 = (int)(faltam /20);
faltam = faltam % 20;

notas10 = (int)(faltam / 10);
faltam = faltam % 10;

notas5 = (int)(faltam / 5);
faltam = faltam % 5;

notas2 = (int)(faltam / 2);
faltam = faltam % 2;

notas1 = (int)(faltam / 1);
faltam = faltam % 1;

    CW($"\nO caixa deve realizar a entrega das seguintes notas..:\n ");

Console.ForegroundColor = ConsoleColor.Red;
CW("+=========================+");
Console.ResetColor();

if (notas200 > 0) {BW(""); Console.Write($" {notas200.ToString().PadLeft(2,' ')} nota(s) de R$200,00  "); BW("l"); }
if (notas100 > 0) {BW("");  Console.Write($" {notas100.ToString().PadLeft(2,' ')} nota(s) de R$100,00  "); BW("l"); }
if (notas50 > 0) {BW("");  Console.Write($" {notas50.ToString().PadLeft(2,' ')} nota(s) de R$50,00   "); BW("l"); }
if (notas20 > 0) {BW("");  Console.Write($" {notas20.ToString().PadLeft(2,' ')} nota(s) de R$20,00   "); BW("l");}
if (notas10 > 0) {BW("");  Console.Write($" {notas10.ToString().PadLeft(2,' ')} nota(s) de R$10,00   "); BW("l");} 
if (notas5 > 0) {BW("");  Console.Write($" {notas5.ToString().PadLeft(2,' ')} nota(s) de R$5,00    "); BW("l");} 
if (notas2 > 0) {BW("");  Console.Write($" {notas2.ToString().PadLeft(2,' ')} nota(s) de R$2,00    "); BW("l");}
if (notas1 > 0) {BW("");  Console.Write($" {notas1.ToString().PadLeft(2,' ')} nota(s) de R$1,00    "); BW("l");}
Console.ForegroundColor = ConsoleColor.Red;
CW("+=========================+");
Console.ResetColor();


Console.Write("\nObrigado por utilizar os serviços do Banco "); 
Console.ForegroundColor = ConsoleColor.Red;
CWW("Bradesco"); 
Console.ResetColor();

//Criação de uma sub rotina onde CW = Console.Writeline
void CWW (string CWW)
{
    Console.WriteLine(CWW);

}
//Criação de uma sub rotina onde B = Console.Writeline("|") red
void BW (string type)
{
    Console.ForegroundColor = ConsoleColor.Red;
if (type == "l")
{
    Console.WriteLine("|");
}
else
{
    Console.Write("|");
}
    Console.ResetColor();
}

break;
default:
senhaEscolhida = "Opção inválida";
break;
}
Console.ResetColor();

  