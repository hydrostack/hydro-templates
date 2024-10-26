using Hydro;

namespace HydroTemplates.Empty.Pages.Home.Components;

public class Form : HydroComponent
{
    public string Name { get; set; }

    public void Send()
    {
        DispatchGlobal(new NameEvent(Name));
    }
}

public record NameEvent(string Name);
