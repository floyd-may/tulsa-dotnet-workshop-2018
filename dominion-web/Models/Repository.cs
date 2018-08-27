using System.Collections.Generic;
using System.Linq;

namespace dominion_web.Models
{
    public class Repository
    {
        public string Name { get; set; }
        public IEnumerable<string> Files { get; set; }
        
        public bool IsCsharpProject
        {
            get
            {
                return Files.Any(x => x.EndsWith(".cs"));
            }
        }

        //public IEnumerable<IProject> Projects { get; set; }
    }
}