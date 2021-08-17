using System;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyDebug.CustomEvents
{
    //TODO: EventHandler code
    // 1. No red code
    // 2. Syntax highlighting works
    // 3. Code completion when you start typing [EventHandler]
    //TODO: Test custom events blazor
    // 1. Run project
    // 2. In the home page you can see input. If you paste any text in this input you can see date when you did it
    [EventHandler("oncustompaste", typeof(CustomPasteEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
    public static class EventHandlers
    {
        // This static class doesn't need to contain any members. It's just a place where we can put
        // [EventHandler] attributes to configure event types on the Razor compiler. This affects the
        // compiler output as well as code completions in the editor.
    }
    
    //TODO: Go to declaration External Source
    // 1. Right click on EventArgs and select Go to ... Declaration
    // 2. External sources should be loaded
    
    // TODO: Go to implementation 
    // 1. Right click on EventArgs and select Go to ... Implementation
    // 2. You can see implementations of 'EventArgs'
    
    //TODO: Go to implementation project item navigation
    // 1. Right click on DateTime and select Go to.. Implementation
    // 2. You can see project item navigation
    // 3. The transition to another file should be carried out without problems 
    public class CustomPasteEventArgs : EventArgs
    {
        // Data for these properties will be supplied by custom JavaScript logic
        public DateTime EventTimestamp { get; set; }
        public string PastedData { get; set; }
    }
}