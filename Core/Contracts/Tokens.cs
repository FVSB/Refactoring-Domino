namespace Game;
/// <summary>
///  All objects that implement it must have a component value.
/// </summary>
/// <param name=""></param>
/// <returns></returns>
public interface ITokenizable : IComparable<ITokenizable>, IEquatable<ITokenizable>, IDescriptible
{
    string Paint();
    /// <summary>
    ///  Eigenvalue of object that is due to internal characteristics
    /// </summary>
    /// <param name=""></param>
    /// <returns></returns>
    double ComponentValue { get; }

}
/// <summary>
///  Generates tokens under internal criteria
/// </summary>
/// <param name=""></param>
/// <returns></returns>

public interface IGenerator : IDescriptible
{
    /// <summary>
    ///  Returns a list of tokens with a double max between the two parts
    /// </summary>
    /// <param name=""></param>
    /// <returns></returns>
    public List<IToken> CreateTokens(int maxDouble);
}





/// <summary>
///  It is a token that contains two parts where these two parts must be ITokenizable objects
/// </summary>
/// <param name=""></param>
/// <returns></returns>
public interface IToken
{
    ITokenizable Part1 { get; }
    ITokenizable Part2 { get; }

    IToken Clone();

    void SwapToken();

    string ToString();
}
/// <summary>
///  Manage from the creation to the distribution of the tokens
/// </summary>
/// <param name=""></param>
/// <returns></returns>
public interface ITokensManager
{
    List<IToken> Elements { get; }
    IEqualityComparer<IToken> equalityComparer { get; }

    /// <summary>
    ///  Distribute the tokens under a given criteria
    /// </summary>
    /// <param name=""></param>
    /// <returns></returns>
    HashSet<IToken> GetTokens();

}

