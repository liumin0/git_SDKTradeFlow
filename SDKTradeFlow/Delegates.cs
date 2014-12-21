using System;

[assembly: CLSCompliant(true)]
namespace SDKTradeFlow
{
    //public delegate void AddSignalNodeDelegate(SignalNode node);
    public delegate void ActionTriggeredDelegate(SimpleAction action);
}
