namespace CMRSUtil
{
    public interface ICMRSConverter
    {

        IChecklistInfo CheckListInfo { get; }

        ICMRSInfo CMRSInfomation { get; }

        string Export();

        void Transform();

        void LoadCKL(string CKLXMLContent);

        void LoadBenchmark(string XCCDFXMLContent);

    }
}
