using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using Puzzle.Core.Interfaces.Data;

namespace Puzzle.Data.Models
{
    /// <inheritdoc cref="IBlog"/>
    [Table]
    public class Blog : IBlog
    {
        /// <inheritdoc/>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <inheritdoc/>
        [Column]
        public string Title { get; set; }

        /// <inheritdoc cref="IBlog.Posts"/>
        [Association(ThisKey = nameof(ID), OtherKey = nameof(Post.BlogID), CanBeNull = true, Relationship = Relationship.OneToMany)]
        public IEnumerable<Post> Posts { get; set; }
        IEnumerable<IPost> IBlog.Posts => Posts;
    }
}
