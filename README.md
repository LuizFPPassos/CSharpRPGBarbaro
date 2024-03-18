# CSharpRPGBarbaro
## Versão 0.1.4
Atividade proposta da disciplina Programação Orientada a Objetos I, do curso de Análise e Desenvolvimento de Sistemas da UNIP - Ribeirão Preto.
Criação de uma classe "Barbaro" em C#, com atributos e métodos especificados.
Posteriormente ampliado para um jogo funcional de combate 1 vs 1 (Player vs AI) em turnos, incluindo sistema de D20 e D2, além de 3 níveis de dificuldade.
;
### Manual de jogo
Primeiramente, o jogador deve selecionar o nível de dificuldade:  
1 - Fácil  
2 - Normal  
3 - Difícil  
O nível de dificuldade afeta as jogadas D20 (dado de 20 faces), tornando-as mais fáceis para o jogador e mais difíceis para o inimigo no nível Fácil, ou mais difíceis para o jogador e mais fáceis para o inimigo no nível Difícil.  
Além disso, o jogador começa com 3 poções no nível Fácil, 2 no nível Normal, e 1 no nível Difícil.  
  
Após isso, o jogador deve dar um nome ao seu personagem, ou apenas teclar ENTER para que o gerador de nomes escolha um entre 100 possibilidades.  
  
No Menu Principal, o jogador pode escolher:  
1 - Combate (Adentra no modo combate, no qual o jogador enfrenta um outro bárbaro, controlado pelo computador, em turnos.)  
2 - Status (Exibe os atributos do personagem do jogador.)  
3 - Level Up (Caso o jogador tenha derrotado um inimigo, ele pode acessar a função Level Up para subir seu personagem de nível.)  
4 - Revigorar (O jogador pode consumir poções para Revigorar seu personagem, restaurando sua Vida e Energia.)  
5 - Sair (Fecha o jogo.)  
  
**Combate**  
  
Primeiramente, o jogador joga um D20, que determina o modificador de nível do oponente.  
- Uma jogada de valor 20 representa um Sucesso crítico, definindo o nível do oponente como Nível do Jogador -2.  
- Uma jogada de valor entre 19 e 15 representa um Sucesso, definindo o nível do oponente como Nível do Jogador -1.  
- Uma jogada de valor entre 14 e 6 representa uma jogada neutra, definindo o nível do oponente como igual ao Nível do Jogador.  
- Uma jogada de valor entre 5 e 1 representa um Fracasso, definindo o nível do oponente como Nível do Jogador +1.  
- Uma jogada de valor 0 representa um Fracasso crítico, definindo o nível do oponente como Nível do Jogador +2.  
  
Após isso, o jogador joga um D2 (uma moeda), e caso o resultado seja 0, o primeiro turno é do jogador, e caso seja 1, o primeiro turno é do oponente.  
  
O primeiro turno sempre inicia com um ataque, no qual o jogador ou inimigo jogam um D20, que define o multiplicador de ataque, que vai de 0 a 1.  
  
Em seu turno (a partir do segundo turno), o jogador tem as seguintes opções:  
1 - Atacar (prossegue com o próximo ataque.)  
2 - Revigorar (exibe o menu revigorar, no qual o jogador pode consumir poções para restaurar sua Vida e Energia.)  
3 - Status (exibe Vida/MaxVida e Energia/MaxEnergia de ambos os personagens.)  
  
- O combate termina quando a Vida de um dos personagens chegar a 0.  
- O jogador então adquire experiência suficiente para subir o nível de ser personagem em +1 (realizado no menu Level Up do Menu Principal), além de adquirir também +1 poção.  
- Recomenda-se Revigorar o personagem antes de adentrar um novo combate, caso sua Vida e Energia tenham sido danificadas no último combate, e o jogador possua poções disponíveis.  
- Caso o jogador seja derrotado, o jogo é finalizado (Game Over).  
