﻿using Fluxor;

namespace blazoract.State.Counter;

[FeatureState]
public class CounterState
{
    public int ClickCount { get; }

    public CounterState() { }
    public CounterState(int clickCount)
    {
        ClickCount = clickCount;
    }
}