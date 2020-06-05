using System;
using Microsoft.AspNetCore.Http;

namespace DataApp.API.Dtos
{
    public class PhotoForCreationDto
    {
     public int Id { get; set; }
     public string Url { get; set; }
     public IFormFile File { get; set; }
     public DateTime DateAdded { get; set; }
     public string PublicId { get; set; }
     public bool IsMain { get; set; }

     public PhotoForCreationDto()
     {
         DateAdded = DateTime.Now;
     }
    }
}