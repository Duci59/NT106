using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LTMCB
{
    public static class FormExtensions
    {
        // Extension method for making a form draggable
        public static void MakeDraggable(this Form form)
        {
            // Variables to track mouse offset and dragging state
            Point offset = Point.Empty;
            bool isDragging = false;

            // MouseDown event handler to start dragging
            form.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    offset = new Point(e.X, e.Y);
                    isDragging = true;
                }
            };

            // MouseMove event handler to move the form
            form.MouseMove += (sender, e) =>
            {
                if (isDragging)
                {
                    Point newLocation = form.PointToScreen(new Point(e.X, e.Y));
                    newLocation.Offset(-offset.X, -offset.Y);
                    form.Location = newLocation;
                }
            };

            // MouseUp event handler to stop dragging
            form.MouseUp += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    isDragging = false;
                }
            };
        }
    }
}
