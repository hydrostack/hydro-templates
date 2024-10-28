using Hydro;

namespace HydroTemplates.Empty.Pages.Home.Components;

public class NameForm : HydroComponent
{
    public string Name { get; set; }

    public void Send()
    {
        DispatchGlobal(new NameEvent(Name));
    }
}

public record NameEvent(string Name);
