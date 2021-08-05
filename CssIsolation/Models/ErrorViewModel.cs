using System;

namespace CssIsolation.Models
{
    public class ErrorViewModel
    {
        // TODO: Nullable Reference Type Annotations 
        //  It  shows a warning for the RequestId property in the ErrorViewModel because it might be null. 
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        
        public class ErrorViewModel2
        {
            //  After changing it to a nullable string, the warning disappears.
            public string? RequestId { get; set; }
        
            public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        
        }


    }
}
