namespace Catalog.API.GraphQL.Queries;
public record Name(string FirstName, string Surname);
public class Query 
{
    public Name Hello(string name, string surname)
    {
        var result = new Name(name, surname);
        return result;
    }
    
}