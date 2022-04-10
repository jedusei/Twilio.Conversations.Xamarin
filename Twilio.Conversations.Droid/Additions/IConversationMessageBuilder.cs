using System.Threading;
using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public partial interface IConversationMessageBuilder
    {
        public async Task<IMessage> BuildAndSendAsync(CancellationToken cancellationToken = default)
        {
            AsyncCallbackListener<IMessage> listener = new();
            using var _ = BuildAndSend(listener).CancelWith(cancellationToken);
            return await listener.GetResultAsync();
        }
    }
}
