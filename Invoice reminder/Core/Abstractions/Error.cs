namespace Invoice_reminder.Core.Abstractions;

public record Error(string code, string message)
{
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error NullValue = new("Error.NullValue", "Null value was provied");
}

