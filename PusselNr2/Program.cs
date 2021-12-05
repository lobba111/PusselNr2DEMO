// See https://aka.ms/new-console-template for more information
using PusselNr2;
using System.Collections;
using System.Text.RegularExpressions;

int forward = 0;
int depth = 0;
int up = 0; 
int down = 0;
string[] inputData = System.IO.File.ReadAllLines(@"C:\Users\robin\OneDrive\Skrivbord\inputdata.txt");
List<int> filterdDataFromInputValues = new List<int>(); 
List<string> filterdDataCommandos = new List<string>();


foreach (string input in inputData)
{
    var filterdNumber = Regex.Match(input, @"\d+").Value;
    filterdDataFromInputValues.Add(Int32.Parse(filterdNumber));// okej så här har jag lyckats att filtrea min inputdata och tagit ut mina nummer
    string[] wordCommando = Regex.Split(input, @"\d+");//okej nu har jag lyckats filtrera orden och sparar dom i sen separat lista
    filterdDataCommandos.Add(wordCommando[0]);
}
foreach (var data in filterdDataFromInputValues)
{
    Console.WriteLine(data);
}
foreach (string data in filterdDataCommandos)
{
    Console.WriteLine(data);
}



