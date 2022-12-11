namespace ConsoleApp1;

/// <summary>
/// 
/// </summary>
public class Node
{
    public Node() { }

    public object? Content { get; set; }

    #region Overrides

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Content?.GetHashCode() ?? 0;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return Content?.ToString() ?? string.Empty;
    }

    #endregion
}
