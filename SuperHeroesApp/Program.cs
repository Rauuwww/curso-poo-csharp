// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using SuperHeroesApp;
using SuperHeroesApp.Models;

var imprimirInfo = new ImprimirInfo();

var PoderVolar = new SuperPower();
PoderVolar.Name = "Volar";
PoderVolar.Descripcion = "Capacidad para volar y planear en el aire";
PoderVolar.Level = LevelPower.LevelThree;

var SuperFuerza = new SuperPower();
SuperFuerza.Name = "Super Fuerza";
SuperFuerza.Level = LevelPower.LevelOne;

var regeneracion = new SuperPower();
regeneracion.Name = "Regeneración";
regeneracion.Level = LevelPower.LevelOne;

//----------------------------------------------------------------------------
var superman = new SuperHeroe();
superman.Id = 1;
superman.Name = "Superman";
superman.SecretIdentify = "Clark Kent";
superman.City = "Metropolis";
superman.PuedeVolar = true;
imprimirInfo.ImprimirSuperHeroe(superman);    
List<SuperPower> powersSuperman = new List<SuperPower>();
powersSuperman.Add(SuperFuerza);
powersSuperman.Add(PoderVolar);
superman.SuperPowers = powersSuperman;
string resultSuperPowers = superman.UseSuperPower();
Console.WriteLine(resultSuperPowers);
string resultSalvarMundo = superman.SalvarElMundo(); 
Console.WriteLine(resultSalvarMundo);
string resultSalvarPersonas = superman.SalvarPersonas();
Console.WriteLine($"{resultSalvarPersonas} \n");
 //---------------------------------------------------------------------------
var Deadpool = new AntiHeroe();
Deadpool.Id = 2;
Deadpool.Name = "Deadpool";
Deadpool.SecretIdentify = "Wade Winston Wilson";
Deadpool.City = "Nueva York";
Deadpool.PuedeVolar = false;
imprimirInfo.ImprimirSuperHeroe(Deadpool);
List<SuperPower> powersWolverine = new List<SuperPower>();
powersWolverine.Add(SuperFuerza);
powersWolverine.Add(regeneracion);
Deadpool.SuperPowers = powersWolverine;
string resultPowersDeadpool = Deadpool.UseSuperPower();
Console.WriteLine(resultPowersDeadpool);
string accionAntiheroe = Deadpool.RealizarAccionDeAntiheroe("ataques a la policia y personas!");
Console.WriteLine(accionAntiheroe);
//------------------------------------------------------------------------------

enum LevelPower
{
    LevelOne,
    LevelTwo,
    LevelThree,
}

public record SuperHeroRecord(int Id, string Name, string SecretIdentify);