using Executor.Exceptions;
using Executor.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor.IO.Commands
{
   public abstract class Command
    {
        private Tester judge;
        private StudentsRepository repository;
        private DownloadManager downloadManager;
        private IOManager inputOutputManager;
        private string input;
        private string [] data;

        public Command(string input,string [] data,Tester judge,StudentsRepository repository,DownloadManager downloadManager,IOManager ioManager)
        {
            this.Input = input;
            this.Data = data;
            this.judge = judge;
            this.repository = repository;
            this.downloadManager = downloadManager;
            this.inputOutputManager = ioManager;

        }
        public string Input
        {
            get
            {
                return this.input;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    {
                      throw new InvalidStringException();
                     }
                this.input = value;
            }
        }

        public string[] Data
        {
            get
            {
                return this.data;
            }
            private set
            {
                if (value==null || value.Length==0)
                {
                    throw new NullReferenceException();
                }
                this.data = value;
            }
        }
      public void  DisplayInvalidCommandMessage(string input)
        {
            OutputWriter.DisplayException($"The command '{input}' is invalid");
        }

        public StudentsRepository Repository
        {
            get { return this.repository; }
        }
        public Tester Tester
        {
            get { return this.judge; }
        }
        public IOManager InputOutputManager
        {
             get { return this.inputOutputManager; }
        }
        public DownloadManager DownloadManager
        {
            get { return this.downloadManager; }
        }

        public abstract void Execute();
    }
}
