namespace ConsoleApp3;

public class Ball
{
    public double Size { get; set; }
    public Color Color { get; set; }
    public int ThrowCount { get; set; }

    public Ball(double size, Color color)
    {
        Size = size;
        Color = color;
    }

    public Ball()
    {
    }

    public void Pop()
    {
        Size = 0.0;
    }

    public void Throw()
    {
        if (Size != 0.0) ThrowCount++;
    }

    public int GetThrows()
    {
        return ThrowCount;
    }
}