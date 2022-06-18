using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public partial interface IParticipant
    {
        public async Task<IUser> GetAndSubscribeUserAsync()
        {
            AsyncCallbackListener<IUser> listener = new();
            GetAndSubscribeUser(listener);
            return await listener.GetResultAsync();
        }

        public async Task SetAttributesAsync(JsonAttributes attributes)
        {
            AsyncStatusListener listener = new();
            SetAttributes(attributes, listener);
            await listener.Task;
        }

        public async Task RemoveAsync()
        {
            AsyncStatusListener listener = new();
            Remove(listener);
            await listener.Task;
        }
    }
}
