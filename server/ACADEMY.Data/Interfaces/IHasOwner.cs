namespace ACADEMY.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T CreatedBy { get; set; }

        T UpdatedBy { get; set; }
    }
}