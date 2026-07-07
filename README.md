# TestAtend

TestAtend sera um aplicativo desktop para Windows que ajudara atendentes a transformar informacoes visuais da tela em respostas prontas, seguindo regras e exemplos aprovados localmente.

## Problema

Atendentes precisam responder com rapidez, consistencia e cuidado. O projeto pretende reduzir retrabalho ao capturar contexto da tela, consultar a OpenAI API em etapas futuras e exibir uma sugestao de resposta para o atendente revisar.

## Tecnologias

- C#
- .NET 8
- WPF
- xUnit

## Requisitos de desenvolvimento

- Windows
- .NET 8 SDK
- PowerShell

Nenhuma chave da OpenAI deve ser adicionada ao repositorio.

## Comandos

Restaurar dependencias:

```powershell
dotnet restore
```

Compilar:

```powershell
dotnet build TestAtend.sln
```

Executar:

```powershell
dotnet run --project src/TestAtend.Desktop
```

Rodar testes:

```powershell
dotnet test TestAtend.sln
```

## Estrutura

```text
Test-Atend/
├── docs/
│   ├── ARCHITECTURE.md
│   └── ROADMAP.md
├── src/
│   └── TestAtend.Desktop/
│       ├── Application/
│       ├── Domain/
│       ├── Infrastructure/
│       └── Presentation/
└── tests/
    └── TestAtend.Tests/
```

## Estado atual

A fundacao do projeto foi criada com uma aplicacao WPF simples e um projeto de testes xUnit. A janela inicial informa que captura de tela e integracao com API serao implementadas em etapas futuras.

## Ainda nao implementado

- Icone de bandeja.
- Execucao em segundo plano.
- Atalho global.
- Captura de tela.
- Integracao com a OpenAI Responses API.
- Streaming de resposta.
- Persistencia local de regras e exemplos.
- Armazenamento seguro de chave.
- Instalador para Windows.
