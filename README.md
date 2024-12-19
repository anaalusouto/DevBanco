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

## Fluxo de Trabalho Recomendo

1. Crie uma branch baseada na branch principal:
   ```bash
   git checkout main
   git pull origin main
   git checkout -b feature/nome-da-funcionalidade
   ```

2. Desenvolva e commit suas alterações regularmente:
   ```bash
   git add .
   git commit -m "feat(módulo): breve descrição da alteração"
   ```

3. Sincronize sua branch com a principal:
   ```bash
   git fetch origin main
   git merge main
   ```

## Boas Práticas

- Evite commits grandes; prefira alterações pequenas e incrementais.
- Documente funcionalidades relevantes no código ou nos arquivos de documentação.
- Use mensagens de commit em inglês ou português, dependendo do padrão do projeto.
- Não exclua branches antes de garantir que todas as alterações foram mescladas e publicadas.

---

Sigam a risca esse tutorial, é importante que vocês aprendam a compartilhar seu códigos de maneira suave e clara. Se precisarem de algo, me mandem mensagem. 💻
