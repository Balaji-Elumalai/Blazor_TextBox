using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Pages.ButtonInput
{
    public partial class ChildComponent : IDisposable
    {

        [Parameter]
        public Dictionary<string, object> InputAttributes { get; set; } = new Dictionary<string, object>();

        [Parameter]
        public string RequestId { get; set; }

        protected virtual void Dispose(bool disposing)
        {
                if (disposing)
                {
                    if (InputAttributes != null)
                    {
                        InputAttributes.Clear();
                        InputAttributes = null;
                    }
                    RequestId = null;
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null;
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        //~ChildComponent()
        //{
        //    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //    Dispose(disposing: false);
        //}

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }


    }

}
