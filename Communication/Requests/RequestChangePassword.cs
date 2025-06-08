namespace WebApi01.Communication.Requests;

public class RequestChangePassword
{
    public string CurrentPassword { get; set; }
    public string NewPassword { get; set; }
}
