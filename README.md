# Twilio.Conversations.Xamarin
Xamarin Android and iOS bindings for the Twilio Conversation SDKs.

[![NuGet](https://img.shields.io/nuget/v/Twilio.Conversations.Xamarin.svg)](https://www.nuget.org/packages/Twilio.Conversations.Xamarin/)

## Documentation
General Documentation: https://www.twilio.com/docs/conversations/fundamentals

Android SDK API Reference: http://media.twiliocdn.com/sdk/android/conversations/releases/1.4.1/docs/

iOS SDK API Reference: http://media.twiliocdn.com/sdk/ios/convo/releases/1.0.0/docs/

## Things to note... 
In the Twilio Conversations SDK for Android, some types are defined as interfaces, so the Xamarin binding tools generated a corresponding C# interface, prefixing the class name with an "I" to follow C# naming conventions. One example is the ``ConversationsClient`` interface, which is exposed in C# as ``IConversationsClient``.

So, to create a conversations client (for Android), you must call either ``IConversationsClient.Create`` or ``IConversationsClient.CreateAsync``, like this:
```
string token = "<twilio access token>";
var properties = IConversationsClient.ClientProperties.NewBuilder().CreateProperties(); // You can specify some options here; please refer to the API reference for more information.
var conversationsClient = await IConversationsClient.CreateAsync(Application.Context, token, properties);
```
