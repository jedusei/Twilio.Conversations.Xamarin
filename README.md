# Twilio.Conversations.Xamarin
Xamarin Android and iOS bindings for the Twilio Conversation SDKs.

[![NuGet](https://img.shields.io/nuget/v/Twilio.Conversations.Xamarin.svg)](https://www.nuget.org/packages/Twilio.Conversations.Xamarin/)

## Documentation
General Documentation: https://www.twilio.com/docs/conversations/fundamentals

Android SDK API Reference: https://media.twiliocdn.com/sdk/android/conversations/releases/3.1.0/docs/

iOS SDK API Reference: https://media.twiliocdn.com/sdk/ios/conversations/releases/2.2.2/docs/

## Things to note... 
### Initializing the Conversations Client on Android
In the Twilio Conversations SDK for Android, some types are defined as interfaces, so the Xamarin binding tools generated a corresponding C# interface, prefixing the class name with an "I" to follow C# naming conventions. One example is the ``ConversationsClient`` interface, which is exposed in C# as ``IConversationsClient``.

So, to create a conversations client (for Android), you must call either ``IConversationsClient.Create`` or ``IConversationsClient.CreateAsync``, like this:
```
string token = "<twilio access token>";
var properties = IConversationsClient.ClientProperties.NewBuilder().CreateProperties(); // You can specify some options here; please refer to the API reference for more information.
var conversationsClient = await IConversationsClient.CreateAsync(Application.Context, token, properties);
```

### Build Warnings
Sometimes, when building your Android project after you have included the Twilio.Conversations.Xamarin package, you will see some warnings in the build output window:
```
2>  Warning in obj\Debug\120\lp\7\jl\__reference__kotlinx-coroutines-core-jvm-1.5.0-native-mt.jar:kotlinx/coroutines/debug/AgentPremain.class at Lkotlinx/coroutines/debug/AgentPremain;installSignalHandler()V:
2>  Type `sun.misc.Signal` was not found, it is required for default or static interface methods desugaring of `Lkotlinx/coroutines/debug/AgentPremain;installSignalHandler()V`
2>  Warning in obj\Debug\120\lp\2\jl\okhttp3.jar:okhttp3/internal/platform/ConscryptPlatform$DisabledHostnameVerifier.class:
2>  Type `org.conscrypt.ConscryptHostnameVerifier` was not found, it is required for default or static interface methods desugaring of `okhttp3.internal.platform.ConscryptPlatform$DisabledHostnameVerifier`
2>  Warning in obj\Debug\120\lp\7\jl\__reference__kotlinx-coroutines-core-jvm-1.5.0-native-mt.jar:kotlinx/coroutines/debug/AgentPremain$DebugProbesTransformer.class:
2>  Type `java.lang.instrument.ClassFileTransformer` was not found, it is required for default or static interface methods desugaring of `kotlinx.coroutines.debug.AgentPremain$DebugProbesTransformer`
2>  Warning in obj\Debug\120\lp\7\jl\__reference__kotlinx-coroutines-core-jvm-1.5.0-native-mt.jar:kotlinx/coroutines/debug/AgentPremain.class:
2>  Type `sun.misc.SignalHandler` was not found, it is required for default or static interface methods desugaring of `kotlinx.coroutines.debug.AgentPremain$$InternalSyntheticLambda$1$891f0426260346a275574e647722750dd57e689916032f748a2446a1d638fe03$0`
```

These warnings can be safely ignored; the SDK will still work fine regardless. I haven't figured out a way to hide them yet, but if you do know of a way, you can create a pull request. Thank you!
