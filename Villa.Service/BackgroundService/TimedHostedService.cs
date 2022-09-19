using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Villa.Service.Implementation;

namespace Villa.Service.BackgroundService;

public class TimedHostedService : IHostedService, IDisposable
{
    private Timer? _timer = null;
    private volatile bool _ready = false;

    public TimedHostedService()
    {
    }

    public Task StartAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("Timed Hosted Service running.");
        
        _timer = new Timer(DoWork, null, TimeSpan.Zero,
            TimeSpan.FromHours(3));

        return Task.CompletedTask;
    }

    private void DoWork(object? state)
    {
        try
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync("https://localhost:5001/api/VillaFE/UpdateExchangeRates"))
                {
                    Console.WriteLine("Exchange update status code: " + response.Result.StatusCode.ToString());
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public Task StopAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("Timed Hosted Service is stopping.");
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}