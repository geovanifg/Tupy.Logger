using System;
using System.Collections.Generic;
using Tupy;
using Tupy.Jobs;

namespace Tupy.Logger
{
    public static class LoggerOrchestrator
    {
        private static EventSourceManager EventSourceManager { get; set; } = new EventSourceManager();
        public static ProviderManager ProviderManager { get; set; } = new ProviderManager();
        public static List<ExecutionResponse> ExecutionErrors { get; set; } = new List<ExecutionResponse>();

        public static void AddEventSource(EventSource e)
        {
            if (EventSourceManager.Add(e))
            {
                var job = new Job()
                {
                    Name = e.Name + " clean job"
                };

                job.StepAction = async delegate () 
                {
                    var expiration = DateTime.Now;
                    ExecutionResponse response = null;

                    foreach (var provider in ProviderManager.List())
                    {
                        try
                        {
                            response = await provider.RemoveBefore(e.Name, expiration);
                        }
                        catch (Exception ex)
                        {
                            response = new ExecutionResponse(false)
                            {
                                Message = $"Provider {provider.ID} ({provider.Type.ToString()}) RemoveBefor error.",
                                Content = ex.Message
                            };
                        }

                        // If execution error, then add in the list
                        if (response.IsSuccess == false)
                        {
                            ExecutionErrors.Add(response);
                        }
                    }
                };
                job.Schedule.FrequencyOption = e.RetentionPeriodoType;
                job.Schedule.FrequencyInterval = e.MinimumRetention;

                JobManager.Jobs.Add(job);
            }
        }

        public static void Start()
        {
            ExecutionErrors.Clear();
            JobManager.Start();
        }

        public static void Stop()
        {
            JobManager.Stop();
        }
    }
}