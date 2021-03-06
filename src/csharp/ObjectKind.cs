﻿/*
 * Copyright © Michael Taylor (P3Net)
 * All Rights Reserved
 * For changes from C++ to C# and .NET.
 *
 * http://www.michaeltaylorp3.net
 */
/****************************************
Daggorath PC-Port Version 0.2.1
Richard Hunerlach
November 13, 2002

The copyright for Dungeons of Daggorath
is held by Douglas J. Morgan.
(c) 1982, DynaMicro
*****************************************/
using System;

namespace DoD
{    
    /// <summary>Defines the different kinds of objects.</summary>
    public enum ObjectKind
    {
        //TODO: Fix names
        ObjSwordWood = 17,
        ObjSwordIron = 13,
        ObjSwordElvish = 2,

        ObjShieldLeather = 16,
        ObjShieldBronze = 11,
        ObjShieldMithril = 3,

        ObjScrollSeer = 4,
        ObjScrollVision = 7,

        ObjRingJoule = 1,
        ObjRingEnergy = 19, // incanted
        ObjRingRime = 6,
        ObjRingIce = 20, // incanted
        ObjRingVulcan = 12,
        ObjRingFire = 21, // incanted
        ObjRingSupreme = 0,
        ObjRingFinal = 18, // incanted
        ObjRingGold = 22,

        ObjFlaskThews = 5,
        ObjFlaskAbye = 8,
        ObjFlaskHale = 9,
        ObjFlaskEmpty = 23,

        ObjTorchSolar = 10,
        ObjTorchLunar = 14,
        ObjTorchPine = 15,
        ObjTorchDead = 24,

        ObjtFlask = 0,
        ObjtRing = 1,
        ObjtScroll = 2,
        ObjtShield = 3,
        ObjtWeapon = 4,
        ObjtTorch = 5,
    }     
}