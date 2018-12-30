using System;

namespace SignalProcessingForms
{
  public class GenericEventArgs<T> : EventArgs
  {
    public T Parameter { get; set; }

    public GenericEventArgs(T input)
    {
      Parameter = input;
    }
  }
}
