using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public partial interface IConversationsClient
    {
        public partial interface IConversationBuilder
        {
            public async Task<IConversation> BuildAsync()
            {
                var listener = new AsyncCallbackListener<IConversation>();
                Build(listener);
                return await listener.GetResultAsync();
            }
        }
    }
}