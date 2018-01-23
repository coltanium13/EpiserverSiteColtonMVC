using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EpiserverSiteColtonMVC.Models.Blocks
{
    [ContentType(DisplayName = "TeaserBlock", GUID = "c933b566-da5d-4893-99ea-1706882399d1", Description = "Add Banners or Images")]
    [SiteImageUrl]
    public class TeaserBlock : SiteBlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.Textarea)]
        public virtual string Text { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [UIHint(UIHint.Image)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual ContentReference Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual PageReference Link { get; set; }
    }
}