using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSiteColtonMVC.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "c1efae11-7bae-432d-8915-e67966a92b8e", Description = "")]
    public class StandardPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The Page Heading.",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}