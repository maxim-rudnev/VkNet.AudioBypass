// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: checkin.proto

using System.ComponentModel;
using ProtoBuf;

// ReSharper disable InconsistentNaming

namespace VkNet.AudioBypassService.Models.Google
{
    [ProtoContract]
    public enum Channel
    {
        [ProtoEnum(Name = @"CHANNEL_STABLE")] ChannelStable = 1,
        [ProtoEnum(Name = @"CHANNEL_BETA")] ChannelBeta = 2,
        [ProtoEnum(Name = @"CHANNEL_DEV")] ChannelDev = 3,
        [ProtoEnum(Name = @"CHANNEL_CANARY")] ChannelCanary = 4,
        [ProtoEnum(Name = @"CHANNEL_UNKNOWN")] ChannelUnknown = 5
    }

    [ProtoContract]
    public enum Platform
    {
        [ProtoEnum(Name = @"PLATFORM_WIN")] PlatformWin = 1,
        [ProtoEnum(Name = @"PLATFORM_MAC")] PlatformMac = 2,
        [ProtoEnum(Name = @"PLATFORM_LINUX")] PlatformLinux = 3,
        [ProtoEnum(Name = @"PLATFORM_CROS")] PlatformCros = 4,
        [ProtoEnum(Name = @"PLATFORM_IOS")] PlatformIos = 5,

        [ProtoEnum(Name = @"PLATFORM_ANDROID")]
        PlatformAndroid = 6
    }

    [ProtoContract]
    public class ChromeBuildProto : IExtensible
    {
        private Channel? __pbn__channel;
        private string __pbn__ChromeVersion;
        private IExtension __pbn__extensionData;
        private Platform? __pbn__platform;

        [ProtoMember(1)]
        [DefaultValue(Platform.PlatformWin)]
        public Platform platform
        {
            get => __pbn__platform ?? Platform.PlatformWin;
            set => __pbn__platform = value;
        }

        [ProtoMember(2, Name = @"chrome_version")]
        [DefaultValue("")]
        public string ChromeVersion
        {
            get => __pbn__ChromeVersion ?? "";
            set => __pbn__ChromeVersion = value;
        }

        [ProtoMember(3)]
        [DefaultValue(Channel.ChannelStable)]
        public Channel channel
        {
            get => __pbn__channel ?? Channel.ChannelStable;
            set => __pbn__channel = value;
        }

        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        public bool ShouldSerializeplatform()
        {
            return __pbn__platform != null;
        }

        public void Resetplatform()
        {
            __pbn__platform = null;
        }

        public bool ShouldSerializeChromeVersion()
        {
            return __pbn__ChromeVersion != null;
        }

        public void ResetChromeVersion()
        {
            __pbn__ChromeVersion = null;
        }

        public bool ShouldSerializechannel()
        {
            return __pbn__channel != null;
        }

        public void Resetchannel()
        {
            __pbn__channel = null;
        }
    }
}