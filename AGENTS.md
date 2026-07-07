# AGENTS.md

Regras permanentes para trabalhos futuros do Codex neste repositorio:

- Analise o codigo existente antes de modificar.
- Realize mudancas pequenas e focadas.
- Nao reescreva funcionalidades que ja funcionam.
- Nao adicione dependencias sem necessidade.
- Nunca insira tokens, senhas ou chaves no codigo.
- Nunca commite arquivos com segredos.
- Utilize `async/await` em operacoes de entrada e saida.
- Utilize `CancellationToken` em operacoes longas.
- Evite bloquear a thread da interface.
- Separe apresentacao, aplicacao, dominio e infraestrutura de maneira pragmatica.
- Mantenha compatibilidade exclusiva com Windows.
- Execute build e testes antes de concluir.
- Atualize a documentacao quando o comportamento mudar.
- Revise `git diff` antes do commit.
- Use mensagens de commit convencionais: `feat`, `fix`, `docs`, `test`, `refactor` e `chore`.
- Nao modifique arquivos fora do escopo solicitado.
- Nao afirme que uma funcionalidade foi testada manualmente se ela nao foi realmente testada.
- Faca push somente quando build e testes forem aprovados.

## Fluxo de branches e Pull Requests

- Nunca faca commit diretamente na branch `main`.
- Nunca faca push diretamente para a branch `main`.
- Crie uma branch especifica para cada etapa, funcionalidade, correcao ou documentacao.
- Use nomes de branch claros, como `feat/nome-da-funcionalidade`, `fix/nome-da-correcao`, `docs/nome-da-documentacao` ou `chore/nome-da-tarefa`.
- Faca commits somente na branch de trabalho.
- Faca push somente da branch de trabalho.
- Abra um Pull Request da branch de trabalho para a `main`.
- Nao realize merge antes da revisao.
- Nunca use `--force` em push.
- Nao exclua a branch antes da confirmacao do merge.
- Antes de iniciar uma nova etapa, parta da versao atualizada da `main`.
- Considere uma tarefa concluida somente quando o build passar, os testes passarem, o commit estiver na branch correta, o push da branch tiver sido concluido e o Pull Request estiver aberto ou pronto para revisao.
