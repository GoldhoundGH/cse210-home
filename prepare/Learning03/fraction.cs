public class Fraction
{
    private int _numer;
    private int _denom;

    public Fraction()
    {
        _numer = 1;
        _denom = 1;
    }

    public Fraction(int number)
    {
        _numer = number;
        _denom = 1;    
    }

    public Fraction(int numer, int denom)
    {
        _numer = numer;
        _denom = denom;
    }

    public void SetNumer(int number)
    {
        _numer = number;
    }
    public int GetNumer()
    {
        return _numer;
    }
    public void SetDenom(int number)
    {
        _denom = number;
    }
    public int GetDenom()
    {
        return _denom;
    }

    public string GetFractionString()
    {
        return $"{_numer}/{_denom}";
    }
    public double GetDecimalValue()
    {
        double fractionValue = (double) _numer / _denom;
        return fractionValue;
    }
}