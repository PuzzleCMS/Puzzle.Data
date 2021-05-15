using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// An independent Vue.js control, which
    /// can be referenced and rendered in every entity containing HTML
    /// (including other <see cref="Widget"/>s).
    /// </summary>
    [Table]
    public class Widget
    {
        /// <summary>
        /// ID.
        /// </summary>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <summary>
        /// HTML content of the <see cref="Widget"/>.
        /// </summary>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string HTML { get; set; }

        /// <summary>
        /// CSS content of the <see cref="Widget"/>.
        /// </summary>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string CSS { get; set; }

        /// <summary>
        /// JavaScript content of the <see cref="Widget"/>.
        /// </summary>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string JS { get; set; }
    }
}
