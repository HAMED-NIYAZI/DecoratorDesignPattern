internal class Program
{
    private static void Main(string[] args)
    {


        var concret = new ConcretComponent();
        concret.Operation();//use original


        var decorator = new ConcretDecorator(concret);
        decorator.Operation();// use decorated



        var sendEmail = new SendEmail();
        var sendEmailAndLog = new SendEmailAndLog(sendEmail);
        sendEmail.Send();
        sendEmailAndLog.Send();
        sendEmailAndLog.SendToYahoo();

        var d = new ConcretDecorator(new ConcretComponent());
        decorator.Operation();// use decorated
        Console.ReadKey();
    }
}
