namespace Lab04d_WinFormBasic;

public class PhuongTrinhBacHai
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public PhuongTrinhBacHai(double a, double b, double c = 0)
    {
        A = a; B = b; C = c;
    }

    public string GiaiBacNhat()
    {
        if (A == 0) return B == 0 ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
        return $"Phương trình có nghiệm x = {(-B / A):F2}";
    }

    public string GiaiBacHai()
    {
        if (A == 0) return new PhuongTrinhBacHai(B, C).GiaiBacNhat();

        double delta = B * B - 4 * A * C;
        if (delta < 0) return "Phương trình vô nghiệm";
        if (delta == 0) return $"Phương trình có nghiệm kép x1 = x2 = {(-B / (2 * A)):F2}";

        double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
        double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
        return $"x1 = {x1:F2}; x2 = {x2:F2}";
    }
}