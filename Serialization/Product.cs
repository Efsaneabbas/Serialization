using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [ Serializable]
    class Product : ISerializable
     {

        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void GetObjectData( SerializationInfo info, StreamingContext context)
        {
            info.AddValue("id", Id);
            info.AddValue("name", Name);    
            info.AddValue("description", Description);
        }

        public override string ToString()
        {
            return $" {Id} - {Name}- {Description}";
        }
    }
}
