﻿using Ceras;

namespace H.Formatters;

/// <summary>
/// A formatter that uses <see cref="CerasSerializer"/> inside for serialization/deserialization
/// </summary>
public class CerasFormatter : FormatterBase
{
    private CerasSerializer InternalFormatter { get; } = new CerasSerializer();

    protected override byte[] SerializeInternal(object obj)
    {
        return InternalFormatter.Serialize(obj);
    }

    protected override T DeserializeInternal<T>(byte[] bytes)
    {
        return InternalFormatter.Deserialize<T>(bytes);
    }
}
