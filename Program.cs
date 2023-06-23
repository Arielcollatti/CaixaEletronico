decimal faltam, VLSaque ; 
int notas200, notas100, notas50, notas20, notas10, notas5, notas2, notas1;


 
Console.ForegroundColor = ConsoleColor.Red;
CW("      === bradesco ===     ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGray;
CW("Colocando você sempre à frente. \n ");
Console.ResetColor();
 
Console.Write("Digite o valor a ser sacado..: ");
VLSaque = Convert.ToInt32(Console.ReadLine());

 

if (VLSaque % 1 > 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    CW("\n Este caixa não trabalha com moedas .");
    Console.ResetColor();
    return;
}


if ( VLSaque <= 0 || VLSaque > 3000)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Para saques acima de R$ 3 mil, é necessário avisar a agência com antecedência de um dia útil. \n ");
    Console.ResetColor();
    return;
}

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

CW("\nObrigado por utilizar os serviços do Banco Bradesco");	

//Criação de uma sub rotina onde CW = Console.Writeline 
void CW (string CW) 
{
    Console.WriteLine(CW);

};


//Criação de uma sub rotina onde B = Console.Writeline("|") Azul 
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
};















