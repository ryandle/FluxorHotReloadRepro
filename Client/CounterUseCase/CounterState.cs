﻿namespace BlazorHotReloadRepro.Client.CounterUseCase
{
    using Fluxor;

    [FeatureState]
    public class CounterState
    {
        public int ClickCount { get; }

        private CounterState() { } // Required for creating initial state

        public CounterState(int clickCount)
        {
            ClickCount = clickCount;
        }
    }

}
