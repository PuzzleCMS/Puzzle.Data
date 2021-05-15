using LinqToDB.Mapping;
using Puzzle.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <inheritdoc cref="ILogin"/>
    [Table]
    public class Login : ILogin
    {
        /// <inheritdoc/>
        [Column, PrimaryKey, Identity]
        public Guid UserID { get; set; }

        /// <inheritdoc/>
        [Column(DataType = LinqToDB.DataType.Char, Length = 60)]
        public string PasswordHash { get; set; }
    }
}
