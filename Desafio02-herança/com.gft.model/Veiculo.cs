using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02_herança.com.gft.model
{
    class Veiculo
    {
        private String modelo { get; set; }

        private double velocidade { get; set; }

        private int passageiros { get; set; }

        private double combustivel { get; set; }

        //Métodos

        public void pegarModelo(String modelo)
        {
            this.modelo = modelo;
        }
    }
}
