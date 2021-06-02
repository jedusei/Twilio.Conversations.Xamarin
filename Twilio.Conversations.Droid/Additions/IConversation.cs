using System.Collections.Generic;
using System.Threading.Tasks;

namespace Twilio.Conversations
{
    public partial interface IConversation
    {
        public async Task AddParticipantByAddressAsync(string address, string proxyAddress, JsonAttributes attributes)
        {
            var listener = new AsyncStatusListener();
            AddParticipantByAddress(address, proxyAddress, attributes, listener);
            await listener.Task;
        }

        public async Task AddParticipantByIdentityAsync(string identity, JsonAttributes attributes)
        {
            var listener = new AsyncStatusListener();
            AddParticipantByIdentity(identity, attributes, listener);
            await listener.Task;
        }

        public async Task<long> AdvanceLastReadMessageIndexAsync(long lastReadMessageIndex)
        {
            var listener = new AsyncCallbackListener<Java.Lang.Long>();
            AdvanceLastReadMessageIndex(lastReadMessageIndex, listener);
            return (await listener.GetResultAsync()).LongValue();
        }

        public async Task DestroyAsync()
        {
            var listener = new AsyncStatusListener();
            Destroy(listener);
            await listener.Task;
        }

        public async Task<List<IMessage>> GetLastMessagesAsync(int count)
        {
            var listener = new AsyncCallbackListener<Java.Util.IList>();
            GetLastMessages(count, listener);
            return Utils.ConvertJavaList<IMessage>(await listener.GetResultAsync());
        }

        public async Task<IMessage> GetMessageByIndexAsync(long index)
        {
            var listener = new AsyncCallbackListener<IMessage>();
            GetMessageByIndex(index, listener);
            return await listener.GetResultAsync();
        }

        public async Task<List<IMessage>> GetMessagesAfterAsync(long index, int count)
        {
            var listener = new AsyncCallbackListener<Java.Util.IList>();
            GetMessagesAfter(index, count, listener);
            return Utils.ConvertJavaList<IMessage>(await listener.GetResultAsync());
        }

        public async Task<List<IMessage>> GetMessagesBeforeAsync(long index, int count)
        {
            var listener = new AsyncCallbackListener<Java.Util.IList>();
            GetMessagesBefore(index, count, listener);
            return Utils.ConvertJavaList<IMessage>(await listener.GetResultAsync());
        }

        public async Task<long> GetMessagesCountAsync()
        {
            var listener = new AsyncCallbackListener<Java.Lang.Long>();
            GetMessagesCount(listener);
            return (await listener.GetResultAsync()).LongValue();
        }

        public async Task<long> GetParticipantsCountAsync()
        {
            var listener = new AsyncCallbackListener<Java.Lang.Long>();
            GetParticipantsCount(listener);
            return (await listener.GetResultAsync()).LongValue();
        }

        public async Task<long> GetUnreadMessagesCountAsync()
        {
            var listener = new AsyncCallbackListener<Java.Lang.Long>();
            GetUnreadMessagesCount(listener);
            return (await listener.GetResultAsync()).LongValue();
        }

        public async Task JoinAsync()
        {
            var listener = new AsyncStatusListener();
            Join(listener);
            await listener.Task;
        }

        public async Task LeaveAsync()
        {
            var listener = new AsyncStatusListener();
            Leave(listener);
            await listener.Task;
        }

        public async Task RemoveMessageAsync(IMessage message)
        {
            var listener = new AsyncStatusListener();
            RemoveMessage(message, listener);
            await listener.Task;
        }

        public async Task RemoveParticipantAsync(IParticipant participant)
        {
            var listener = new AsyncStatusListener();
            RemoveParticipant(participant, listener);
            await listener.Task;
        }

        public async Task RemoveParticipantByIdentityAsync(string identity)
        {
            var listener = new AsyncStatusListener();
            RemoveParticipantByIdentity(identity, listener);
            await listener.Task;
        }

        public async Task<IMessage> SendMessageAsync(IMessageOptions options)
        {
            var listener = new AsyncCallbackListener<IMessage>();
            SendMessage(options, listener);
            return await listener.GetResultAsync();
        }

        public async Task<long> SetAllMessagesReadAsync()
        {
            var listener = new AsyncCallbackListener<Java.Lang.Long>();
            SetAllMessagesRead(listener);
            return (await listener.GetResultAsync()).LongValue();
        }

        public async Task<long> SetAllMessagesUnreadAsync()
        {
            var listener = new AsyncCallbackListener<Java.Lang.Long>();
            SetAllMessagesUnread(listener);
            return (await listener.GetResultAsync()).LongValue();
        }

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

        public async Task<long> SetLastReadMessageIndexAsync(long lastReadMessageIndex)
        {
            var listener = new AsyncCallbackListener<Java.Lang.Long>();
            SetLastReadMessageIndex(lastReadMessageIndex, listener);
            return (await listener.GetResultAsync()).LongValue();
        }

        public async Task SetNotificationLevelAsync(ConversationNotificationLevel notificationLevel)
        {
            var listener = new AsyncStatusListener();
            SetNotificationLevel(notificationLevel, listener);
            await listener.Task;
        }

        public async Task SetUniqueNameAsync(string uniqueName)
        {
            var listener = new AsyncStatusListener();
            SetUniqueName(uniqueName, listener);
            await listener.Task;
        }
    }
}