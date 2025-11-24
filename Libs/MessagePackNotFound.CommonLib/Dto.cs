using MessagePack;

namespace MessagePackNotFound.CommonLib;

/// <summary>
///     Some DTO with some MessagePack customization that will be serialized and deserialized.
/// </summary>
// [MessagePackObject(AllowPrivate = true)] // TODO this attribute will trigger source generation which then breaks the build
internal class Dto
{
    public Dto()
    {
        Value = string.Empty;
        Foo = string.Empty;
    }
    
    [SerializationConstructor]
    internal Dto(string value)
    {
        Value = value;
        Foo = string.Empty;
    }

    [Key(0)]
    public string Value { get; }

    [IgnoreMember] public string Foo { get; set; }
}