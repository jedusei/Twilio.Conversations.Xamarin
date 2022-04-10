using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public partial interface IMessage
    {
        public async Task<List<DetailedDeliveryReceipt>> GetDetailedDeliveryReceiptListAsync()
        {
            var listener = new AsyncCallbackListener<Java.Util.IList>();
            GetDetailedDeliveryReceiptList(listener);
            return Utils.ConvertJavaList<DetailedDeliveryReceipt>(await listener.GetResultAsync());
        }

        public async Task<string> GetTemporaryContentUrlsForAttachedMediaAsync(CancellationToken cancellationToken = default)
        {
            var listener = new AsyncCallbackListener<Java.Lang.String>();
            using var _ = GetTemporaryContentUrlsForAttachedMedia(listener).CancelWith(cancellationToken);
            return (await listener.GetResultAsync())?.ToString();
        }

        public async Task<Dictionary<string, string>> GetTemporaryContentUrlsForMediaAsync(IList<IMedia> media, CancellationToken cancellationToken = default)
        {
            AsyncCallbackListener<Java.Util.IMap> listener = new();
            using var _ = GetTemporaryContentUrlsForMedia(media, listener).CancelWith(cancellationToken);
            var map = await listener.GetResultAsync();
            return Utils.ConvertJavaStringMap(map);
        }

        public async Task<Dictionary<string, string>> GetTemporaryContentUrlsForMediaSidsAsync(IList<string> mediaSids, CancellationToken cancellationToken = default)
        {
            AsyncCallbackListener<Java.Util.IMap> listener = new();
            using var _ = GetTemporaryContentUrlsForMediaSids(mediaSids, listener).CancelWith(cancellationToken);
            var map = await listener.GetResultAsync();
            return Utils.ConvertJavaStringMap(map);
        }

        public async Task SetAttributesAsync(JsonAttributes attributes)
        {
            var listener = new AsyncStatusListener();
            SetAttributes(attributes, listener);
            await listener.Task;
        }

        public async Task UpdateBodyAsync(string body)
        {
            var listener = new AsyncStatusListener();
            UpdateBody(body, listener);
            await listener.Task;
        }
    }
}