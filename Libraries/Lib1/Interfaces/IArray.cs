
namespace Lib1.Interfaces
{
    public interface IArray : IPrinter
    {
        int Length { get; }
        void ReCreate(int length);
    }
}
