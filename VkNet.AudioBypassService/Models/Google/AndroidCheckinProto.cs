// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: checkin.proto

using System.ComponentModel;
using ProtoBuf;

// ReSharper disable InconsistentNaming

namespace VkNet.AudioBypassService.Models.Google
{
    [ProtoContract]
    public enum DeviceType
    {
        [ProtoEnum(Name = @"DEVICE_ANDROID_OS")]
        DeviceAndroidOs = 1,
        [ProtoEnum(Name = @"DEVICE_IOS_OS")] DeviceIosOs = 2,

        [ProtoEnum(Name = @"DEVICE_CHROME_BROWSER")]
        DeviceChromeBrowser = 3,

        [ProtoEnum(Name = @"DEVICE_CHROME_OS")]
        DeviceChromeOs = 4
    }

    [ProtoContract]
    public class AndroidCheckinProto : IExtensible
    {
        private string __pbn__CellOperator;
        private IExtension __pbn__extensionData;
        private long? __pbn__LastCheckinMsec;
        private string __pbn__Roaming;
        private string __pbn__SimOperator;
        private DeviceType? __pbn__Type;
        private int? __pbn__UserNumber;

        [ProtoMember(2, Name = @"last_checkin_msec")]
        public long LastCheckinMsec
        {
            get => __pbn__LastCheckinMsec.GetValueOrDefault();
            set => __pbn__LastCheckinMsec = value;
        }

        [ProtoMember(6, Name = @"cell_operator")]
        [DefaultValue("")]
        public string CellOperator
        {
            get => __pbn__CellOperator ?? "";
            set => __pbn__CellOperator = value;
        }

        [ProtoMember(7, Name = @"sim_operator")]
        [DefaultValue("")]
        public string SimOperator
        {
            get => __pbn__SimOperator ?? "";
            set => __pbn__SimOperator = value;
        }

        [ProtoMember(8, Name = @"roaming")]
        [DefaultValue("")]
        public string Roaming
        {
            get => __pbn__Roaming ?? "";
            set => __pbn__Roaming = value;
        }

        [ProtoMember(9, Name = @"user_number")]
        public int UserNumber
        {
            get => __pbn__UserNumber.GetValueOrDefault();
            set => __pbn__UserNumber = value;
        }

        [ProtoMember(12, Name = @"type")]
        [DefaultValue(DeviceType.DeviceAndroidOs)]
        public DeviceType Type
        {
            get => __pbn__Type ?? DeviceType.DeviceAndroidOs;
            set => __pbn__Type = value;
        }

        [ProtoMember(13, Name = @"chrome_build")]
        public ChromeBuildProto ChromeBuild { get; set; }

        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        public bool ShouldSerializeLastCheckinMsec()
        {
            return __pbn__LastCheckinMsec != null;
        }

        public void ResetLastCheckinMsec()
        {
            __pbn__LastCheckinMsec = null;
        }

        public bool ShouldSerializeCellOperator()
        {
            return __pbn__CellOperator != null;
        }

        public void ResetCellOperator()
        {
            __pbn__CellOperator = null;
        }

        public bool ShouldSerializeSimOperator()
        {
            return __pbn__SimOperator != null;
        }

        public void ResetSimOperator()
        {
            __pbn__SimOperator = null;
        }

        public bool ShouldSerializeRoaming()
        {
            return __pbn__Roaming != null;
        }

        public void ResetRoaming()
        {
            __pbn__Roaming = null;
        }

        public bool ShouldSerializeUserNumber()
        {
            return __pbn__UserNumber != null;
        }

        public void ResetUserNumber()
        {
            __pbn__UserNumber = null;
        }

        public bool ShouldSerializeType()
        {
            return __pbn__Type != null;
        }

        public void ResetType()
        {
            __pbn__Type = null;
        }
    }
}