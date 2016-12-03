using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ArtesaniasMombacho.Models
{
    public class Image
    {

        public int ImageId { get; set; }
        [StringLength(500)]
        public string ImageName { get; set; }
        public FileType FileType { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}