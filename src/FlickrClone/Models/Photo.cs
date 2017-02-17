using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlickrClone.Models
{
    [Table("Photos")]
    public class Photo
    {
        public Photo()
        {
        }
        public Photo(string name, byte[] photoData)
        {
            Name = name;
            Data = photoData;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string getImage()
        {
            // Convert byte data array to string that '<img src=' can read
            var base64File = Convert.ToBase64String(Data);
            return String.Format("data:image/gif;base64,{0}", base64File);
        }
    }
}
