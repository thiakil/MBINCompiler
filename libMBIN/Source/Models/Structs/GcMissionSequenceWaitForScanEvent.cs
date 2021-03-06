﻿namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x228, Alignment = 0x8)]
    public class GcMissionSequenceWaitForScanEvent : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string GalaxyMapMessage;
        [NMS(Size = 0x20)]
        /* 0x100 */ public string Event;
        /* 0x120 */ public float Timeout;
        /* 0x124 */ public bool DistanceTimeout;
        [NMS(Size = 0x80)]
        /* 0x125 */ public string TimeoutOSD;
        [NMS(Size = 0x80)]
        /* 0x1A5 */ public string DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x225 */ public byte[] EndPadding;
    }
}
