﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.GameStore.Common;

namespace Launcher.cs.GameStore.Data.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.Game.TitleMinLength)]
        [MaxLength(ValidationConstants.Game.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(ValidationConstants.Game.VideoIdLength)]
        [MaxLength(ValidationConstants.Game.VideoIdLength)]
        public string VideoId { get; set; }

        [Required]
        public string Image { get; set; }

        // In GB
        public double Size { get; set; }

        public decimal Price { get; set; }

        [Required]
        [MinLength(ValidationConstants.Game.DescriptionMinLength)]
        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<UserGame> Users { get; set; } = new List<UserGame>();
    }
}