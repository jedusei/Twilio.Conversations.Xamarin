using System.Collections.Generic;
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
        public async Task<string> GetMediaContentTemporaryUrlAsync()
        {
            var listener = new AsyncCallbackListener<Java.Lang.String>();
            GetMediaContentTemporaryUrl(listener);
            return (string)await listener.GetResultAsync();
        }

        public async Task SetAttributesAsync(JsonAttributes attributes)
        {
            var listener = new AsyncStatusListener();
            SetAttributes(attributes, listener);
            await listener.Task;
        }

        public async Task UpdateMessageBodyAsync(string body)
        {
            var listener = new AsyncStatusListener();
            UpdateMessageBody(body, listener);
            await listener.Task;
        }
    }
}