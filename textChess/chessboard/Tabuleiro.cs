namespace chessboard
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

        public Peca peca(Position pos)
        {
            return pecas[pos.row, pos.column];
        }

        public bool existePeca(Position pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }


        public void colocarPeca(Peca p, Position pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe peça nessa posição");
            }
            pecas[pos.row, pos.column] = p;
            p.position = pos;
        }



        public bool posicaoValida(Position pos)
        {
            if (pos.row < 0 | pos.row > linhas | pos.column < 0 | pos.column > colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Position pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }
    }
}
