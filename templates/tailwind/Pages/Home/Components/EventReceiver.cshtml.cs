using Hydro;

namespace HydroTemplates.Tailwind.Pages.Home.Components;

public class EventReceiver : HydroComponent
{
    public EventReceiver()
    {
        Subscribe<NameEvent>(data => Name = data.Name);
    }
    
    public string Name { get; set; }
}

