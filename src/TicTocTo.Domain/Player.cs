using System;

namespace TicTocTo.Domain
{
   public enum MarkerType
    {
        X=1,
        O=2
    }
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public MarkerType MarkerType { get; set; }
    }
}
