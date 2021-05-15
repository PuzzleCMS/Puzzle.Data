using LinqToDB.Mapping;
using Puzzle.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <inheritdoc cref="IPage"/>
    [Table]
    public class Page : IPage
    {
        /// <inheritdoc/>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <inheritdoc/>
        [Column]
        public string Name { get; set; }

        /// <inheritdoc/>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string HTML { get; set; }

        /// <inheritdoc/>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string CSS { get; set; }

        /// <inheritdoc/>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string JS { get; set; }

        /// <inheritdoc/>
        [Column]
        public Guid? WebsiteID { get; set; }

        /// <inheritdoc/>
        [Column]
        public Guid? ParentPageID { get; set; }

        /// <inheritdoc/>
        [Column]
        public Guid? LayoutID { get; set; }


        /// <inheritdoc cref="IPage.ParentWebsite"/>
        [Association(ThisKey = nameof(WebsiteID), OtherKey = nameof(Website.ID), CanBeNull = false, Relationship = Relationship.ManyToOne)]
        public Website ParentWebsite { get; set; }
        IWebsite IPage.ParentWebsite => ParentWebsite;


        /// <inheritdoc cref="IPage.ParentPage"/>
        [Association(ThisKey = nameof(ParentPageID), OtherKey = nameof(ID), CanBeNull = true, Relationship = Relationship.ManyToOne)]
        public Page ParentPage { get; set; }
        IPage IPage.ParentPage => ParentPage;


        /// <inheritdoc cref="IPage.Pages"/>
        [Association(ThisKey = nameof(ID), OtherKey = nameof(ParentPageID), CanBeNull = true, Relationship = Relationship.OneToMany)]
        public IEnumerable<Page> Pages { get; set; }
        IEnumerable<IPage> IPage.Pages => Pages;

        /// <inheritdoc cref="IPage.Layout"/>
        [Association(ThisKey = nameof(LayoutID), OtherKey = nameof(Models.Layout.ID), CanBeNull = true, Relationship = Relationship.ManyToOne)]
        public Layout Layout { get; set; }
        ILayout IPage.Layout => Layout;

        /// <inheritdoc/>
        [NotColumn]
        public string CombinedHTML => Layout?.HTML?.Replace("<puzzle-render-page/>", HTML) ?? HTML;
    }
}
