﻿using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcBaseBuildingTable : NMSTemplate
    {
        /* 0x000 */ public TkModelResource LegModel;
        /* 0x084 */ public TkModelResource BaseRadiusModel;
        /* 0x108 */ public TkModelResource SnapPointValid;
        /* 0x18C */ public TkModelResource SnapPointInvalid;
        /* 0x210 */ public TkModelResource SnapPointFar;

        /* 0x298 */ public List<GcBaseBuildingEntry> Objects;
        /* 0x2A8 */ public List<GcBaseBuildingGroup> Groups;
        /* 0x2C0 */ public List<GcBaseBuildingPalette> Palettes;
        /* 0x4C0 */ public GcBaseBuildingProperties Properties;
    }
}
