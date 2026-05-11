using TargetProject.Practice;
namespace TestProject.Practice;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// [DataTestMethod]/[DataRow]属性の利用
/// </summary>
[TestClass]
public class CalculatorDataRowTests
{
    private static TestContext? context;
    [ClassInitialize]
    /// <summary>
    /// すべてのテスト前に1度だけ実行する
    /// </summary>
    /// <param name="context"></param>
    public static void ClassSetup(TestContext _context)
    {
        context = _context;
        context.WriteLine($"ClassSetup:{context.TestName}のテストを開始します。");
    }

    [ClassCleanup]
    /// <summary>
    /// すべてのテスト後に1度だけ実行する
    /// </summary>
    /// <param name="context"></param>
    public static void ClassCleanup()
    {
        context!.WriteLine($"ClassCleanup:{context.TestName}のテストを終了しました。");
    }


    /// <summary>
    /// テストターゲットのCalculatorを格納するフィールド
    /// </summary>
    private Calculator? calculator;
    [TestInitialize]
    /// <summary>
    /// テストメソッド実行前処理
    /// </summary>
    public void SetUp()
    {
        // Arrange（準備）
        // テスト対象のオブジェクトを生成する
        calculator = new Calculator();
    }

    [DataTestMethod]
    [DataRow(10, 5, 2, DisplayName = "テストケース1:10 ÷ 5 = 2")]
    [DataRow(10, 3, 3, DisplayName = "テストケース2:10 ÷ 3 = 3")]


    /// <summary>
    /// CalculatのDivメソッドの単体テスト
    /// </summary>
    /// <param name="x">[DataRow]属性の先頭の値</param>
    /// <param name="y">[DataRow]属性の2番目の値</param>
    /// <param name="expected">[DataRow]属性の3番目の値</param>
    public void Div_ShouldReturnQuotient_WhenDivisible(int x, int y, int expected)
    {
        // Act（実行）
        // テスト対象のメソッドを実行する
        var result = calculator!.Div(x, y);
        // Assert（確認）
        // 実行結果が期待した値と一致するか確認する
        Assert.AreEqual(expected, result);
    }

    [ExpectedException(typeof(ArgumentException))]
    [DataTestMethod]
    [DataRow(10, 0, DisplayName = "テストケース3:10 ÷ 0 = ArgumentException")]
    [DataRow(20, 0, DisplayName = "テストケース4:20 ÷ 0 = ArgumentException")]

    /// <summary>
    /// CalculatのDivメソッドの単体テスト
    /// ArgumentExceptionがスローされることをテストする
    /// </summary>
    /// <param name="x">[DataRow]属性の先頭の値</param>
    /// <param name="y">[DataRow]属性の2番目の値</param>
    public void Div_ShouldThrowArgumentException_WhenDivisible(int x, int y)
    {
        // Act（実行）
        // テスト対象のメソッドを実行する
        calculator!.Div(x, y);
    }


    public void Add_ReturnsExpectedResult(int? x, int? y, int? expected)
    {
        // Act（実行）
        // テスト対象のメソッドを実行する
        var result = calculator!.Add(x, y);

        // Assert（確認）
        // 実行結果が期待した値と一致するか確認する
        Assert.AreEqual(expected, result);
    }
}