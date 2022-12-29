public class SendEmailAndLog: SendEmail
{
    private readonly SendEmail sendEmail;
    public SendEmailAndLog(SendEmail sendEmail)
    {
        this.sendEmail = sendEmail;
    }

    public void Send() 
    {
        sendEmail.Send();
        Log();
    }

    public void Log()
    {
        Console.WriteLine("Log to file ..............");
    }
}
