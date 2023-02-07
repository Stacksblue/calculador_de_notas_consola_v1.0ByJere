
string nombreMateria1;
string nombreMateria2;
string nombreMateria3;
string nombreMateria4;
string nombreMateria5;

double notaPrimerLabMateria1;
double notaPrimerParcialMateria1;

double notaSegundoLabMateria1;
double notaSegundoParcialMateria1;

double notaTercerLabMateria1;
double notaTercerParcialMateria1;
////////////////////////////////////
double notaPrimerLabMateria2;
double notaPrimerParcialMateria2;

double notaSegundoLabMateria2;
double notaSegundoParcialMateria2;

double notaTercerLabMateria2;
double notaTercerParcialMateria2;
////////////////////////////////////
double notaPrimerLabMateria3;
double notaPrimerParcialMateria3;

double notaSegundoLabMateria3;
double notaSegundoParcialMateria3;

double notaTercerLabMateria3;
double notaTercerParcialMateria3;
////////////////////////////////////
double notaPrimerLabMateria4;
double notaPrimerParcialMateria4;

double notaSegundoLabMateria4;
double notaSegundoParcialMateria4;

double notaTercerLabMateria4;
double notaTercerParcialMateria4;
////////////////////////////////////
double notaPrimerLabMateria5;
double notaPrimerParcialMateria5;

double notaSegundoLabMateria5;
double notaSegundoParcialMateria5;

double notaTercerLabMateria5;
double notaTercerParcialMateria5;
////////////////////////////////////

double totalNota1_1;
double totalNota1_2;
double totalNota1_3;
double totalNota1_4;
double totalNota1_5;

double totalNota2_1;
double totalNota2_2;
double totalNota2_3;
double totalNota2_4;
double totalNota2_5;

double totalNota3_1;
double totalNota3_2;
double totalNota3_3;
double totalNota3_4;
double totalNota3_5;

double totalNota4_1;
double totalNota4_2;
double totalNota4_3;
double totalNota4_4;
double totalNota4_5;

double totalNota5_1;
double totalNota5_2;
double totalNota5_3;
double totalNota5_4;
double totalNota5_5;

double totalPromedioMateria1;
double totalPromedioMateria2;
double totalPromedioMateria3;
double totalPromedioMateria4;
double totalPromedioMateria5;
////////////////////////////////////

Console.WriteLine("Calculador de notas by Jeremy");

string resp;
do
{


Console.Write("Ingrese el nombre de materia 1: ");
nombreMateria1 = Console.ReadLine();

Console.Write($"Ingrese la nota de laboratorio 1: ");
notaPrimerLabMateria1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Ingrese la nota de parcial 1    : ");
notaPrimerParcialMateria1 = Convert.ToDouble(Console.ReadLine());

totalNota1_1 = ((((notaPrimerLabMateria1 * 0.4) + (notaPrimerParcialMateria1 * 0.6)) * 0.3));


Console.Write($"Ingrese la nota de laboratorio 2: ");
notaSegundoLabMateria1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Ingrese la nota de parcial 2    : ");
notaSegundoParcialMateria1 = Convert.ToDouble(Console.ReadLine());

totalNota1_2 = ((((notaSegundoLabMateria1 * 0.4) + (notaSegundoParcialMateria1 * 0.6)) * 0.3));


Console.Write($"Ingrese la nota de laboratorio 3: ");
notaTercerLabMateria1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Ingrese la nota de parcial 3    : ");
notaTercerParcialMateria1 = Convert.ToDouble(Console.ReadLine());

totalNota1_3 = ((((notaTercerLabMateria1 * 0.4) + (notaTercerParcialMateria1 * 0.6)) * 0.4));

totalPromedioMateria1 = totalNota1_1 + totalNota1_2 + totalNota1_3;
////////////////////////////////////
Console.WriteLine("Guardando datos, por favor espere...");
Console.WriteLine("...");
Console.WriteLine("...Guardado!");
////////////////////////////////////

Console.WriteLine("----------------------");
Console.WriteLine($"|Nombre de la materia: {nombreMateria1}");
Console.WriteLine($"|Nota de lab 1       : {notaPrimerLabMateria1}");
Console.WriteLine($"|Nota de par 1       : {notaPrimerParcialMateria1}");
Console.WriteLine($"|Nota total  1       : {totalNota1_1}");
Console.WriteLine("----------------------");
Console.WriteLine($"|Nota de lab 2       : {notaSegundoLabMateria1}");
Console.WriteLine($"|Nota de par 2       : {notaSegundoLabMateria1}");
Console.WriteLine($"|Nota total  2       : {totalNota1_2}");
Console.WriteLine("----------------------");
Console.WriteLine($"|Nota de lab 3       : {notaTercerLabMateria1}");
Console.WriteLine($"|Nota de par 3       : {notaTercerParcialMateria1}");
Console.WriteLine($"|Nota total  3       : {totalNota1_3}");
Console.WriteLine("----------------------");
Console.WriteLine($"promedio total       : {totalPromedioMateria1}");
Console.WriteLine("----------------------\n");

Console.WriteLine("¿Desea calcular una materia?[si/no]");
resp = Console.ReadLine();
} while (resp == "si");
Console.WriteLine("Que tenga buen día!");