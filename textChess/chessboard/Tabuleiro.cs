﻿namespace chessboard
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }


        public void colocarPeca(Peca p, Position pos)
        {
            pecas[pos.row, pos.column] = p;
            p.position = pos;
        }
    }
}
