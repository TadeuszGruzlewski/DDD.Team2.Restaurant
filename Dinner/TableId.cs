using DDD.Foundations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner;

internal record class TableId(int Number) : EntityId
{
    public override bool IsValid()
    {
        throw new NotImplementedException();
    }
}
