using Coursera_BlazorFinalProject.Components.Shared.Models;

namespace Coursera_BlazorFinalProject.Components.Shared.Services
{
    public class EventService
    {
        private static readonly Dictionary<int, List<Registration>> registrations = new();

        private readonly List<Event> _events = new List<Event>
        {
            new Event { Id = 1, Name = "Tech Conference 2025", Date = new DateTime(2025, 6, 15), Location = "New York", Description = "Latest trends in tech." },
            new Event { Id = 2, Name = "Marketing Meetup", Date = new DateTime(2025, 7, 10), Location = "Chicago", Description = "Connect with professionals." },
            new Event { Id = 3, Name = "Startup Pitch Night", Date = new DateTime(2025, 8, 25), Location = "San Francisco", Description = "Pitch your ideas to investors." }
        };

        public List<Event> GetEvents() => _events;

        public Event? GetEventById(int id) =>
            _events.FirstOrDefault(e => e.Id == id);

        public Task RegisterUserAsync(int eventId, Registration registration)
        {
            if (!registrations.ContainsKey(eventId))
                registrations[eventId] = new List<Registration>();
            registrations[eventId].Add(registration);
            return Task.CompletedTask;
        }

        public Task<List<Registration>> GetRegistrationsForEventAsync(int eventId)
        {
            return Task.FromResult(registrations.ContainsKey(eventId) ? registrations[eventId] : new List<Registration>());
        }

        public Task<int> GetRegistrationCountAsync(int eventId)
        {
            return Task.FromResult(registrations.ContainsKey(eventId) ? registrations[eventId].Count : 0);
        }
    }

    public class Registration
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
