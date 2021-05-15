using LinqToDB.Mapping;
using Puzzle.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <inheritdoc cref="ILayout"/>
    [Table]
    public class Layout : ILayout
    {
        /// <inheritdoc/>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <inheritdoc/>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string HTML { get; set; }

        /// <inheritdoc/>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string CSS { get; set; }

        /// <inheritdoc/>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string JS { get; set; }
    }
}
