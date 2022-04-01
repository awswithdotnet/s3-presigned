using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class CreateSignedUrlRequest
    {
        public string Content { get; set; }
        
        public double TimeToLiveInHours { get; set; }
    }
}