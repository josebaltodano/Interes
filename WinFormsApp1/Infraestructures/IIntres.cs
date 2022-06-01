using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Infraestructures
{
     public interface IIntres : Imodel<INteres>
    {
        double simple(double interes);
        double nominal(double nominal);
        double compuesto(double compuesto);
        double convertir(double convertir);

    }
}
