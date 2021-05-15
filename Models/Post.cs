using LinqToDB.Mapping;
using Puzzle.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <inheritdoc cref="IPost"/>
    [Table]
    public class Post : IPost
    {
        /// <inheritdoc/>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <inheritdoc/>
        [Column]
        public string HTML { get; set; }

        /// <inheritdoc/>
        [Column]
        public Guid BlogID { get; set; }

        /// <inheritdoc cref="IPost.ParentBlog"/>
        [Association(ThisKey = nameof(BlogID), OtherKey = nameof(Blog.ID), CanBeNull = false, Relationship = Relationship.ManyToOne)]
        public Blog ParentBlog { get; set; }
        IBlog IPost.ParentBlog => ParentBlog;
    }
}
