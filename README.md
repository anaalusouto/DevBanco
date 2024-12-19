# Guidelines para Compartilhamento de Códigos nas Branches

Este documento descreve as práticas recomendadas para o compartilhamento de códigos dentro das branches do repositório. O objetivo é garantir colaboração eficiente, rastreamento claro de mudanças e um processo de integração.

## Estrutura de Branches

1. **Branch Principal (main/master)**:
   - Contém o código de produção estável.
   - Nenhuma alteração deve ser feita diretamente nesta branch. Todas as alterações passam por revisões de código antes de serem mescladas.

## Compartilhamento de Códigos

1. **Comits Descritivos**:
   - Caso você coloque uma nova alteração, escreva mensagens de commit claras e informativas.
   - Estrutura sugerida: `tipo(módulo): descrição breve`
     - Exemplos de tipos: `feat`, `fix`, `refactor`, `docs`.

2. **Sincronização Frequente**:
   - Mantenha a branch de feature atualizada com a branch principal.
   - Antes de abrir um PR, resolva conflitos e teste o código.

4. **Teste Local**:
   - Certifique-se de que as alterações foram testadas localmente antes de compartilhar.


# Criando uma Branch sem Pull Request para a Main

Este guia ensina como criar uma nova branch em um repositório Git, sem a necessidade de enviar uma solicitação de pull request para a branch principal (`main`). A nova branch pode ser usada para desenvolvimento ou testes sem afetar diretamente a branch principal, mas ainda estará dentro do mesmo repositório.

## Passos para Criar uma Nova Branch

### 1. Clone o Repositório

Caso você ainda não tenha o repositório em sua máquina local, clone-o usando o seguinte comando:

   '''bash
   git clone https://github.com/seu-usuario/seu-repositorio.git

### 2. Acesse o Diretório do Repositório
Depois de clonar o repositório, entre no diretório do projeto:
cd seu-repositorio


### 3. Crie uma Nova Branch
Para criar uma nova branch e alternar para ela imediatamente, use o comando:
git checkout -b nome-da-sua-branch (Substitua nome-da-sua-branch pelo nome da sua nova branch.


### 4. Realize Modificações e Commits
Agora que você está na nova branch, pode começar a trabalhar nas modificações necessárias. Quando fizer alterações, adicione e faça commits regularmente:


git add .
git commit -m "Mensagem do commit"


5. Evite Criar um Pull Request para a Main
Ao criar a branch, ela estará disponível localmente e remotamente, mas sem a necessidade de abrir uma pull request para a main. Isso significa que você pode continuar o desenvolvimento sem fazer modificações diretas na branch principal. Você pode trabalhar em novas funcionalidades, correções ou testes de forma isolada.


6. Envie Sua Branch para o Repositório Remoto
Quando quiser compartilhar sua branch ou fazer backup das alterações, empurre a branch para o repositório remoto:

bash
Copiar código
git push origin nome-da-sua-branch
## Boas Práticas

- Evite commits grandes; prefira alterações pequenas e incrementais.
- Documente funcionalidades relevantes no código ou nos arquivos de documentação.
- Use mensagens de commit em inglês ou português, dependendo do padrão do projeto.
- Não exclua branches antes de garantir que todas as alterações foram mescladas e publicadas.

---

Sigam a risca esse tutorial, é importante que vocês aprendam a compartilhar seu códigos de maneira suave e clara. Se precisarem de algo, me mandem mensagem. 💻
