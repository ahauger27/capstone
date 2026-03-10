using System;

namespace Capstone.Models;

public interface IItem
{
    public string Title { get; set; }
    public string AuthorName { get; set; }
    public Collection Genre { get; set; }
    public Format Format { get; set; }
    public Patron? CurrentBorrower { get; set; }
    public DateTime DueDate { get; set; }
    public CircStatus CircStatus { get; set; }
    public DateTime LastCirculation { get; set; }
    public void SetDueDate()
    {
        
    }
    
}
