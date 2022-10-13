using System.Runtime.Serialization;

namespace laba_6;

[Serializable]
public class NegativeDivision : Exception
{
    public int Value { get;}

    public NegativeDivision() : base("Negative Result!") { }
    public NegativeDivision(string? message, int val) : base(message){ Value = val; }
}
public class ZeroResult : Exception
{
    public int Value { get;}
    public ZeroResult() : base("RESULT = 0") {}
    public ZeroResult(string? message, int val) : base(message){Value = val; }
}


public class InventoryException : Exception
{
    public string ClassError { get; }

    public InventoryException(string? message, string classError) : base(message)
    {
        ClassError = classError;
    }
}

public class BallException : InventoryException
{
    public string BallTypeException { get; set; }
    public BallException(string? message, string classError) : base(message, "Ball"){}
}

public class CostException : InventoryException
{
    public int Cost { get; set; }
    public CostException(string? message, string classError, int cost) : base(message, classError) { Cost = cost; }
}
