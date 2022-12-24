# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Após várias pesquisas com empresas, houve diversas reclamações e sugestões sobre manter um controle de usuários e registro de alterações para manter informações e dados mais seguros. Baseado nisso, foi dado inicio a um projeto que seria desenvolvido um sistema para controle de registro de usuários. 
O projeto tem a finalidade de controlar quem e como acessa dados sigilosos, a fim de criar um clima mais agradavel e seguro para os colaboradores e usuários de sistemas.
## Personas

Persona 1# - Rodolfo é um empresário de 38 anos que precisa ter um controle de vários usuários em sua empresa. Com grande números de funcionários e unidades espalhadas pelo país qualquer tipo de dados sigilosos pode gerar irreparaveis prejuízos ao cair em mãos erradas.

Persona 2# - Pedro Henrique, é um administrador de sistemas e trabalha na parte de segurança e monitoramento de dados em uma empresa.
## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO | QUERO/PRECISO  |PARA                 |
|--------------------|------------------------------------|----------------------------------------|
| Rodolfo | Preciso de um sistema de login capaz de controlar a entrada de logins aos dados empresáriais da minha empresa.                                                             | Aumentar a segurança               |
|Administrador       | Criar uma funcionalidade que facilite o acesso e controle do usuário                 | Eficiência e maior usabilidade do usuário 
|Pedro Henrique   | Preciso saber quando e o que cada usuário contribuiu no software                                                             | Controlar e evitar mal entendidos              |
|Administrador       | Criar uma funcionalidade que faça registre cada login feito por usuário e registre cada tela que ele acessou |
|Pedro Henrique   | Conseguir encontrar todos os usuários registrados no banco de dados                                                           | Filtrar              |
|Administrador       | Criar uma funcionalidade para ajudar o usuário a visualizar os eventos             | Satisfazer as necessicidades dos usuários e administradores |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir o usuario realizar login no sistema | ALTA | 
|RF-002| Permitir o administrador de sistema monitorar quem e quando entrou no sistema  | ALTA |
|RF-003| Flexebilidade a visualização e busca por registros | ALTA |
|RF-004| Alterar os níveis e hierarquias de usuários | MÉDIA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| Necessidade de servidores capacitados  | MÉDIA | 
|RNF-002| Baixo processamento por acessos simultanêos |  MÉDIA |
|RNF-003| Banco de dados capacitado para inumeros cadastros | ALTO |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o inicio do ano letivo |
|02| Criação de categoria restritas ao Administrador        |
|03| Layout responsivo |