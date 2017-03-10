using CasaDoCodigoFoodsXaml.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigoFoodsXaml.DAL
{
    public class EntregadorDal
    {
        private ObservableCollection<Entregador> Entregadores = new ObservableCollection<Entregador>();
        private static EntregadorDal EntregadorInstace = new EntregadorDal();

        private EntregadorDal()
        {
            Entregadores.Add(new Entregador()
            {
                Id = 1,
                nome = "Brauzio",
                telefone = "Asdrugio"
            });

            Entregadores.Add(new Entregador()
            {
                Id = 2,
                nome = "Entencius",
                telefone = "Gesfredio"
            });
            Entregadores.Add(new Entregador()
            {
                Id = 3,
                nome = "Cartucious",
                telefone = "Gesfrundio" });

            Entregadores.Add(new Entregador()
            {
                Id = 4,
                nome = "Adoliterio",
                telefone = "Kentencio" });

            Entregadores.Add(new Entregador()
            {
                Id = 5,
                nome = "Castrogildo",
                telefone = "Gesifrelio" });

            Entregadores.Add(new Entregador()
            {
                Id = 6,
                nome = "Asdrugio",
                telefone = "Brauzio"});

            Entregadores.Add(new Entregador()
            {
                Id = 7,
                nome = "Gesfredio",
                telefone = "Entencius"});

            Entregadores.Add(new Entregador()
            {
                Id = 8,
                nome = "Gesfrundio",
                telefone = "Cartucious" });

            Entregadores.Add(new Entregador()
            {
                Id = 9,
                nome = "Kentencio",
                telefone = "Adoliterio" });
        }


        public static EntregadorDal GetInstance()
        {
            return EntregadorInstace;
        }

        public ObservableCollection<Entregador> GetAll()
        {
            return Entregadores;
        }

        public void Add(Entregador entregador)
        {
            this.Entregadores.Add(entregador);
        }
    }
}
