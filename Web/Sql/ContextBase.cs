using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Web.Sql;
public interface IEntity<E> where E : class;
public interface IProperty<P> where P : class;
public class ContextBase<C>(DbContextOptions<C> options) : DbContext(options) where C : DbContext
{
    public static string SerializeProperty<P>(P property) where P : class, IProperty<P> => JsonSerializer.Serialize(property);
    public static P DeserializeProperty<P>(string json) where P : class, IProperty<P> => JsonSerializer.Deserialize<P>(json) ?? throw new();
    public static string SerializeProperties<P>(List<P> property) where P : class, IProperty<P> => JsonSerializer.Serialize(property);
    public static List<P> DeserializeProperties<P>(string json) where P : class, IProperty<P> => JsonSerializer.Deserialize<List<P>>(json) ?? [];
}