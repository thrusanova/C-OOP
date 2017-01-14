using System;
using System.Diagnostics;
using System.Text;
using Executor.Network;
using System.IO;
using Executor.IO.Commands;

namespace Executor
{
    public  class CommandInterpreter
    {
        private Tester judge;
        private StudentsRepository repository;
        private DownloadManager downloadManager;
        private IOManager inputOutputManager;

        public CommandInterpreter(Tester judge, StudentsRepository repository, DownloadManager downloadManager, IOManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.downloadManager = downloadManager;
            this.inputOutputManager = inputOutputManager;
        }
        public void InterpreterCommand(string input)
        {
            string[] data = input.Split();

            string commandName = data[0];

            try
            {
                Command command = this.ParseCommand(input, commandName, data);
                command.Execute();
            }
            catch (Exception ex)
            {
                OutputWriter.DisplayException(ex.Message);
            }


            //      catch(DirectoryNotFoundException dnfe)
            //      {
            //       OutputWriter.DisplayException(dnfe.Message);
            //  }
            //      catch (ArgumentOutOfRangeException aoore)
            //     {
            //          OutputWriter.DisplayException(aoore.Message);
            //      }
            //      catch(ArgumentException ae)
            //        {
            //            OutputWriter.DisplayException(ae.Message);
            //    //     }
            //    catch(Exception e)
            //   {
            //       OutputWriter.DisplayException(e.Message);
            // }
        }
        private Command ParseCommand(string input, string commandName, string[] data)
        {
            switch (commandName)
            {
                case "open":
                    return new OpenFileCommand(input, data, this.judge, this.repository, this.downloadManager,
                       this.inputOutputManager);
                case "mkdir":
                    return new MakeDirectoryCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "ls":
                    return new TraverseFoldersCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "cmp":
                    return new CompareFilesCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "cdrel":
                    return new ChangeRelativePathCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "cdabs":

                    return new ChangeAbsolutePathCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "readdb":
                    return new ReadDatabaseCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "dropdb":
                    return new DropDatabaseCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "help":

                    return new GetHelpCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "filter":
                    return new PrintFilteredStudentsCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "order":
                    return new PrintOrderedStudentsCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "download":
                    return new DownloadFileCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "downloadAsynch":
                    return new DownloadAsynchCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);
                case "show":
                    return new ShowCourseCommand(input, data, this.judge, this.repository, this.downloadManager,
                        this.inputOutputManager);              
                default:
                    throw new InvalidCommandException(input);

            }
        }

        private void TryDownloadRequestedFileAsync(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string url = data[1];
                this.downloadManager.DownloadAsync(url);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryDownloadRequestedFile(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string url = data[1];
                this.downloadManager.Download(url);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryShowWantedData(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string courseName = data[1];
                this.repository.GetAllStudentsFromCourse(courseName);
            }
            else if (data.Length == 3)
            {
                string courseName = data[1];
                string userName = data[2];
                this.repository.GetStudentScoresFromCourse(courseName, userName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryFilterAndTake(string input, string[] data)
        {
            if (data.Length == 5)
            {
                string courseName = data[1];
                string filter = data[2].ToLower();
                string takeCommand = data[3].ToLower();
                string takeQuantity = data[4].ToLower();

                TryParseParametersForFilterAndTake(takeCommand, takeQuantity, courseName, filter);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryParseParametersForFilterAndTake(
            string takeCommand, string takeQuantity, string courseName, string filter)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    this.repository.FilterAndTake(courseName, filter);
                }
                else
                {
                    int studentsToTake;
                    bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);
                    if (hasParsed)
                    {
                        this.repository.FilterAndTake(courseName, filter, studentsToTake);
                    }
                    else
                    {
                        OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
                    }
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidTakeCommand);
            }
        }

        private  void TryOrderAndTake(string input, string[] data)
        {
            if (data.Length == 5)
            {
                string courseName = data[1];
                string orderType = data[2].ToLower();
                string takeCommand = data[3].ToLower();
                string takeQuantity = data[4].ToLower();

                TryParseParametersForOrderAndTake(takeCommand, takeQuantity, courseName, orderType);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryParseParametersForOrderAndTake(string takeCommand, string takeQuantity, string courseName, string orderType)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    this.repository.OrderAndTake(courseName, orderType);
                }
                else
                {
                    int studentsToTake;
                    bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);
                    if (hasParsed)
                    {
                        this.repository.OrderAndTake(courseName, orderType, studentsToTake);
                    }
                    else
                    {
                        OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
                    }
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidTakeCommand);
            }
        }

        private  void TryOpenFile(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string fileName = data[1];
                Process.Start(SessionData.currentPath + "\\" + fileName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryCompareFiles(string input, string[] data)
        {
            if (data.Length == 3)
            {
                string firstPath = data[1];
                string secondPath = data[2];

                this.judge.CompareContent(firstPath, secondPath);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryGetHelp(string input, string[] data)
        {
            if (data.Length == 1)
            {
                DisplayHelp();
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryReadDatabaseFromFile(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string fileName = data[1];
                this.repository.LoadData(fileName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryChangePathAbsolute(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string absolutePath = data[1];
               this.inputOutputManager.ChangeCurrentDirectoryAbsolute(absolutePath);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryChangePathRelatively(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string relPath = data[1];
                this.inputOutputManager.ChangeCurrentDirectoryRelative(relPath);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryTraverseFolders(string input, string[] data)
        {
            if (data.Length == 1)
            {
                this.inputOutputManager.TraverseDirectory(0);
            }
            else if (data.Length == 2)
            {
                int depth;
                bool hasParsed = int.TryParse(data[1], out depth);
                if (hasParsed)
                {
                    this.inputOutputManager.TraverseDirectory(depth);
                }
                else
                {
                    DisplayInvalidCommandMessage(input);
                }
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private  void TryCreateDirectory(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string folderName = data[1];
                this.inputOutputManager.CreateDirectoryInCurrentFolder(folderName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }
        private void TryDropDb(string input,string [] data)
        {
            if (data.Length!=1)
            {
                this.DisplayInvalidCommandMessage(input);
                return;
            }
            this.repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }
        public  void DisplayInvalidCommandMessage(string input)
        {
            OutputWriter.DisplayException($"The command '{input}' is invalid");
        }

    
     
        public  void DisplayHelp()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{new string('_', 100)}");
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "make directory - mkdir nameOfFolder"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "traverse directory - ls depth"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "comparing files - cmp absolutePath1 absolutePath2"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "change directory - cdRel relativePath or \"..\" for level up"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "change directory - cdAbs absolutePath"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "read students data base - readDb fileName"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "filter {courseName} excelent/average/poor  take 2/5/all students - filterExcelent (the output is written on the console)"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "order increasing students - order {courseName} ascending/descending take 20/10/all (the output is written on the console)"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "download file - download URL (saved in current directory)"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "download file asinchronously - downloadAsynch URL (saved in the current directory)"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "get help – help"));
            stringBuilder.AppendLine($"{new string('_', 100)}");
            stringBuilder.AppendLine();
            OutputWriter.WriteMessageOnNewLine(stringBuilder.ToString());
        }
    }
}
