// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Addresses.Cities;
using Addresses.States;
using DevOps.Code.Entities.Interfaces.StaticEntity;
using Position = ProtoBuf.ProtoMemberAttribute;
using ProtoBufSerializable = ProtoBuf.ProtoContractAttribute;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace Addresses.StateCities
{
    /// <summary>Contains US State-City pair component of addresses</summary>
    [ProtoBufSerializable]
    [Table("StateCities", Schema = "Addresses")]
    public class StateCity : IStaticEntity<StateCity, int>
    {
        public StateCity()
        {
        }

        public StateCity(State state, City city)
        {
            City = city;
            State = state;
        }

        /// <summary>Contains City reference</summary>
        [Position(3)]
        public City City { get; set; }

        /// <summary>Contains City foreign key</summary>
        [Position(2)]
        public int CityId { get; set; }

        /// <summary>Contains State reference</summary>
        [Position(5)]
        public State State { get; set; }

        /// <summary>StateCity unique identifier (primary key)</summary>
        [Key]
        [Position(1)]
        public int StateCityId { get; set; }

        /// <summary>Contains State foreign key</summary>
        [Position(4)]
        public int StateId { get; set; }

        /// <summary>Returns a value that uniquely identifies this entity type. Each entity type in the model has a unique identifier</summary>
        public int GetEntityType() => 9;

        /// <summary>Returns the entity's unique identifier</summary>
        public int GetKey() => StateCityId;

        /// <summary>Returns an expression defining this entity's unique index (alternate key)</summary>
        public Expression<Func<StateCity, object>> GetUniqueIndex() => entity => new { entity.CityId, entity.StateId };
    }
}
