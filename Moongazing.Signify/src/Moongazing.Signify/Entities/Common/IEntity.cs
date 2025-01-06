namespace Moongazing.Signify.Entities.Common;

public interface IEntity<T>
{
    T Id { get; set; }
}