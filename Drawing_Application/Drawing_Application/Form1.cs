using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Application
{
    public partial class FormMainCanvas : Form
    {
        private bool   drawEnabled      = false;
        private string selectedBrush    = "square";



        private const int SHAPE_BOUNDS_IN = 50;
        private const int SHAPE_BOUNDS_OUT = 75;

        Point cursorStart;
        Point cursorEnd;

        Pen outlineScrib;

        Graphics g;

        private Color  penColour        = Color.DeepPink;
        private Color  brushColour      = Color.Crimson;
        private Color  backgroundColour = Color.White;

        
        public FormMainCanvas()
        {
            InitializeComponent();
            outlineScrib = new Pen(penColour, 2);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Detects which ToolStripMenuItem was clicked, brings up the 
        /// and sets the ColorDialog to choose the colour, and sets
        /// the appropriate Color depending on what was clicked.
        /// </summary>
        /// <param name="sender">
        /// The object that started the event.
        /// </param>
        /// <param name="e">
        /// The event arguments.
        /// </param>
        private void openColourDialog(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem clickedTool = (ToolStripMenuItem)sender;

                ColorDialog colourPicker      = new ColorDialog();

                switch (clickedTool.Name)
                {
                    case "backgroundColourToolStripMenuItem":
                        if (colourPicker.ShowDialog() == DialogResult.OK)
                        {
                            backgroundColour    = colourPicker.Color;
                            this.BackColor      = backgroundColour;
                        }
                        break;
                    case "colorPenToolStripMenuItem":
                        if (colourPicker.ShowDialog() == DialogResult.OK)
                        {
                            penColour           = colourPicker.Color;
                        }
                        break;
                    case "colourBrushToolStripMenuItem":
                        if (colourPicker.ShowDialog() == DialogResult.OK)
                        {
                            brushColour         = colourPicker.Color;
                        }
                        break;
                    case "insideColourToolStripMenuItem":
                        if (colourPicker.ShowDialog() == DialogResult.OK)
                        {
                            brushColour          = colourPicker.Color;
                        }
                        break;
                    case "outsideColourToolStripMenuItem":
                        if (colourPicker.ShowDialog() == DialogResult.OK)
                        {
                            penColour            = colourPicker.Color;
                        }
                        break;
                    default:
                        colourPicker.Color       = Color.DarkRed;
                        break;
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error on casting the colour picker to be the correct type.");
            }
            finally
            {
                MessageBox.Show("Back Colour:\t"    + backgroundColour.ToString() +
                                "\nPen Colour:\t"   + penColour.ToString() +
                                "\nBrush Colour:\t" + brushColour.ToString());
            }
        }

        /// <summary>
        /// Gets the brush type that was selected and assigns it to
        /// the selectedBrush variable.
        /// </summary>
        /// <param name="sender">
        /// The object that started the event.
        /// </param>
        /// <param name="e">
        /// The event arguments.
        /// </param>
        private void selectBrushType(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem clickedBrush = (ToolStripMenuItem)sender;

                switch (clickedBrush.Name)
                {
                    case "rectangleToolStripMenuItem":
                        selectedBrush = "rectangle";
                        break;
                    case "circleToolStripMenuItem":
                        selectedBrush = "circle";
                        break;
                    case "squareToolStripMenuItem":
                        selectedBrush = "square";
                        break;
                    case "scribbleToolStripMenuItem":
                        selectedBrush = "scribble";
                        break;
                    default:
                        selectedBrush = "rectangle";
                        break;
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error on casting the brush to be the correct style.");
            }

        }

        private void FormMainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawEnabled = true;
            cursorStart = new Point(e.Location.X, e.Location.Y);
            //Invalidate();
        }

        private void FormMainCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedBrush == "rectangle")
            {
                GraphicsPath pathGradient = new GraphicsPath();

                pathGradient.AddRectangle(new Rectangle(cursorStart.X, cursorStart.Y,
                                                        cursorEnd.X, cursorEnd.Y));

                PathGradientBrush pathGradientBrush = new PathGradientBrush(pathGradient);

                pathGradientBrush.CenterColor = brushColour;
                pathGradientBrush.SurroundColors = new Color[] { penColour };

                g.FillRectangle(pathGradientBrush, cursorStart.X, cursorStart.Y,
                                                   cursorStart.X, cursorStart.Y);
            }
            //Invalidate();
            drawEnabled = false;
        }

        private void FormMainCanvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            cursorEnd = new Point(e.Location.X, e.Location.Y);
            
            g = this.CreateGraphics();

            if (drawEnabled)
            {
                switch (selectedBrush)
                {
                    case "rectangle":

                        //draw lines connecting points (4 lines total)

                        Pen outlinePen = new Pen(penColour, 2);

                        g = this.CreateGraphics();

                        // Two Horizontal lines from start to end positions.
                        g.DrawLine(outlinePen, cursorStart.X, cursorStart.Y, cursorEnd.X, cursorStart.Y);
                        g.DrawLine(outlinePen, cursorStart.X, cursorEnd.Y, cursorEnd.X, cursorEnd.Y);
                        // Two Vertical lines from start to end positions.
                        g.DrawLine(outlinePen, cursorStart.X, cursorStart.Y, cursorStart.X, cursorEnd.Y);
                        g.DrawLine(outlinePen, cursorEnd.X, cursorStart.Y, cursorEnd.X, cursorEnd.Y);

                        break;
                    case "circle":

                        GraphicsPath pathGradientCircle = new GraphicsPath();

                        pathGradientCircle.AddEllipse(new Rectangle(cursorEnd.X, cursorEnd.Y,
                                                                SHAPE_BOUNDS_IN, SHAPE_BOUNDS_IN));

                        PathGradientBrush pathGradientBrushCircle = new PathGradientBrush(pathGradientCircle);

                        pathGradientBrushCircle.CenterColor = brushColour;
                        pathGradientBrushCircle.SurroundColors = new Color[] { penColour };

                        g.FillEllipse(pathGradientBrushCircle, cursorEnd.X, cursorEnd.Y,
                                                                    SHAPE_BOUNDS_IN, SHAPE_BOUNDS_IN);
                        break;
                    case "square":
                        GraphicsPath pathGradientSquare = new GraphicsPath();

                        pathGradientSquare.AddRectangle(new Rectangle(cursorEnd.X, cursorEnd.Y,
                                                                SHAPE_BOUNDS_IN, SHAPE_BOUNDS_IN));

                        PathGradientBrush pathGradientBrushSquare = new PathGradientBrush(pathGradientSquare);

                        pathGradientBrushSquare.CenterColor = brushColour;
                        pathGradientBrushSquare.SurroundColors = new Color[] { penColour };

                        g.FillRectangle(pathGradientBrushSquare, cursorEnd.X, cursorEnd.Y,
                                                                    SHAPE_BOUNDS_OUT, SHAPE_BOUNDS_OUT);

                        break;
                    case "scribble":

                        g.DrawLine(outlineScrib, cursorEnd.X, cursorEnd.Y, cursorEnd.X - 1, cursorEnd.Y - 1);
                            
                        break;
                    default:
                        // Do not draw anything.
                        break;
                }
            }
        }
    }
}
