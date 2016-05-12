﻿using CrystalQuartz.Core;
using CrystalQuartz.Core.SchedulerProviders;
using CrystalQuartz.Web.Comands.Inputs;
using Quartz;

namespace CrystalQuartz.Web.Comands
{
    public class DeleteTriggerCommand : AbstractOperationCommand<TriggerInput>
    {
        public DeleteTriggerCommand(ISchedulerProvider schedulerProvider, ISchedulerDataProvider schedulerDataProvider) : base(schedulerProvider, schedulerDataProvider)
        {
        }

        protected override void PerformOperation(TriggerInput input)
        {
            var triggerKey = new TriggerKey(input.Trigger, input.Group);
            Scheduler.UnscheduleJob(triggerKey);
        }
    }
}