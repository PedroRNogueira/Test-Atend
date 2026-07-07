# Arquitetura

## Decisoes iniciais

- O aplicativo e exclusivo para Windows.
- A base usa C# com .NET 8.
- A interface grafica usa WPF.
- A arquitetura sera dividida de forma simples entre `Presentation`, `Application`, `Domain` e `Infrastructure`.
- Capturas de tela futuras devem ser mantidas em memoria sempre que possivel.
- A integracao futura com IA sera feita pela OpenAI Responses API.
- Respostas, regras e exemplos aprovados serao armazenados localmente em etapa futura.
- Capturas de tela nao deverao ser persistidas por padrao.
- Dados sensiveis nao deverao ser gravados em logs.
- A arquitetura deve evitar complexidade excessiva para o tamanho atual do projeto.

## Camadas

`Presentation` contem componentes de interface WPF e logica de apresentacao.

`Application` contem casos de uso, coordenacao de fluxos e modelos simples de aplicacao.

`Domain` contem conceitos centrais e regras independentes de infraestrutura.

`Infrastructure` contem integracoes externas, persistencia local e detalhes do sistema operacional quando forem adicionados.
