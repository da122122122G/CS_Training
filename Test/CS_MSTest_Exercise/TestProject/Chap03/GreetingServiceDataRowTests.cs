using TargetProject.Chap02;
namespace TestProject.Chap03;
/// <summary>
/// 演習-04 GreetServiceのGtree()メソッドのユニットテストドライバ
/// テスト用属性の利用
/// </summary>
[TestClass]
public class GreetingServiceDataRowTests
{
    private GreetingService _service = null!;


    [TestInitialize]
    public void Setup()
    {
        _service = new GreetingService();
    }
    /// <summary>
    /// DataRowで指定した時刻(hour)ごとに、期待する挨拶文が返ることを確認する
    /// </summary>
    /// <param name="hour">入力時刻</param>
    /// <param name="expected">期待する挨拶文</param>
    [DataTestMethod]
    [DataRow(8, "Good Morning", DisplayName = "朝の時間帯(代表値)ではGood Morningを返す")]
    [DataRow(6, "Good Night", DisplayName = "6時は朝に含まれずGood Nightを返す")]
    [DataRow(7, "Good Morning", DisplayName = "7時は朝の開始としてGood Morningを返す")]
    [DataRow(11, "Good Morning", DisplayName = "11時は朝の終了としてGood Morningを返す")]
    [DataRow(12, "Hello", DisplayName = "12時は昼としてHelloを返す")]
    [DataRow(13, "Hello", DisplayName = "昼の時間帯(代表値)ではHelloを返す")]
    [DataRow(17, "Hello", DisplayName = "17時は昼の終了としてHelloを返す")]
    [DataRow(18, "Good Evening", DisplayName = "18時は夕方としてGood Eveningを返す")]
    [DataRow(19, "Good Evening", DisplayName = "夕方の時間帯(代表値)ではGood Eveningを返す")]
    [DataRow(20, "Good Evening", DisplayName = "20時は夕方の終了としてGood Eveningを返す")]
    [DataRow(21, "Good Night", DisplayName = "21時は夕方に含まれずGood Nightを返す")]
    [DataRow(0, "Good Night", DisplayName = "0時は深夜としてGood Nightを返す")]
    [DataRow(23, "Good Night", DisplayName = "23時は深夜としてGood Nightを返す")]
    public void Greet_ReturnsExpectedMessage(int hour, string expected)
    {
        var result = _service.Greet(hour);
        Assert.AreEqual(expected, result);
    }

}
