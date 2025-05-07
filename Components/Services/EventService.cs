using Coursera_BlazorFinalProject.Components.Models;

namespace Coursera_BlazorFinalProject.Components.Services
{
    public class EventService
    {
        private readonly List<Event> _events = new List<Event>
        {
            new Event { Id = 1, Name = "Tech Conference 2025", Date = new DateTime(2025, 6, 15), Location = "New York", Description = "Latest trends in tech." },
            new Event { Id = 2, Name = "Marketing Meetup", Date = new DateTime(2025, 7, 10), Location = "Chicago", Description = "Connect with professionals." },
            new Event { Id = 3, Name = "Startup Pitch Night", Date = new DateTime(2025, 8, 25), Location = "San Francisco", Description = "Pitch your ideas to investors." }
        };

        public List<Event> GetEvents() => _events;

        public Event? GetEventById(int id) =>
            _events.FirstOrDefault(e => e.Id == id);
    }
}
