using System;
using tabuleiro;
using xadrez;
using xadrez_console;
using xadrez_console.xadrez;

PosicaoXadrez pos = new PosicaoXadrez('c', 7);

Console.WriteLine(pos);

Console.WriteLine(pos.toPosicao());

Console.ReadLine();