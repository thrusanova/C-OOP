using Executor.IO.Commands;
using Executor.Network;

namespace Executor
{
    public class ReadDatabaseCommand:Command
    {
        public ReadDatabaseCommand(string input, string[] data, Tester tester, StudentsRepository repository, DownloadManager downloadManager, IOManager ioManager) : base(input, data, tester, repository, downloadManager, ioManager)
            {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string folderName = this.Data[1];
            this.InputOutputManager.CreateDirectoryInCurrentFolder(folderName);
        }
    }
}