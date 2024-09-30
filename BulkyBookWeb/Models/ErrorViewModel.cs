namespace BulkyBookWeb.Models
{
    //A model represents the shape of data
    //Represent the data being transferred between views and controllers or e.g. a table from a database.
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
