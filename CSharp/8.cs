// Что произойдёт при выполнении кода в консольном приложении? А в приложении с UI (WinForms/WPF)? Почему?

public void Execute()
{
	DoWork().Wait();
}

private async Task DoWork()
{
	await Task.Delay(100);
}
