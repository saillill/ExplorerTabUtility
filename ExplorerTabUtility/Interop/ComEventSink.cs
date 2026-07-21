using System;
using System.Runtime.InteropServices;

namespace ExplorerTabUtility.Interop;

public sealed class ComEventSink : IDisposable
{
    private readonly object _rcw;
    private readonly Guid _iid;
    private readonly int _dispid;
    private readonly Delegate _handler;
    private bool _disposed;

    private ComEventSink(object rcw, Guid iid, int dispid, Delegate handler)
    { _rcw = rcw; _iid = iid; _dispid = dispid; _handler = handler; }

    public static ComEventSink? Connect(object rcw, Guid eventIid, int dispid, Delegate handler)
    {
        try { ComEventsHelper.Combine(rcw, eventIid, dispid, handler); return new ComEventSink(rcw, eventIid, dispid, handler); }
        catch { return null; }
    }

    public void Dispose()
    { if (_disposed) return; _disposed = true; try { ComEventsHelper.Remove(_rcw, _iid, _dispid, _handler); } catch { } }
}
