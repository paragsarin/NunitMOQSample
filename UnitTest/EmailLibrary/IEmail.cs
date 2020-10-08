namespace EmailLibrary
{
    public interface IEmail
    {
        string body { get; set; }
        string client { get; set; }
        string email { get; set; }
        string recipient { get; set; }
        string subject { get; set; }

        bool SendEmail();
    }
}