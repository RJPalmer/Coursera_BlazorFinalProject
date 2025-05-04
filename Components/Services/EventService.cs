using Coursera_BlazorFinalProject.Components.Models;

namespace Coursera_BlazorFinalProject.Components.Services
{
    public class EventService
    {
        public List<Event> GetEvents() => [
            new Event { Id = 1, Name = "Tech Conference 2025", Date = new DateTime(2025, 6, 15), Location = "New York", Description = "Latest trends in tech." },
            new Event { Id = 2, Name = "Marketing Meetup", Date = new DateTime(2025, 7, 10), Location = "Chicago", Description = "Connect with professionals." },
            new Event { Id = 3, Name = "Startup Pitch Night", Date = new DateTime(2025, 8, 25), Location = "San Francisco", Description = "Pitch your ideas to investors." }
        ];

        public Event? GetEventById(int id) =>
            GetEvents().FirstOrDefault(e => e.Id == id);
    }
}
