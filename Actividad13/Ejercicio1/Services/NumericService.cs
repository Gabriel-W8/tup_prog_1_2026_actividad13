using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio1.Services
{
    internal class NumericService
    {
        private Alumno[] alumnos = new Alumno[100];
        int cont;
        public NumericService()
        {
            cont = 0;
        }
        public int Contador
        {
            get
            {
                return cont;
            }
        }
        public void RegistrarAlumno(int lu, string nombre, double nota)
        {
            if (Contador < 99)
            {
                alumnos[Contador].LU = lu;
                alumnos[Contador].Nombre = nombre;
                alumnos[Contador].Nota = nota;
                cont++;
            }
        }
        public Alumno VerAlumno(int idx)
        {
            if (idx > -1 && idx < Contador)
            {
                return alumnos[idx];
            }
            else
            {
                return null;
            }
        }
        public int BuscarPorLUSecuencial(int lu)
        {
            int idx = -1;
            for(int i = 0; i < Contador && idx == -1; i++)
            {
                if (lu == alumnos[i].LU)
                {
                    idx = i;
                }
            }
            return idx;
        }
        public int BuscarPorLUBinario(int lu)
        {
            int min = 0, max = Contador - 1, centro, idx = -1;
            while(min <= max && idx == -1)
            {
                centro = (min + max) / 2;
                if (alumnos[centro].LU == lu)
                {
                    idx = centro;
                }
                else
                {
                    if (alumnos[centro].LU > lu)
                    {
                        max = centro - 1;
                    }
                    else
                    {
                        min = centro + 1;
                    }
                }
            }
            return idx;
        }
        public void OrdenarPorLUBurbuja()
        {
            for (int i = 0; i < Contador-1; i++)
            {
                for (int j = i+1; j < Contador; j++)
                {
                    if (alumnos[i].LU > alumnos[j].LU)
                    {
                        Alumno aux = alumnos[i];
                        alumnos[i] = alumnos[j];
                        alumnos[j] = aux;
                    }
                }
            }
        }
        public void OrdenarPorLUQuickSort()
        {
            int p = alumnos[0].LU;
            int min = 1;
            int max = Contador - 1;
            while (min <= max)
            {
                while (min <= Contador - 1 && alumnos[min].LU < p) min++;
                while (max > 0 && p <= alumnos[max].LU) max--;
                if (min < max)
                {
                    Alumno aux = alumnos[min];
                    alumnos[min] = alumnos[max];
                    alumnos[max] = aux;
                }
            }
            Alumno aux_alum = alumnos[0];
            alumnos[0] = alumnos[max];
            alumnos[max] = aux_alum;
            if (0 < max - 1) OrdenarPorLUQuickSort();
            if (max + 1 < Contador - 1) OrdenarPorLUQuickSort();
        }
        public double CalcularPromedio()
        {
            double acum = 0, prom = 0;
            for (int i = 0; i < Contador; i++)
            {
                acum += alumnos[i].Nota;
            }
            if (Contador != 0)
            {
                prom = acum / Contador;
            }
            return prom;
        }
        public Alumno[] VerAlumnosQueSuperanElPromedio()
        {
            int idx = 0;
            Alumno[] supProm = new Alumno[100];
            double prom = CalcularPromedio();
            for (int i = 0; i < Contador; i++)
            {
                if (alumnos[i].Nota > prom)
                {
                    supProm[idx] = alumnos[i];
                    idx++;
                }
            }
            return supProm;
        }
    }
}
