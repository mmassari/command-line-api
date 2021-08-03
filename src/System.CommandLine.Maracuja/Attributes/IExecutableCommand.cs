namespace System.CommandLine.Maracuja
{
    public interface IExecutableCommand
    {
        bool Init();

        int Execute();
    }

    public abstract class ExecutableCommandBase : IExecutableCommand
    {
        public Exception LastError { get; private set; }
        public abstract int Execute();

        public virtual bool Init()
        {
            return true;
        }

        protected bool SetLastError(string message)
        {
            return SetLastError(new ApplicationException(message));
        }
        protected bool SetLastError(Exception exception)
        {
            LastError = exception;
            return false;
        }
    }
}