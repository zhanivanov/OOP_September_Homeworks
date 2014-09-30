using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

public class AsyncTimer
{
    private int ticks;
    private int countTicks = 0;
    private int interval;
    public static Timer timer;
    private Action method;

    public AsyncTimer(Action method, int ticks, int interval)
    {
        this.ticks = ticks;
        this.interval = interval;
        this.Method = method;
    }

    public int Ticks 
    {
        get { return this.ticks; }
        set
        {
            this.ticks = value;
        }
    }
    public int Interval
    {
        get { return this.interval; }
        set
        {
            this.interval = value;
        }
    }

    public Action Method
    {
        get { return this.method; } 
        set
        {
            this.method = value;
        }
    }

    public void Run()
    {
            timer = new System.Timers.Timer(this.interval);
            timer.Elapsed += this.timer_Elapsed;
            timer.Enabled = true;
    }

    void timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        if (this.countTicks < this.ticks)
        {
            this.countTicks++;
            this.Method();
        }
    }
}