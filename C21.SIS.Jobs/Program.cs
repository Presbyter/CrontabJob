using C21.SIS.Jobs.Unit.Jobs;
using C21.SIS.Jobs.Unit.Log;
using Core.Entity;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace C21.SIS.Jobs
{
    class Program
    {
        private static Unit.Log.ILogger _log = new NLogger(LogManager.GetCurrentClassLogger());

        static void Main(string[] args)
        {
            _log.Info("Press 'exit' to quit the application.");
            var app = new CommandLineApplication();
            app.HelpOption();
            // var optionSubject = app.Option("-s|--subject <SUBJECT>", "The subject", CommandOptionType.SingleValue);
            app.OnExecute(() =>
            {
                // var subject = optionSubject.HasValue() ? optionSubject.Value() : "world";
                // Console.WriteLine($"Hello {subject}!");
                var task1 = DoJobEveryday<RefreshRealtyStationsJob>("refresh_realty_stations_job", "refresh_realty_stations_trigger", "group1");
                var task2 = DoJobEvery5Minutes<RefreshEmployeeStatus>("refresh_employee_status_job", "refresh_employee_status_trigger", "group1");
                Task.WaitAll(task1, task2);
                while ("exit" != Console.ReadLine().ToLower()) { }
            });
            app.Execute(args);
        }

        /// 任务封装
        private static async Task DoJobEveryday<T>(string jobName, string triggerName, string groupName) where T : IJob
        {
            try
            {
                // Grab the Scheduler instance from the Factory
                var factory = new StdSchedulerFactory(new NameValueCollection
                {
                    { "quartz.serializer.type", "binary" }
                });
                var scheduler = await factory.GetScheduler();

                // and start it off
                await scheduler.Start();

                // define the job and tie it to our HelloJob class
                var job = JobBuilder.CreateForAsync<T>().WithIdentity(jobName, groupName).Build();
                // Trigger the job to run now, and then repeat every 10 seconds
                var trigger = TriggerBuilder.Create().WithIdentity(triggerName, groupName).WithCronSchedule("0 0 0 * * ?").Build();

                // Tell quartz to schedule the job using our trigger
                await scheduler.ScheduleJob(job, trigger);

                // some sleep to show what's happening
                // await Task.Delay(TimeSpan.FromSeconds(10));

                // and last shut down the scheduler when you are ready to close your program
                // await scheduler.Shutdown();
            }
            catch (System.Exception ex)
            {
                _log.Error(ex);
            }
        }

        private static async Task DoJobEvery5Minutes<T>(string jobName, string triggerName, string groupName) where T : IJob
        {
            try
            {
                // Grab the Scheduler instance from the Factory
                var factory = new StdSchedulerFactory(new NameValueCollection
                {
                    { "quartz.serializer.type", "binary" }
                });
                var scheduler = await factory.GetScheduler();

                // and start it off
                await scheduler.Start();

                // define the job and tie it to our HelloJob class
                var job = JobBuilder.CreateForAsync<T>().WithIdentity(jobName, groupName).Build();
                // Trigger the job to run now, and then repeat every 10 seconds
                var trigger = TriggerBuilder.Create().WithIdentity(triggerName, groupName).WithCronSchedule("0 0/2 * * * ?").Build();

                // Tell quartz to schedule the job using our trigger
                await scheduler.ScheduleJob(job, trigger);

                // some sleep to show what's happening
                // await Task.Delay(TimeSpan.FromSeconds(10));

                // and last shut down the scheduler when you are ready to close your program
                // await scheduler.Shutdown();
            }
            catch (System.Exception ex)
            {
                _log.Error(ex);
            }
        }
    }
}
