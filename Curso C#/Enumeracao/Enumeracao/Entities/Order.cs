using System;
using Enumeracao.Entities.Enums;

namespace Enumeracao.Entities
{
    internal class Order
    {
        public int iId { get; set; }
        public DateTime dtMoment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return iId
                + ", "
                + dtMoment
                + ", "
                + Status;
                
        }
    }
}
