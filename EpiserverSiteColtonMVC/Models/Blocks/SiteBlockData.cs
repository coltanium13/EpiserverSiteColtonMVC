﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverSiteColtonMVC.Models.Blocks
{
    /// <summary>
    /// Base class for all block types on the site
    /// </summary>
    public abstract class SiteBlockData : EPiServer.Core.BlockData
    {
    }
}