
using Heroe;

SuperHeroe superHeroe = new SuperHeroe();
superHeroe.Nombre = "Super Man";
superHeroe.IdentidadSecreta = "Clark Kent";
superHeroe.Ciudad = "Metropolis";
superHeroe.PuedeVolar = true;
superHeroe.super.Nombre = "Fuerza, volar";
superHeroe.super.Descripcion = "Alien";
superHeroe.super.Nivel = 9;
superHeroe.Imprimir();

SuperHeroe superHeroe1 = new SuperHeroe();
superHeroe1.Nombre = "Batman";
superHeroe1.IdentidadSecreta = "Brus Wei";
superHeroe1.Ciudad = "Gotham";
superHeroe1.PuedeVolar = false;
superHeroe1.super.Nombre = "No posee";
superHeroe1.super.Descripcion = "La tecnologia hace que combata el grimen";
superHeroe1.super.Nivel = 10;
superHeroe1.Imprimir();

SuperHeroe superHeroe2 = new SuperHeroe();
superHeroe2.Nombre = "Flash";
superHeroe2.IdentidadSecreta = "Barry";
superHeroe2.Ciudad = "Central";
superHeroe2.PuedeVolar= false;
superHeroe2.super.Nombre = "Velocidad";
superHeroe2.super.Descripcion = "Su poder viene de un rayo que lo toco";
superHeroe2.super.Nivel = 7;
superHeroe2.Imprimir();



