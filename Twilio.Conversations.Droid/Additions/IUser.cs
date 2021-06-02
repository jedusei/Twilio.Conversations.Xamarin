using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public partial interface IUser
    {
        public async Task SetAttributesAsync(JsonAttributes attributes)
        {
            var listener = new AsyncStatusListener();
            SetAttributes(attributes, listener);
            await listener.Task;
        }

        public async Task SetFriendlyNameAsync(string friendlyName)
        {
            var listener = new AsyncStatusListener();
            SetFriendlyName(friendlyName, listener);
            await listener.Task;
        }
    }
}