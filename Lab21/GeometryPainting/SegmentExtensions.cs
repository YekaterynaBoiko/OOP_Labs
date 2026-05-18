using System.Collections.Generic;
using Avalonia.Media;
using Geometry;

namespace GeometryPainting;

//TODO: напиши тут код, який забезпечить роботу методів segment.GetColor та segment.SetColor
public static class SegmentExtensions
{
    private readonly static Dictionary<Segment, Color> _colors = new Dictionary<Segment, Color>();

    public static Color GetColor(this Segment segment) // хвенення до кожного відрізку окремо
    {
        if (_colors.ContainsKey(segment))
            return _colors[segment];

        return Color.FromRgb(0, 0, 0);
    }

    public static void SetColor(this Segment segment, Color color)
    {
        _colors[segment] = color;
    }
}
