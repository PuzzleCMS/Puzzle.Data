using LinqToDB.Mapping;
using Puzzle.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <inheritdoc cref="IWebsite"/>
    [Table]
    public class Website : IWebsite
    {
        /// <inheritdoc/>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <inheritdoc/>
        [Association(ThisKey = nameof(ID), OtherKey = nameof(Page.WebsiteID), CanBeNull = true, Relationship = Relationship.OneToMany)]
        public IEnumerable<Page> Pages { get; set; }
        IEnumerable<IPage> IWebsite.Pages => Pages;

        /// <inheritdoc/>
        [Column]
        public string RootPath { get; set; }

        /// <inheritdoc/>
        [Column]
        public string APIPath { get; set; }

        /// <inheritdoc/>
        [Column]
        public bool HeadlessMode { get; set; }
    }
}
