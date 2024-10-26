using Hydro;

namespace HydroTemplates.Empty.Pages.Home.Components;

public class Counter : HydroComponent
{
    public int Value { get; set; }

    public void Add()
    {
        Value++;
    }
}