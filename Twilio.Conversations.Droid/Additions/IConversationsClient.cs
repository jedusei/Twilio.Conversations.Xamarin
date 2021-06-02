using Android.Content;
using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public partial interface IConversationsClient
    {
        public static async Task<IConversationsClient> CreateAsync(Context context, string token, IConversationsClientProperties properties)
        {
            var listener = new AsyncCallbackListener<IConversationsClient>();
            Create(context, token, properties, listener);
            return await listener.GetResultAsync();
        }

        public async Task<IConversation> CreateConversationAsync(string friendlyName)
        {
            var listener = new AsyncCallbackListener<IConversation>();
            CreateConversation(friendlyName, listener);
            return await listener.GetResultAsync();
        }

        public async Task<IUser> GetAndSubscribeUserAsync(string identity)
        {
            var listener = new AsyncCallbackListener<IUser>();
            GetAndSubscribeUser(identity, listener);
            return await listener.GetResultAsync();
        }

        public async Task<IConversation> GetConversationAsync(string conversationSidOrUniqueName)
        {
            var listener = new AsyncCallbackListener<IConversation>();
            GetConversation(conversationSidOrUniqueName, listener);
            return await listener.GetResultAsync();
        }

        public async Task RegisterFCMTokenAsync(ConversationsClientFCMToken token)
        {
            var listener = new AsyncStatusListener();
            RegisterFCMToken(token, listener);
            await listener.Task;
        }

        public async Task UnegisterFCMTokenAsync(ConversationsClientFCMToken token)
        {
            var listener = new AsyncStatusListener();
            UnregisterFCMToken(token, listener);
            await listener.Task;
        }

        public async Task UpdateTokenAsync(string token)
        {
            var listener = new AsyncStatusListener();
            UpdateToken(token, listener);
            await listener.Task;
        }
    }
}