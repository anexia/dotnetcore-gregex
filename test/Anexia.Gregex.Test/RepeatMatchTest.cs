// ------------------------------------------------------------------------------------------
//  <copyright file = "RepeatMatchTest.cs" company = "ANEXIA® Internetdienstleistungs GmbH">
//  Copyright (c) ANEXIA® Internetdienstleistungs GmbH. All rights reserved.
//  </copyright>
// ------------------------------------------------------------------------------------------


namespace Anexia.Gregex.Test;

public sealed class RepeatMatchTest
{
    [Theory]
    [MemberData(nameof(RepeatMatchTestData.IsCompletableExamples), MemberType = typeof(RepeatMatchTestData))]
    public void IsCompletable(IMatch<bool> match, bool isCompletable)
    {
        var actualIsCompletable = match.IsCompletable();
        
        Assert.Equal(isCompletable, actualIsCompletable);
    }

    [Theory]
    [MemberData(nameof(RepeatMatchTestData.FinishExamples), MemberType = typeof(RepeatMatchTestData))]
    public void Finish(IMatch<bool> match, Match<bool> expectedMatch)
    {
        var actualMatch = match.Finish();
        
        Assert.Equal(expectedMatch, actualMatch);
    }

    [Theory]
    [MemberData(nameof(RepeatMatchTestData.IsExtendableExamples), MemberType = typeof(RepeatMatchTestData))]
    public void IsExtendable(IMatch<bool> match, bool element, bool expectedIsExtendable)
    {
        var actualIsExtendable = match.IsExtendable(element);
        
        Assert.Equal(expectedIsExtendable, actualIsExtendable);
    }

    [Theory]
    [MemberData(nameof(RepeatMatchTestData.ExtendExamples), MemberType = typeof(RepeatMatchTestData))]
    public void Extend(IMatch<bool> match, bool element, IEnumerable<IMatch<bool>> expectedMatch)
    {
        var actualMatch = match.Extend(element);
        
        Assert.Equal(expectedMatch, actualMatch);
    }
}