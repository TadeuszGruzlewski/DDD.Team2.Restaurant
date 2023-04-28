

using DDD.Foundations;

namespace Dinner;

public class Dinner<DinnerId> : Entity<DinnerId> where DinnerId : EntityId, IAggregateRoot
{
    private List<Dish> dishes;
    public IReadOnlyCollection<Dish> Dishes => dishes as IReadOnlyCollection<Dish>;

    public Dinner(DinnerId id) : base(id)
    {
    }
}