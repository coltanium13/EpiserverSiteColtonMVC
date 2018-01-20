using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer;
using EPiServer.DataAnnotations;

namespace EpiserverSiteColtonMVC.Models.Blocks
{
    /// <summary>
    /// Used to insert a link which is styled as a button
    /// </summary>
    [ContentType(DisplayName = "ButtonBlock", GUID = "742558d5-9df7-4d31-8b28-6973df14a415", Description = "Used to insert a link which is styled as a button")]
    [SiteImageUrl]
    public class ButtonBlock : SiteBlockData
    {
        [Display(Order = 1, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string ButtonText { get; set; }

        [Display(Order = 2, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual Url ButtonLink { get; set; }
    }
}