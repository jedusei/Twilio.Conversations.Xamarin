using System.Threading;
using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public partial interface IMedia
    {
        public async Task<string> GetTemporaryContentUrlAsync(CancellationToken cancellationToken = default)
        {
            var listener = new AsyncCallbackListener<Java.Lang.String>();
            using var _ = GetTemporaryContentUrl(listener).CancelWith(cancellationToken);
            return (await listener.GetResultAsync())?.ToString();
        }
    }
}