using System.ComponentModel.DataAnnotations;

namespace H5_SSP3_BlazorApp.Data
{
    public class Todo
    {
        [Key]
        public int Id{ get; set; }

        public string Owner { get ; set; }

        public byte[]? Title { get; set; }

        public byte[]? Description { get; set; }

    }

    public class TodoPlain
    {
        [Key]
        public int Id { get; set; }

        public string Owner { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

    }

}
