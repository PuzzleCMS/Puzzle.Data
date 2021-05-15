using LinqToDB.Mapping;
using Puzzle.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <inheritdoc cref="IUser"/>
    [Table]
    public class User : IUser
    {
        /// <inheritdoc/>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <inheritdoc/>
        [Column]
        public string Email { get; set; }

        /// <inheritdoc/>
        [Column]
        public string DisplayName { get; set; }

        /// <inheritdoc/>
        [Column]
        public Guid UserGroupID { get; set; }

        /// <inheritdoc cref="IUser.ParentUserGroup"/>
        [Association(ThisKey = nameof(UserGroupID), OtherKey = nameof(UserGroup.ID), CanBeNull = true, Relationship = Relationship.ManyToOne)]
        public UserGroup ParentUserGroup { get; set; }
        IUserGroup IUser.ParentUserGroup => ParentUserGroup;

        /// <inheritdoc cref="IUser.Login"/>
        [Association(ThisKey = nameof(ID), OtherKey = nameof(Models.Login.UserID), CanBeNull = true, Relationship = Relationship.OneToOne)]
        public Login Login { get; set; }
        ILogin IUser.Login => Login;
    }
}
