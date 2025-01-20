using System.Text;

namespace Exam1_2;

public class LogService
{
    private static LogService _instance;
    private StringBuilder _stringBuilder = new StringBuilder();

    private LogService()
    {
        _stringBuilder.AppendLine($"--- Start Log at {DateTime.Now:yyyy-MM-dd HH:mm:ss} ---");
    }

    public static LogService GetInstance()
    {
        if (_instance == null)
        {
            _instance = new LogService();
        }

        return _instance;
    }

    public void Log(string message)
    {
        _stringBuilder.AppendLine($"{DateTime.Now}: {message}");
    }

    public string GetLog()
    {
        return _stringBuilder.ToString();
    }
}