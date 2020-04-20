using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Duplex_WCF.SampleWcfService;

namespace Duplex_WCF
{
    [CallbackBehavior(UseSynchronizationContext =false)]
    class Program:IProcessCallback
    {
        public void TaskProgress(int progress)
        {
            Console.WriteLine(progress + "% task has been completed");
          
        }

        static void Main(string[] args)
        {
           
            Program program = new Program();
            program.processTask();
            Console.ReadLine();
        }
        private void processTask()
        {
            InstanceContext instanceContext = new InstanceContext(this);
            SampleWcfService.ProcessClient processClient = new SampleWcfService.ProcessClient(instanceContext);
            processClient.TaskProcess();
        }

    }
}
