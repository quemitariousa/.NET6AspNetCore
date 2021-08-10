using System;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyDebug.CustomEvents
{
    //TODO: Create custom events blazor
    // 1. Run project
    // 2. In the home page you can see input. If you paste any text in this input you can see date when you did it
    [EventHandler("oncustompaste", typeof(CustomPasteEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
    public static class EventHandlers
    {
        // This static class doesn't need to contain any members. It's just a place where we can put
        // [EventHandler] attributes to configure event types on the Razor compiler. This affects the
        // compiler output as well as code completions in the editor.
    }
    
    //TODO: Go to declaration
    // 1. Right click on EventArgs and select Go to ... Declaration
    // 2. External sources should be loaded
    
    
    public class CustomPasteEventArgs : EventArgs
    {
        // Data for these properties will be supplied by custom JavaScript logic
        public DateTime EventTimestamp { get; set; }
        public string PastedData { get; set; }
    }
}