using System.Collections;
using System.Drawing;

namespace CinsFlags
{
    public class Flag
    {
        private const int rectangleSize = 15;

        private Rectangle area;
        public static ArrayList FlagList { get; } = new ArrayList();
        public static Color AreaColor { get; set; } = Color.Gold;

        /// <summary>
        /// Creates new area with clicked point settings
        /// </summary>      
        public Flag(int x, int y)
        {
            area = new Rectangle(x - 7, y - 7, rectangleSize, rectangleSize);
        }

        /// <summary>
        /// Draws the current flag on the oicturebox
        /// </summary>       
        public void DrawArea(System.Windows.Forms.PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Brush brush = new SolidBrush(AreaColor);
            g.FillRectangle(brush, area);
            // add flag to area
            g.DrawImage(Properties.Resources.flag, area.X + 1, area.Y - 11, 20, 20);

            FlagList.Add(area);
        }

        /// <summary>
        /// Cleans the static variables; FlagList and AreaColor
        /// Used for new game
        /// </summary>        
        public static void Reset()
        {
            FlagList.Clear();
            AreaColor = Color.Gold;
        }

    }

}