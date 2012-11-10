using System;
using System.Runtime.Serialization;

namespace SixSteps.Core.Interfaces.Speakers
{
    [DataContract(Name = "Speakers")]
    public class Speaker
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Info")]
        public string Info { get; set; }
        [DataMember(Name = "TalkTitle")]
        public string TalkTitle { get; set; }
        [DataMember(Name = "TalkDescription")]
        public string TalkDescription { get; set; }
        [DataMember(Name = "PictureUrl")]
        public string PictureUrl { get; set; }
        [DataMember(Name = "TalkDate")]
        public DateTime TalkDate { get; set; }
    }
}