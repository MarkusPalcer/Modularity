using JetBrains.Annotations;

namespace MarkusPalcer.Modularity;

public interface IFactory;

[UsedImplicitly(ImplicitUseTargetFlags.WithInheritors)]
public interface IFactory<in TIn, out T> : IFactory
{
    T Create(TIn param);
}

[UsedImplicitly(ImplicitUseTargetFlags.WithInheritors)]
public interface IFactory<in TIn1, in TIn2, out T> : IFactory
{
    T Create(TIn1 param1, TIn2 param2);
}