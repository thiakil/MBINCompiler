﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcWikiTopic : NMSTemplate       // size: 0xD0
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string TopicID;
        /* 0x20 */ public TkTextureResource Icon;
        /* 0xA8 */ public List<GcWikiPage>  Pages;
        [NMS(Size = 0x10)]
        /* 0xB8 */ public string Mission;
        /* 0xC8 */ public bool Seen;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
