// See https://aka.ms/new-console-template for more information

using Model;

#region Tratores
Trator t1 = new Trator()
{
    Id = "1",
    Marca = "John Deere",
    Modelo = "T0001",
    AnoModelo = 2021,
    AnoMarca =  2021,
    Cor = "Verde"
};

Trator t2 = new Trator()
{
    Id = "2",
    Marca = "New Holland",
    Modelo = "T0002",
    AnoModelo = 2010,
    AnoMarca = 2009,
    Cor = "Azul"
};

Trator t3 = new Trator()
{
    Id = "1",
    Marca = "Valtra",
    Modelo = "T0001",
    AnoModelo = 2017,
    AnoMarca = 2016,
    Cor = "Vermelho"
};

#endregion

#region Motocicletas
Motocicleta m1 = new Motocicleta()
{
    Id = "1",
    Marca = "Honda",
    Modelo = "CBR 1000",
    AnoModelo = 2021,
    AnoMarca = 2021,
    Cor = "Vermelha"
};

Motocicleta m2 = new Motocicleta()
{
    Id = "2",
    Marca = "Yamaha",
    Modelo = "MT 09",
    AnoModelo = 2021,
    AnoMarca = 2021,
    Cor = "Azul Escuro"
};

Motocicleta m3 = new Motocicleta()
{
    Id = "3",
    Marca = "Harley Davidson",
    Modelo = "Cruiser",
    AnoModelo = 2000,
    AnoMarca = 2000,
    Cor = "Preta"
};
#endregion

#region Avioes
Aviao a1 = new Aviao()
{
    Id = "1",
    Marca = "Boing",
    Modelo = "747",
    AnoModelo = 2015,
    AnoMarca = 2015,
    Cor = "Branco"
};

Aviao a2 = new Aviao()
{
    Id = "1",
    Marca = "Embraer",
    Modelo = "Legacy",
    AnoModelo = 2019,
    AnoMarca = 2018,
    Cor = "Azul Marinho"
};
#endregion

List<Trator> trator = new List<Trator>();
List<Motocicleta> motocicleta = new List<Motocicleta>();
List<Aviao> aviao = new List<Aviao>();

trator.Add(t1);
trator.Add(t2);
trator.Add(t3);
motocicleta.Add(m1);
motocicleta.Add(m2);
motocicleta.Add(m3);
aviao.Add(a1);
aviao.Add(a2);

Garagem garagem = new Garagem()
{
    Trator = trator,
    Motocicletas = motocicleta,
    Aviao = aviao
};

Console.WriteLine(garagem.getTrator());
Console.WriteLine(garagem.getMotocicleta());
Console.WriteLine(garagem.getAviao());

