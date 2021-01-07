namespace ACADEMY.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        public bool IsDeleted { get; set; }
    }
}