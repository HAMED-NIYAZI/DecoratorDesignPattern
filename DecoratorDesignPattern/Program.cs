internal class Program
{
    private static void Main(string[] args)
    {
<<<<<<< HEAD


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
=======
        var x = new ConcretComponent();
        x.Operation();

>>>>>>> b40e008be9be5d2d35580faa169b49e353fd5e36
        Console.ReadKey();
    }
}
