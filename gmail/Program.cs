using System;
using System.Net;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        try
        {
            // Erstellen Sie eine neue Instanz von SmtpClient
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                // Setzen Sie Ihre Anmeldeinformationen
                Credentials = new NetworkCredential("Exambel@gmail.com", "Password"),
                EnableSsl = true
            };

            // Erstellen Sie eine neue E-Mail
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("Exambel@gmail.com"),
                Subject = "Das ist der Betreff",
                Body = "Das ist die Nachricht",
                IsBodyHtml = true,
            };

            // Fügen Sie den Empfänger hinzu
            mailMessage.To.Add("Exambel@gmail.com");

            // Senden Sie die E-Mail
            client.Send(mailMessage);

            Console.WriteLine("E-Mail wurde erfolgreich gesendet!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fehler beim Senden der E-Mail: " + ex.Message);
        }
    }
}
