using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatBlog.Core.entities;

internal class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Urlslug { get; set; }
    public string ìmageUrl { get; set; }
    public DateTime JoinedDate { get; set; }
    public string Email { get; set; }
    public string Notes { get; set; }
    public IList<post> Posts { get; set; }
}
