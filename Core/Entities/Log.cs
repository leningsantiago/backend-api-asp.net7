namespace backend_api_asp.net7.Core.Entities;
public class Log: BaseEntity<long>
{
    public string? UserName { get; set; }

    public string Description { get; set; }
}
