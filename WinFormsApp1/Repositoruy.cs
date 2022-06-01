using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Infraestructures;

namespace WinFormsApp1
{
    public class Repositoruy : IIntres
    {
        public INteres nterres;

        public double compuesto(double compuesto)
        {
            double ompuesto = nterres.Monto + Math.Pow((1 + nterres.interesCom), nterres.tiempo);
            ompuesto = compuesto;
            return compuesto;
        }

        public double convertir(double convertir)
        {
            throw new NotImplementedException();
        }

        public void Create(INteres t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(INteres t)
        {
            throw new NotImplementedException();
        }

        public List<INteres> GetAll()
        {
            throw new NotImplementedException();
        }

        public double nominal(double nominal)
        {
            throw new NotImplementedException();
        }

        public double simple(double interes)
        {
            throw new NotImplementedException();
        }

        public int Update(INteres t)
        {
            throw new NotImplementedException();
        }
    }
}
