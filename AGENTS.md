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
