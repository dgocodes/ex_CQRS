namespace CQRS.Api.Entities
{
    public interface ICommandResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }

    public class CommandResult : ICommandResult
    {
        public CommandResult(bool success, object data)
        {
            Success = success;
            Data = data;
        }

        public CommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

    }
}
