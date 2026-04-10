static class LogLine
{
	public static string Message(string logLine)
	{
		int index = logLine.IndexOf(":");
		string newS = logLine.Substring(index + 2);
		return newS.Trim();
	}

	public static string LogLevel(string logLine)
	{
		if (logLine.ToLower().Contains("error")) return "error";
		else if (logLine.ToLower().Contains("warning")) return "warning";
		else if (logLine.ToLower().Contains("info")) return "info";
		else return "Not a log line.";
	}

	public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
