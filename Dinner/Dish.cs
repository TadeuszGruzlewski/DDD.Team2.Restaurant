using DDD.Foundations;
using DDD.Primitives.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner;

internal record class Dish(string Name, string Description, Price Price) : ValueObject
{
    // public Image Image ....

    public override bool AssertInvariants(List<InvariantError> errors)
    {
        return true;
    }
}
