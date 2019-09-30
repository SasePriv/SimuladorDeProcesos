using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeProcesos
{
    public class Proceso
    {
        private string name;
        private int rafaga;
        private int quantum;
        private int residuo;
        private string estado;

        //Constructor para Round Robin
        public Proceso(string name, int rafaga, int quantum)
        {
            this.name = name;
            this.rafaga = rafaga;
            this.quantum = quantum;
            estado = "Preparado";
            residuo = rafaga;
        }

        //Constructor para FIFO
        public Proceso(string name, int rafaga)
        {
            this.name = name;
            this.rafaga = rafaga;
            estado = "Preparado";
        }

        //Metodo para llevar la esta del residuo
        private void doResiduoValue()
        {
            residuo -= quantum;
            if(residuo < 0)
            {
                residuo = 0;
            }
        }

        //Getters and Setters
        public string getName()
        {
            return name;
        }
        public int getRafaga()
        {
            return rafaga;
        }
        public int getQuantum()
        {
            return quantum;
        }
        public int getResiduo()
        {
            return residuo;
        }
        public string getEstado()
        {
            return estado;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setResiduo(int residuo)
        {
            this.residuo = residuo;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }
    }
}
