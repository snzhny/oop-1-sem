namespace laba_3;

public interface IControl<T>
{
    void Add(T item);
    void Delete(T item);
    void Show();
}
