namespace WebPlayground.Request;

/// <summary>
/// Ping request
/// </summary>
/// <param name="message">user message</param>
public record PingRequest(string message);