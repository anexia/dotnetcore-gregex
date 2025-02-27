using CsCheck;

namespace Anexia.Gregex.Test;

public class MatcherTest
{
    [Theory]
    [MemberData(nameof(MatcherTestData.FindMatches), MemberType = typeof(MatcherTestData))]
    public void FindMatches(Matcher<int> matcher, IGregex<int> exp, IEnumerable<int> elements,
        IEnumerable<Match<int>> expectedMatches)
    {
        var actualMatches = matcher.FindMatches(exp, elements);

        Assert.Equal(expectedMatches, actualMatches);
    }

    [Theory]
    [MemberData(nameof(MatcherTestData.MatcherExecutesExpressionWithoutErrorsExamples),
        MemberType = typeof(MatcherTestData))]
    public void MatcherExecutesExpressionWithoutErrors(Matcher<string> matcher,
        Gen<(IGregex<string> Expression, IEnumerable<string> List)> expressionsAndLists)
    {
        expressionsAndLists.Sample(expAndList =>
            _ = matcher.FindMatches(expAndList.Expression, expAndList.List).ToArray());
    }
}