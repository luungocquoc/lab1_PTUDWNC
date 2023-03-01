using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatBlog.Core.entities;

internal class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Urlslsug { get; set; }
    public string Description { get; set; }
    public IList<post> Posts { get; set; }
}
