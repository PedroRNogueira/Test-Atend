namespace TestAtend.Desktop.Application;

public sealed record ApplicationInfo(
    string Name,
    string CurrentStage,
    string Description)
{
    public static ApplicationInfo Current { get; } = new(
        "TestAtend",
        "Fundacao do aplicativo desktop",
        "Aplicativo WPF para Windows que futuramente auxiliara atendentes com respostas sugeridas.");
}
