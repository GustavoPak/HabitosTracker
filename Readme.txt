=== PROPOSTA ===

 Projeto de API - Hábitos Trace é uma API que permite usuários criarem, atualizar e acompanhar hábitos diários do dia a dia, essa API vai armazenar hábitos criados pelas pessoas, e a cada dia, essa pessoa pode conferir na lista
de hábitos diários quais hábitos estão pendentes, podendo ela marcar tal hábito como concluído.

-- INICIO DO PROJETO --

 MODELOS

 Foi criado modelos referentes ao projeto proposto, e esses modelos usam conceitos do DDD (Domain drive design) tais
como :

Entidade - Conceito que visa criar uma classe genérica que possui propriedades que todas as classes geralmente tem e
fazer, essas entidades herdam essa propriedade ao invés de criar varias cópias do mesmo, o exemplo usa a propriedade Id como propriedade genérica.

Lógica de negócios dentro da entidade (modelo rico, não apenas uma entidade burra) : agora as entidades possuem uma logica de auto validação diretamente ligado a entidade principal, ou seja, ela se auto valida, com métodos criados para validação e usados diretamente no construtor (adicionado também no método update).

Tratamento de erros como parte do domínio - Na camada de domínio agora existe uma classe especifica de exceção, que 
apenas será usada na camada de domínio ser facilmente identificável qual o tipo da exceção (nada genérico literalmente o DOMAINexception.

Invariantes de domínio: validação diretamente no construtor do domínio, que não deixa ser criado variáveis de classes
inválidas.
