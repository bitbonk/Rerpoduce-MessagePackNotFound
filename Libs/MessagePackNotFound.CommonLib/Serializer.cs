using MessagePack;

namespace MessagePackNotFound.CommonLib;

/// <summary>
///     A serialization abstraction that hides that MessagePack is used.
/// </summary>
public static class Serializer
{
    public static T Clone<T>(T source, CancellationToken cancellationToken = default)
        where T : notnull
    {
        // serialize request to typeless
        byte[] serializedSource = MessagePackSerializer.Typeless.Serialize(
            source,
            MessagePackSerializer.Typeless.DefaultOptions,
            cancellationToken);

        // deserialize to TRequest with typeless
        object? deserializedSource = MessagePackSerializer.Typeless.Deserialize(
            serializedSource,
            MessagePackSerializer.Typeless.DefaultOptions,
            cancellationToken);

        return (T)deserializedSource!;
    }
}