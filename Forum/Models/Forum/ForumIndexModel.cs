using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumHCFE.Models.Forum
{
    public class ForumIndexModel
    {
        public int NumberOfForums { get; set; }
        public IEnumerable<ForumListingModel> ForumList { get; set; }
    }
      

}
