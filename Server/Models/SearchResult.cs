using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspCoreServer.Models
{
  public class SearchResult
  {
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Hours { get; set; }
    public string Services { get; set; }
    public string EligibilityRequirements { get; set; }
    public string Website { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
  }
}
