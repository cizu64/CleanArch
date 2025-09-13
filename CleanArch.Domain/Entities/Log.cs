namespace CleanArch.Domain.Entities;
public class Log:BaseEntity
{
    public string Message{get; private set;} //rich entities

    public Log(string message)
    {
        Message = message;
    }
    //behavior
    public void DoSomething()
    {

    }
}