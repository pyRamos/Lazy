# Lazy

 1)Regras de Negócio:

RN01 – Não deve ser possível adicionar mais software que a capacidade interna de memória do console suporte.
RN02 – Consoles de XBox One gastam uma quantidade de armazenamento extra padrão para cada jogo ou aplicativo adicionado.  Essa quantidade extra de cada software influencia na memória disponível para adicionar novos softwares.
RN03 – O texto com a sinopse do software interno deve conter a concatenação em um formato de fácil leitura dos atributos do software (nome, descrição, tamanho, etc) formando uma sinopse padrão.
RN04 – Os atributos exclusivos de aplicativos e jogos devem ser incorporados à sinopse padrão.
RN05 – Todo jogo ou aplicativo possui um tamanho em bytes que ocupa a memória interna do console.
RN06 – Todo XBox One possui uma funcionalidade que exibe as sinopses de todos os jogos e aplicativos que ele possui.

2)Os seguintes requisitos de negócio devem ser atendidos:

Video Game AdicionarSW RN01, RN05

Video Game MemóriaDisponível RN05

XBox One AdicionarSW RN01, RN02, RN05

XBox One MemóriaDisponível RN02, RN05

Xbox One ExibirSinopses RN06

Software Interno Sinopse RN03

Jogo Sinopse RN03, RN04

Aplicativo Sinopse RN03, RN04
