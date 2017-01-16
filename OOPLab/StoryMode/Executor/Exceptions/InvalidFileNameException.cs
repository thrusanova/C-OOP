
namespace Executor.Exceptions
{

 
    public  class InvalidFileNameException: System.Exception
    {
        private const string ForbiddenSymbolsContainedInName = "The given name contains symbols that are not allowed to be used in names of files or folders.";
        public InvalidFileNameException()
        {

        }

        public InvalidFileNameException(string message)
            : base(ForbiddenSymbolsContainedInName)
        {

        }
    }
}
