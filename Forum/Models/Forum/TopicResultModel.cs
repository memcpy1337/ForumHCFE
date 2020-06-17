using System.Collections.Generic;
using ForumHCFE.Models.Post;

namespace ForumHCFE.Models.Forum
{
    public class TopicResultModel
    {
        public ForumListingModel Forum { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
        public string SearchQuery { get; set; }
        public bool EmptySearchResults { get; set; }
    }
}