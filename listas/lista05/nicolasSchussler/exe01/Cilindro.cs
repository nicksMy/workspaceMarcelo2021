// Bruno Napoleão A. M. & Nicolas Schüssler G. - 03/12/21
using System;
// inclusão de Math e Console

namespace M3
// inicio de escopo do namespace
{
    public class Cilindro
    // início escopo da classe
    {
        // estados   
        // variaveis de instância
        private double altura;
        private double raio;
        private double volume;
        private double areaBase;
        private double areaLateral;
        private double areaTotal;
        private double areaPerimetro;

        // comportamento / métodos
        public Cilindro (double h, double r)
        // construtor
        {
            altura = h;
            raio = r;
            volume = 0;
        }

        /*  Volume: πa2b
            Área da base: πa2
            Área lateral: 2πab
            Área total: 2πa22πab

            a = raio; b = altura
        */ 
        public void calculaVolume ()
        // procedimento para calcular o volume
        {
            volume = Math.PI * Math.Pow(raio, 2) * altura;
        }

        public void calculaAreaBase ()
        // procedimento para calcular a area da base
        {
            areaBase = Math.PI * Math.Pow(raio, 2);
        }

        public void calculaAreaLateral ()
        // procedimento para calcular a area lateral
        {
            areaLateral = 2 * Math.PI * raio * altura;
        }
        public void calculaAreaTotal ()
        // procedimento para calcular a area total
        {
            areaTotal = 2 * Math.PI * raio * (raio + altura) ;
        }

        public double getAreaBase ()
        // função apra retornar resultado da area da base
        {
            return areaBase;
        }
        public double getAreaLateral ()
        // função apra retornar resultado da area da base
        {
            return areaLateral;
        }
        public double getAreaTotal ()
        // função apra retornar resultado da area da base
        {
            return areaTotal;
        }
    }
}