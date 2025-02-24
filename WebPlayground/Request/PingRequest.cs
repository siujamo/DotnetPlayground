namespace WebPlayground.Request;

/// <summary>
/// Ping request
/// </summary>
/// <param name="Message">user message</param>
public record PingRequest(string Message);