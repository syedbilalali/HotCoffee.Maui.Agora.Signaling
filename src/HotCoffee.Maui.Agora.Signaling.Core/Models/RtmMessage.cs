namespace HotCoffee.Maui.Agora.Signaling.Core.Models
{
    public sealed record RtmMessage(
    string Channel,
    string PublisherId,
    string Payload
    );
}
