using System;

namespace Runner
{
    public interface ISequenceAnalysis : IDisposable
    {
        string Call(string input);
    }
}
