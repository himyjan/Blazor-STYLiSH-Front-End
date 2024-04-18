namespace STYLiSH.Model
{
  public class AuthResponse
  {
    public string? accessToken { get; set; }
  }

  public class Response
  {
    public AuthResponse? authResponse { get; set; }
    public string? status { get; set; }
    public string? statusText { get; set; }
    public string? error { get; set; }
    public string? text { get; set; }
    public string? json { get; set; }
    // error: Error;
    // text: () => string;
    // json: () => string;
  }
}