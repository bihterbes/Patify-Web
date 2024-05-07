using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Patify.Models
{
    public class Advert
    {
        public int AdvertId { get; set; }

        [Required]
        public string Header { get; set; }

        [Required]
        public string Description { get; set; }

        public string AnimalName { get; set; }

        public int AnimalAge { get; set; }

        [Required]
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        public string AnimalRace { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public SizeOfAnimal? SizeOfAnimal { get; set; }

        public FromWho? FromWho { get; set; }

        public string Photo { get; set; }

        public bool Publish { get; set; } = false;
    }

    public enum Gender
    {
        Disi,
        Erkek,
        Bilinmiyor
    }
    public enum SizeOfAnimal
    {
        Kucuk,
        Orta,
        Buyuk
    }
    public enum FromWho
    {
        Sahibinden,
        Barinaktan,
        Sokak,
        Veteriner,
        GeciciEv
    }
}
