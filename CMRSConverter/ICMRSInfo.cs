namespace CMRSUtil
{
    public interface ICMRSInfo
    {
        string CMRSSource { get; set; }
        string AssetName { get; set; }
        string AssetIP { get; set; }
        string AssetMAC { get; set; }
        string AssetFQDN { get; set; }
        System.Collections.Generic.IEnumerable<StigTarget> STIGTargets { get; set; }
    }
}