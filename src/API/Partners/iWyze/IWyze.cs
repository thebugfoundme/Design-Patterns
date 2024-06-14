namespace API.Partners.iWyze
{
    public class IWyze : IPartner
    {
        public string Name => "iWyze";

        public string Slug => Name.ToLower().Replace(" ", "-");
    }
}
