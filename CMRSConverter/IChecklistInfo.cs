namespace CMRSUtil
{
    public interface IChecklistInfo
    {
        string CKLSource { get; set; }
        string STIGId { get; set; }
        string Version { get; set; }
        string Description { get; set; }
        string Filename { get; set; }
        string Releaseinfo { get; set; }
        string Title { get; set; }
        string Source { get; set; }
        int VulnCount { get; set; }
        bool Transfromed { get; set; }
    }
}