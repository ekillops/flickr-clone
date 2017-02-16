using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }

        public string getImage()
        {
            // Convert byte data array to string that '<img src=' can read
            var base64File = Convert.ToBase64String(Data);
            return String.Format("data:image/gif;base64,{0}", base64File);
        }
    }
}
