using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;

namespace Emgu.CV.UI
{
    public partial class ImageProperty : UserControl
    {
        /// <summary>
        /// Create a ImageProperty control
        /// </summary>
        public ImageProperty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set the width of the image
        /// </summary>
        public int ImageWidth
        {
            set
            {
                widthTextbox.Text = value.ToString();
            }
        }

        /// <summary>
        /// Set the height of the image
        /// </summary>
        public int ImageHeight
        {
            set
            {
                heightTextBox.Text = value.ToString();
            }
        }

        /// <summary>
        /// Set the Type of the color
        /// </summary>
        public String ColorType
        {
            set
            {
                colorTypeTexbox.Text = value;
            }
        }

        /// <summary>
        /// Set the mouse position over the image
        /// </summary>
        public Point2D<int> MousePositionOnImage
        {
            set
            {
                mousePositionTextbox.Text = String.Format("[{0}, {1}]", value.X, value.Y);
            }
        }

        /// <summary>
        /// Set the color intensity of the pixel on the image where is mouse is at
        /// </summary>
        public ColorType ColorIntensity
        {
            set
            {
                colorIntensityTextbox.Text = String.Format("[{0}]",
                    value == null ? "" : String.Join(",", System.Array.ConvertAll<double, String>(value.Coordinate, System.Convert.ToString)));
            }
        }

        /// <summary>
        /// Set the Depth of the image
        /// </summary>
        public System.Type ColorDepth
        {
            set
            {
                colorDepthTextBox.Text = value.Name;
            }
        }

        /// <summary>
        /// Set the description of the operation stack
        /// </summary>
        public String OperationStackText
        {
            set
            {
                operationStackTextBox.Text = value;
            }
        }
    }
}
