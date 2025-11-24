using MessagePackNotFound.CommonLib;

namespace MessagePackNotFound.UserControlsLib;

internal class SomeViewModel
{
    public SomeViewModel()
    {
        var dto = Serializer.Clone(new Dto("Serialized value"));
        Text = $"(De)serialization succeeded: {dto.Value}";
    }

    public string Text { get; }
}