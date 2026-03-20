using System;

public class Test
{
	private int Mid;
    private int Final;

	public double GetAvg()
	{
		return (Mid + Final)/2.0 ;
	}

	public void SetGrade(int m, int f)
	{
		Mid = m;
	    Final = f;
    }
	
}
