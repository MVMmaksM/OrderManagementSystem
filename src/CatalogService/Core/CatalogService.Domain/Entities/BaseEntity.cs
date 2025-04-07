namespace CatalogService.Domain.Entities;

/// <summary>
/// абстрактный базовый класс
/// сущности с обощенным типом для Id
/// в качетсве Id могут использоваться только guid и int
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class BaseEntity<T> where T : struct
{
    private T? _id;
    public T? Id
    {
        get => _id;
        set
        {
            _id = typeof(T) == typeof(Guid) || typeof(T) == typeof(int) ? 
                value : 
                throw new Exception("В качестве идентификатора могут сипользоваться только типы int или Guid");
        }
    }
}