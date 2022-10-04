namespace programbanken
{
    public class SimplerPost
    {
        public int Id { get; set; }

        public string TablaUniqueId { get; set; }

        public int Status { get; set; }

        public DateTime LastChangeTime { get; set; }

        public DateTime? LastPublished { get; set; }

        public TimeSpan? Duration { get; set; }

        public string Permission { get; set; }

        public string PostType { get; set; }

        public string ProgramSeriesTablaId { get; set; }

        public string ProgramSeriesTablaName { get; set; }

        public string Title { get; set; }

        public string AlterativeTitle { get; set; }

        public string MusicList { get; set; }

        public string Description { get; set; }

        public string Text { get; set; }

        public string Transcript { get; set; }

        public List<SimplerAudio> Audios { get; set; }

        public List<SimplerPublication> Publications { get; set; }

        public List<SimplerChildPost> ChildPosts { get; set; }
    }

    public class SimplerChildPost
    {
        public int Id { get; set; }

        public string TablaUniqueId { get; set; }

        public int Status { get; set; }

        public DateTime LastChangeTime { get; set; }

        public DateTime? LastPublished { get; set; }

        public TimeSpan? Duration { get; set; }

        public TimeSpan? StartOffset { get; set; }

        public TimeSpan? EndOffset { get; set; }

        public string Permission { get; set; }

        public string PostType { get; set; }

        public string Title { get; set; }

        public string Paa { get; set; }

        public string Ava { get; set; }

        public string Description { get; set; }

        public string Transcript { get; set; }

        public string Text { get; set; }

    }

    public class SimplerPublication
    {
        public int? TablaProgramServiceId { get; set; }

        public string TablaProgramServiceName { get; set; }

        public string PublicationType { get; set; }

        public DateTime? StartTime { get; set; }
    }

    public class SimplerAudio
    {
        public int AudioId { get; set; }

        public string AudioUrl { get; set; }

        public string AudioDataType { get; set; }

        public string AudioType { get; set; }

        public string AudioQuality { get; set; }
    }

    public class ModifiedPostInfo 
    { 
        public int PostHeaderId { get; set; } 
        public DateTime LastChangeTime { get; set; } 
        public bool IsDeleted { get; set; } 
    }
}
