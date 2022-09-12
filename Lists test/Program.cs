using System;
using System.Timers;

public class Example
{
    private static System.Timers.Timer aTimer;

    public static void Main()
    {

        aTimer = new System.Timers.Timer(1000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent; //Tempo decorrido + método de chamada.
        aTimer.AutoReset = true; //Faz executar o timer várias vezes...(chamar o método varias vezes nesse caso)
        aTimer.Enabled = true; //Para habilita-lo
        aTimer.Start(); //Inicializa o timer

        Console.WriteLine("\nPress the Enter key to exit the application...\n");
        Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
        Console.ReadLine();
        aTimer.Stop(); //Para o timer 
        aTimer.Dispose(); //Encerra todas as atividades de timer

        Console.WriteLine("Terminating the application...");
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        //Aqui realiza a execução do que será feito.
        Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
    }
}
