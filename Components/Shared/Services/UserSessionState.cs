namespace Coursera_BlazorFinalProject.Components.Shared.Services;

public class UserSessionState
{
    public string? UserName { get; set; }
    public int? LastRegisteredEventId { get; set; }
    public bool HasVisited { get; set; } = false; // Add this property
}