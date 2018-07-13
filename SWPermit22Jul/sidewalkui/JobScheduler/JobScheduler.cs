using Quartz;
using Quartz.Impl;
using SidewalkUI.Api;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace SidewalkUI.JobScheduler
{
    public class JobScheduler
    {

        public static void Stop()
        {
            log4net.ILog Log = log4net.LogManager.GetLogger(typeof(JobScheduler));
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            JobKey jobkey = new JobKey("SyncJob" + "-" + ConfigurationManager.AppSettings["Environment"].ToString(), "Sync");
            scheduler.DeleteJob(jobkey);
            Log.Info("Job stopped.");
        }
        public static void Start()
        {
            log4net.ILog Log = log4net.LogManager.GetLogger(typeof(JobScheduler));
            try
            {
                Log.Info("Job started.");
                IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
                scheduler.Start();
            
                IJobDetail job = JobBuilder.Create<SyncJob>()
                    .WithIdentity("SyncJob"+ "-"+ConfigurationManager.AppSettings["Environment"].ToString(), "Sync")
                    .Build();
                ITrigger trigger = TriggerBuilder.Create()
                    .WithDailyTimeIntervalSchedule
                      (s =>
                         s.WithIntervalInHours(int.Parse(ConfigurationManager.AppSettings["SchedulerInterval"].ToString()))
                        //s.WithIntervalInMinutes(3)
                        //s.WithIntervalInSeconds(20)
                      //.OnEveryDay()
                      .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(int.Parse(ConfigurationManager.AppSettings["SchedulerHour"].ToString()), int.Parse(ConfigurationManager.AppSettings["SchedulerMinute"].ToString())))
                      ).StartNow()
                    .Build();

                scheduler.ScheduleJob(job, trigger);
                Log.Info("Job Scheduled.");
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.InnerException != null)
                    Log.Error(ex.InnerException);
            }
        }
    }
    public class SyncJob : IJob
    {
        log4net.ILog Log = log4net.LogManager.GetLogger(typeof(JobScheduler));
        SidewalkApiController api = new SidewalkApiController();
        public async void Execute(IJobExecutionContext context)
        {
            try
            {
                Log.Info(string.Format("Job started at: {0}", DateTime.Now.ToString()));
                //await api.SyncOracleSqlCCB();
                System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["SyncURL"].ToString());
                Log.Info(string.Format("Job ended at: {0}", DateTime.Now.ToString()));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.InnerException != null)
                    Log.Error(ex.InnerException);
            }
        }
    }
}