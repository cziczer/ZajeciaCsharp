using System;

namespace delegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Sendin an email");
        }
    }
}