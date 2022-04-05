using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Garagem
    {
        public List<Trator> Trator { get; set; }
        public List<Motocicleta> Motocicletas { get; set; }
        public List<Aviao> Aviao { get; set; }

        public string getTrator()
        {
            string tratores = "";
            foreach (var trator in Trator)
            {
                tratores += "\nId: " + trator.Id + " \nMarca: " + trator.Marca + "\nModelo: " + trator.Modelo + "\nAno do Modelo: "
                    + trator.AnoModelo + "\nAno da Marca: " + trator.AnoMarca + "\nCor: " + trator.Cor + "\n";
            }
            return tratores;
        }

        public string getMotocicleta()
        {
            string motocicletas = "";
            foreach (var motocicleta in Motocicletas)
            {
                motocicletas += "\nId: " + motocicleta.Id + " \nMarca: " + motocicleta.Marca + "\nModelo: " + motocicleta.Modelo + "\nAno do Modelo: "
                    + motocicleta.AnoModelo + "\nAno da Marca: " + motocicleta.AnoMarca + "\nCor: " + motocicleta.Cor + "\n";
            }
            return motocicletas;
        }

        public string getAviao()
        {
            string avioes = "";
            foreach (var aviao in Aviao)
            {
                avioes += "\nId: " + aviao.Id + " \nMarca: " + aviao.Marca + "\nModelo: " + aviao.Modelo + "\nAno do Modelo: "
                    + aviao.AnoModelo + "\nAno da Marca: " + aviao.AnoMarca + "\nCor: " + aviao.Cor + "\n";
            }
            return avioes;
        }
    }
}
