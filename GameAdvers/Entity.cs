using System;
using System.Collections.Generic;
using System.Text;

namespace GameAdvers
{
    public abstract class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
