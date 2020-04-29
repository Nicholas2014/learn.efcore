namespace EF.Learning.Domain
{
    public interface IPrimaryKey<T>
    {
        T Id { get; set; }
    }
}