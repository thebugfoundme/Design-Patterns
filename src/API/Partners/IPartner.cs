namespace API.Partners
{
    public interface IPartner
    {
        string Name { get; }
        string Slug => Name.ToLower().Replace(" ", "-");
    }
}
