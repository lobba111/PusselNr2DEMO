// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Text.RegularExpressions;


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
/// <summary>
/// här konverterar jag listan med kommandon
/// </summary>
string[] dataCommandon = filterdDataCommandos.ToArray();
/// <summary>
/// här konverterar jag listan med värden
/// </summary>
int[] dataValues = filterdDataFromInputValues.ToArray();


int horizontal = 0; // är det kommando forward ska denna variabel pussas på med värdet som forward håller
int depth = 0; // är kommandot down ska värdet utav down plussa på depth, är kommandot up så ska jag ta minus utav värdet up på mitt djup
// dags att börja testa lite med sample datan som finns tillgänglig innan jag ger mig på hela data mängden 


for (int i = 0; i < dataCommandon.Length; i++)
{
    

        if (dataCommandon[i].Contains("forward"))
        {
            horizontal += dataValues[i];
        
        }
        else if (dataCommandon[i].Contains("down"))
        {
            depth += dataValues[i];

        }
        else if (dataCommandon[i].Contains("up"))
        {
            depth -= dataValues[i];
        
        }
    
    
}

int result = horizontal * depth;
Console.WriteLine("Min horizontela position är {0} min djup position är {1} : resultatet är = {2}",horizontal,depth,result);



int horizontal2 = 0;
int depth2 = 0;
int aim = 0;
string[] sampleCommando = new string[] { "forward", "down", "forward", "up", "down", "forward" };
int[] sampleValues = new int[] { 5, 5, 8, 3, 8, 2 };
for (int i = 0; i < dataCommandon.Length; i++)
{


    if (dataCommandon[i].Contains("forward") && i == 0)
    {
        horizontal2 += dataValues[i];
        
    }
    else if (dataCommandon[i].Contains("forward"))
    {
        horizontal2 += dataValues[i];
        depth2 += dataValues[i] * aim;
        

    }
    else if (dataCommandon[i].Contains("down"))
    {
        
        aim += dataValues[i];

    }
    else if (dataCommandon[i].Contains("up"))
    {
        
        aim -= dataValues[i];

    }


}

int resultat2 = horizontal2 * depth2;
Console.WriteLine("Svaret är : horizontal {0} * depth {1} = {2}",horizontal2,depth2,resultat2);





