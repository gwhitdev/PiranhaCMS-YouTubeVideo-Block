// CREATED BY github.com/gwhitdev 

using Piranha.Extend;
using Piranha.Extend.Fields;

namespace <ADDYOURNAMESPACE>.Models.Blocks
{
    [BlockType(Name = "YouTube Video", Category = "Media", Icon = "fab fa-youtube")]
    public class YoutubeBlock : Block
    {
        [Field(Title="YouTube video link URL: ")]
        public  StringField YouTubeVideoUrl { get; set; }
    }
}

