using SFML.Graphics;

namespace Engine.Tools
{
    //Class for getting a color scheme
    public class GetColor
    {
        public static Color CreateColor(byte r, byte b, byte g, byte a = 255)
        {
            return new Color(r, b, g, a);
        }

        public static Color GetSFMLColor(string color)
        {
            Color tempColor = new Color();
            switch (color)
            {
                case "Black":
                    tempColor = Color.Black;
                    break;
                case "black":
                    tempColor = Color.Black;
                    break;
                case "Blue":
                    tempColor = Color.Blue;
                    break;
                case "blue":
                    tempColor = Color.Blue;
                    break;
                case "Cyan":
                    tempColor = Color.Cyan;
                    break;
                case "cyan":
                    tempColor = Color.Cyan;
                    break;
                case "Green":
                    tempColor = Color.Green;
                    break;
                case "green":
                    tempColor = Color.Green;
                    break;
                case "Magenta":
                    tempColor = Color.Magenta;
                    break;
                case "magenta":
                    tempColor = Color.Magenta;
                    break;
                case "Red":
                    tempColor = Color.Red;
                    break;
                case "red":
                    tempColor = Color.Red;
                    break;
                case "Transparent":
                    tempColor = Color.Transparent;
                    break;
                case "transparent":
                    tempColor = Color.Transparent;
                    break;
                case "White":
                    tempColor = Color.White;
                    break;
                case "white":
                    tempColor = Color.White;
                    break;
                case "Yellow":
                    tempColor = Color.Yellow;
                    break;
                case "yellow":
                    tempColor = Color.Yellow;
                    break;
                case "Gray":
                    tempColor = new Color(136, 136, 136);
                    break;
                case "gray":
                    tempColor = new Color(136, 136, 136);
                    break;
                case "Birch":
                    tempColor = new Color(0, 204, 153);
                    break;
                case "birch":
                    tempColor = new Color(0, 204, 153);
                    break;
                default:
                    tempColor = Color.White;
                    break;
            }
            return tempColor;
        }

        public static ConsoleColor GetConsoleColor(string color)
        {
            ConsoleColor tempColor = new ConsoleColor();
            switch (color)
            {
                case "Black":
                    tempColor = ConsoleColor.Black;
                    break;
                case "black":
                    tempColor = ConsoleColor.Black;
                    break;
                case "Blue":
                    tempColor = ConsoleColor.Blue;
                    break;
                case "blue":
                    tempColor = ConsoleColor.Blue;
                    break;
                case "Cyan":
                    tempColor = ConsoleColor.Cyan;
                    break;
                case "cyan":
                    tempColor = ConsoleColor.Cyan;
                    break;
                case "DarkBlue":
                    tempColor = ConsoleColor.DarkBlue;
                    break;
                case "darkBlue":
                    tempColor = ConsoleColor.DarkBlue;
                    break;
                case "Darkblue":
                    tempColor = ConsoleColor.DarkBlue;
                    break;
                case "darkblue":
                    tempColor = ConsoleColor.DarkBlue;
                    break;
                case "DarkCyan":
                    tempColor = ConsoleColor.DarkCyan;
                    break;
                case "darkCyan":
                    tempColor = ConsoleColor.DarkCyan;
                    break;
                case "Darkcyan":
                    tempColor = ConsoleColor.DarkCyan;
                    break;
                case "darkcyan":
                    tempColor = ConsoleColor.DarkCyan;
                    break;
                case "DarkGray":
                    tempColor = ConsoleColor.DarkGray;
                    break;
                case "darkGray":
                    tempColor = ConsoleColor.DarkGray;
                    break;
                case "Darkgray":
                    tempColor = ConsoleColor.DarkGray;
                    break;
                case "darkgray":
                    tempColor = ConsoleColor.DarkGray;
                    break;
                case "DarkGreen":
                    tempColor = ConsoleColor.DarkGreen;
                    break;
                case "darkGreen":
                    tempColor = ConsoleColor.DarkGreen;
                    break;
                case "Darkgreen":
                    tempColor = ConsoleColor.DarkGreen;
                    break;
                case "darkgreen":
                    tempColor = ConsoleColor.DarkGreen;
                    break;
                case "DarkMagenta":
                    tempColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkMagenta":
                    tempColor = ConsoleColor.DarkMagenta;
                    break;
                case "Darkmagenta":
                    tempColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkmagenta":
                    tempColor = ConsoleColor.DarkMagenta;
                    break;
                case "DarkRed":
                    tempColor = ConsoleColor.DarkRed;
                    break;
                case "darkRed":
                    tempColor = ConsoleColor.DarkRed;
                    break;
                case "Darkred":
                    tempColor = ConsoleColor.DarkRed;
                    break;
                case "darkred":
                    tempColor = ConsoleColor.DarkRed;
                    break;
                case "DarkYellow":
                    tempColor = ConsoleColor.DarkYellow;
                    break;
                case "darkYellow":
                    tempColor = ConsoleColor.DarkYellow;
                    break;
                case "Darkyellow":
                    tempColor = ConsoleColor.DarkYellow;
                    break;
                case "darkyellow":
                    tempColor = ConsoleColor.DarkYellow;
                    break;
                case "Gray":
                    tempColor = ConsoleColor.Gray;
                    break;
                case "gray":
                    tempColor = ConsoleColor.Gray;
                    break;
                case "Green":
                    tempColor = ConsoleColor.Green;
                    break;
                case "green":
                    tempColor = ConsoleColor.Green;
                    break;
                case "Magenta":
                    tempColor = ConsoleColor.Magenta;
                    break;
                case "magenta":
                    tempColor = ConsoleColor.Magenta;
                    break;
                case "Red":
                    tempColor = ConsoleColor.Red;
                    break;
                case "red":
                    tempColor = ConsoleColor.Red;
                    break;
                case "White":
                    tempColor = ConsoleColor.White;
                    break;
                case "white":
                    tempColor = ConsoleColor.White;
                    break;
                case "Yellow":
                    tempColor = ConsoleColor.Yellow;
                    break;
                case "yellow":
                    tempColor = ConsoleColor.Yellow;
                    break;
                default:
                    tempColor = ConsoleColor.White;
                    break;
            }
            return tempColor;
        }
    }
}
