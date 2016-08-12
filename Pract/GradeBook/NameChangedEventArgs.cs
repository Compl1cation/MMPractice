using System;

namespace GradeBooks
{
  public  class NameChangedEventArgs : EventArgs
    {
        public string oldValue { get; set; }
        public string newValue { get; set; }
    }
}
