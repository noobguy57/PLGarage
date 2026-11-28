using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GameServer.Models.PlayerData
{
    [Index(nameof(PlayerId), nameof(CreatedAt))]
    [Index(nameof(PlayerCreationId))]
    public class PlayerAchievement
    {
        [Key]
        public int Id { get; set; }

        public int PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public User Player { get; set; }

        public int TypeId { get; set; }

        public int? Value { get; set; }

        public int? PlayerCreationId { get; set; }

        public bool HasRead { get; set; }
        public bool Relevant { get; set; } = true;

        public Platform Platform { get; set; } = Platform.PS3;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}