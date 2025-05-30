﻿using SQLite;

namespace MauiAppMinhasCompras2.Models
{
    public class Produto
    {
        string _descricao;
        string _categoria;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao {
            get => _descricao;
            set 
            { 
                if(value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }

                _descricao = value;
            
            } 
        }

        private double _quantidade;
        public double Quantidade { 
            get => _quantidade;
            set 
            {
                if(value <= 0)
                {
                    throw new Exception("Por favor, preencha a quantidade com um número válido (maior que 0)");
                }
                _quantidade = value;
            } 
        }

        private double _preco;
        public double Preco { 
            get => _preco;
            set 
            { 
                if(value <= 0)
                {
                    throw new Exception("Por favor, preencha o preço com um número válido (maior que 0)");
                }
                _preco = value;
            }
        }
        public double Total { get => Quantidade * Preco; }
        public string Categoria { 
            get => _categoria;
            set 
            { 
                if(value == null)
                {
                    throw new Exception("Por favor, preencha a categoria");
                }
                _categoria = value;
            }
        }
    }

    public class TotalCategoria
    {
        public string Categoria { get; set; }
        public double Total { get; set; }
    }
}
