using System.Diagnostics;

namespace ClassTime;
public class Time


{
    private int _hour;
    private int _minute;
    private int _second;
    private int _millisecond;

    public Time()
    {
        _hour = 0;
        _minute = 0;
        _second = 0;
        _millisecond = 0;

    }
    public Time(int hour)
    {
        _hour = hour;
    }
    public Time(int hour, int minute)
    {
        _hour = hour;
        _minute = minute;
    }

    public Time(int hour, int minute, int second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
    }
    public Time(int hour, int minute, int second, int millisecond)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = millisecond;
    }

    public int Hour
    {
        get => _hour;
        set => _hour = value;
    }
    public int Minute
    {
        get => _minute;
        set => _minute = value;
    }
    public int Second
    {
        get => _second;
        set => _second = value;
    }


    public int Millisecond
    {
        get => _millisecond;
        set => _millisecond = value;
    }

    public override string ToString()
    {
        DateTime time = new DateTime(1, 1, 1, _hour, _minute, _second, _millisecond);
        return time.ToString("hh:mm:ss.fff tt");
    }

    public int ToMilliseconds() => (_hour * 3600000) + (_minute * 60000) + (_second * 1000) + _millisecond;
    public int ToSeconds() => (_hour * 3600) + (_minute * 60) + _second;
    public int ToMinutes() => (_hour * 60) + _minute;

    public Time Add(Time other)
    {
        int newMillisecond = _millisecond + other._millisecond;
        int newSecond = _second + other._second + (newMillisecond / 1000);
        int newMinute = _minute + other._minute + (newSecond / 60);
        int newHour = _hour + other._hour + (newMinute / 60);

        newMillisecond %= 1000;
        newSecond %= 60;
        newMinute %= 60;
        newHour %= 24;

        return new Time(newHour, newMinute, newSecond, newMillisecond);
    }

    public bool IsOtherDay(Time other)
    {
        int totalHours = _hour + other._hour;
        int totalMinutes = _minute + other._minute;
        int totalSeconds = _second + other._second;
        int totalMilliseconds = _millisecond + other._millisecond;

        return totalHours >= 24 || (totalHours == 23 && (totalMinutes > 59 || totalSeconds > 59 || totalMilliseconds > 999));
    }

    // Métodos privados de validación
    private bool ValidHour(int hour) => hour >= 0 && hour <= 23;
    private bool ValidMinute(int minute) => minute >= 0 && minute <= 59;
    private bool ValidSeconds(int second) => second >= 0 && second <= 59;
    private bool ValidMilliseconds(int millisecond) => millisecond >= 0 && millisecond <= 999;

    private string GetDebuggerDisplay()
    {
        return FormatTime();
    }

    private string FormatTime()
    {
        return this.ToString();
    }
}