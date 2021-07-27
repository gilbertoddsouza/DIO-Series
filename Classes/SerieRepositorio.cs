using System.Collections.Generic;
using src.DIO.Series.Interfaces;

namespace src.DIO.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir(); // Marcar a posição como excluído
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto); // Retorna uma lista de series
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count; // Conta a lista pelo indice 0
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
