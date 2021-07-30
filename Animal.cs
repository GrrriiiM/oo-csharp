using System;

namespace oo_csharp
{
    public class Animal
    {
        private string familia;
        private string especie;
        private string cor = "Sem Cor";
        private bool perigoso;
        private int quantidadePatas;


        public Animal(string familia, string especie)
        {
            this.familia = familia;
            this.especie = especie;
        }

        public Animal(string familia, string especie, string cor)
        {
            this.familia = familia;
            this.especie = especie;
            this.cor = cor;
        }



        

        public string Familia 
        {
            get
            {
                return this.familia;
            }
        }

        public string Especie 
        {
            get
            {
                return this.especie;
            }
        }

        public string GetCor()
        {
            return this.cor;
        }

        public bool GetPerigoso()
        {
            return this.perigoso;
        }

        public void SetPerigoso(bool valor)
        {
            this.perigoso = valor;
        }

        public int QuantidadePatas 
        {
            get
            {
                return this.quantidadePatas;
            }
            set
            {
                if (value > 8) throw new Exception("Não existe animais com mais de 8 patas");
                this.quantidadePatas = value;
            }
        }
        public string FazerBarulho()
        {
            return "...";
        }

        public string Descrever()
        {
            var descricao = "";
            descricao += "Familia: " + this.familia + "\n";
            descricao += "Especie: " + this.especie + "\n";
            descricao += "Cor: " + this.cor + "\n";
            descricao += "Perigoso: " + (this.perigoso ? "Sim" : "Não") + "\n";
            descricao += "Patas: " + this.quantidadePatas + "\n";

            return descricao;
        }

    }
}
