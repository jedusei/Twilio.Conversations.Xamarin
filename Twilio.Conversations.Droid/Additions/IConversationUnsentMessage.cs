using System.Threading;
using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public partial interface IConversationUnsentMessage
    {
        public async Task<IMessage> SendAsync(CancellationToken cancellationToken = default)
        {
            AsyncCallbackListener<IMessage> listener = new();
            using var _ = Send(listener).CancelWith(cancellationToken);
            return await listener.GetResultAsync();
        }
    }
}
