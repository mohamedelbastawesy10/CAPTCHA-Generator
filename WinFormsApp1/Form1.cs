using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace CaptchaGenerator
{
    public partial class Form1 : Form
    {
        private string currentTextCaptcha = "";
        private string currentMathCaptcha = "";
        private string currentMathResult = "";
        private bool isCheckboxCaptchaChecked = false;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeApp();
        }

        private void InitializeApp()
        {
            // Set up tabs
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            // Generate initial CAPTCHAs
            GenerateTextCaptcha();
            GenerateImageCaptcha();
            GenerateMathCaptcha();

            // Initialize checkbox CAPTCHA
            checkBoxCaptcha.CheckedChanged += CheckBoxCaptcha_CheckedChanged;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Generate new CAPTCHA when switching tabs
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Text CAPTCHA
                    GenerateTextCaptcha();
                    break;
                case 1: // Image CAPTCHA
                    GenerateImageCaptcha();
                    break;
                case 2: // Math CAPTCHA
                    GenerateMathCaptcha();
                    break;
                case 3: // Checkbox CAPTCHA
                    ResetCheckboxCaptcha();
                    break;
            }
        }

        #region Text CAPTCHA Methods

        private void GenerateTextCaptcha()
        {
            // Create a random text captcha of 6 characters
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            currentTextCaptcha = "";

            for (int i = 0; i < 6; i++)
            {
                currentTextCaptcha += chars[random.Next(chars.Length)];
            }

            // Create bitmap for the captcha
            Bitmap bitmap = new Bitmap(pictureBoxTextCaptcha.Width, pictureBoxTextCaptcha.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Fill background
                g.Clear(Color.White);

                // Add noise
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(bitmap.Width);
                    int y = random.Next(bitmap.Height);
                    bitmap.SetPixel(x, y, Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
                }

                // Add lines
                for (int i = 0; i < 5; i++)
                {
                    using (Pen pen = new Pen(Color.FromArgb(random.Next(100), random.Next(100), random.Next(100)), 1))
                    {
                        g.DrawLine(pen,
                            new Point(random.Next(0, bitmap.Width), random.Next(0, bitmap.Height)),
                            new Point(random.Next(0, bitmap.Width), random.Next(0, bitmap.Height)));
                    }
                }

                // Draw the text
                using (Font font = new Font("Arial", 18, FontStyle.Bold))
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        // Create a slightly wavy text
                        path.AddString(
                            currentTextCaptcha,
                            FontFamily.GenericSansSerif,
                            (int)FontStyle.Bold,
                            g.DpiY * 24 / 72,
                            new Point(10, 10),
                            StringFormat.GenericDefault);

                        // Warp the text slightly
                        Matrix matrix = new Matrix();
                        matrix.Rotate(random.Next(-5, 5));
                        path.Transform(matrix);

                        // Draw the text with a subtle shadow
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        using (Pen pen = new Pen(Color.FromArgb(100, 100, 100), 2))
                        {
                            g.DrawPath(pen, path);
                        }
                        g.FillPath(Brushes.DarkBlue, path);
                    }
                }
            }

            // Set the PictureBox image
            if (pictureBoxTextCaptcha.Image != null)
            {
                pictureBoxTextCaptcha.Image.Dispose();
            }
            pictureBoxTextCaptcha.Image = bitmap;

            // Clear input field
            textBoxTextCaptcha.Clear();
            labelTextResult.Text = "";
        }

        private void btnVerifyTextCaptcha_Click(object sender, EventArgs e)
        {
            string userInput = textBoxTextCaptcha.Text.Trim().ToUpper();

            if (userInput == currentTextCaptcha)
            {
                labelTextResult.ForeColor = Color.Green;
                labelTextResult.Text = "Success! CAPTCHA verified.";
            }
            else
            {
                labelTextResult.ForeColor = Color.Red;
                labelTextResult.Text = "Error! CAPTCHA does not match.";
            }
        }

        private void btnRefreshTextCaptcha_Click(object sender, EventArgs e)
        {
            GenerateTextCaptcha();
        }

        #endregion

        #region Image CAPTCHA Methods

        private void GenerateImageCaptcha()
        {
            // Create a simple image selection CAPTCHA
            int selectedImageIndex = random.Next(4); // 4 possible images

            // Create a 2x2 panel with images
            Bitmap bitmap = new Bitmap(pictureBoxImageCaptcha.Width, pictureBoxImageCaptcha.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.LightGray);

                int cellWidth = bitmap.Width / 2;
                int cellHeight = bitmap.Height / 2;

                // Draw grid lines
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    g.DrawLine(pen, cellWidth, 0, cellWidth, bitmap.Height);
                    g.DrawLine(pen, 0, cellHeight, bitmap.Width, cellHeight);
                }

                // Draw shapes in each cell
                DrawShape(g, 0, 0, cellWidth, cellHeight, 0); // Square
                DrawShape(g, cellWidth, 0, cellWidth, cellHeight, 1); // Circle
                DrawShape(g, 0, cellHeight, cellWidth, cellHeight, 2); // Triangle
                DrawShape(g, cellWidth, cellHeight, cellWidth, cellHeight, 3); // Star
            }

            if (pictureBoxImageCaptcha.Image != null)
            {
                pictureBoxImageCaptcha.Image.Dispose();
            }
            pictureBoxImageCaptcha.Image = bitmap;

            // Set the target shape description
            string[] shapeNames = { "Square", "Circle", "Triangle", "Star" };
            labelImageInstruction.Text = $"Click the '{shapeNames[selectedImageIndex]}' to verify";

            // Store the selected shape as tag to validate later
            pictureBoxImageCaptcha.Tag = selectedImageIndex;

            // Clear result
            labelImageResult.Text = "";
        }

        private void DrawShape(Graphics g, int x, int y, int width, int height, int shapeType)
        {
            // Create random color
            Color shapeColor = Color.FromArgb(
                random.Next(100, 256),
                random.Next(100, 256),
                random.Next(100, 256));

            SolidBrush brush = new SolidBrush(shapeColor);
            Pen pen = new Pen(Color.Black, 2);

            // Calculate center position
            int centerX = x + width / 2;
            int centerY = y + height / 2;

            // Adjust size to fit
            int size = Math.Min(width, height) - 20;

            switch (shapeType)
            {
                case 0: // Square
                    g.FillRectangle(brush, centerX - size / 2, centerY - size / 2, size, size);
                    g.DrawRectangle(pen, centerX - size / 2, centerY - size / 2, size, size);
                    break;

                case 1: // Circle
                    g.FillEllipse(brush, centerX - size / 2, centerY - size / 2, size, size);
                    g.DrawEllipse(pen, centerX - size / 2, centerY - size / 2, size, size);
                    break;

                case 2: // Triangle
                    PointF[] trianglePoints = new PointF[]
                    {
                        new PointF(centerX, centerY - size/2),
                        new PointF(centerX - size/2, centerY + size/2),
                        new PointF(centerX + size/2, centerY + size/2)
                    };
                    g.FillPolygon(brush, trianglePoints);
                    g.DrawPolygon(pen, trianglePoints);
                    break;

                case 3: // Star
                    DrawStar(g, centerX, centerY, size / 2, brush, pen);
                    break;
            }

            brush.Dispose();
            pen.Dispose();
        }

        private void DrawStar(Graphics g, int centerX, int centerY, int size, Brush brush, Pen pen)
        {
            PointF[] points = new PointF[10];
            double angle = -Math.PI / 2;
            double angleIncrement = Math.PI * 2 / 10;

            for (int i = 0; i < 10; i++)
            {
                double radius = (i % 2 == 0) ? size : size / 2;
                points[i] = new PointF(
                    (float)(centerX + radius * Math.Cos(angle)),
                    (float)(centerY + radius * Math.Sin(angle))
                );
                angle += angleIncrement;
            }

            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
        }

        private void pictureBoxImageCaptcha_Click(object sender, EventArgs e)
        {
            Point clickPoint = pictureBoxImageCaptcha.PointToClient(Cursor.Position);
            int selectedIndex = (int)pictureBoxImageCaptcha.Tag;

            int cellWidth = pictureBoxImageCaptcha.Width / 2;
            int cellHeight = pictureBoxImageCaptcha.Height / 2;

            // Determine which quadrant was clicked
            int clickedQuadrant;
            if (clickPoint.X < cellWidth && clickPoint.Y < cellHeight)
                clickedQuadrant = 0; // Square
            else if (clickPoint.X >= cellWidth && clickPoint.Y < cellHeight)
                clickedQuadrant = 1; // Circle
            else if (clickPoint.X < cellWidth && clickPoint.Y >= cellHeight)
                clickedQuadrant = 2; // Triangle
            else
                clickedQuadrant = 3; // Star

            // Verify if the correct shape was clicked
            if (clickedQuadrant == selectedIndex)
            {
                labelImageResult.ForeColor = Color.Green;
                labelImageResult.Text = "Success! Correct shape selected.";
            }
            else
            {
                labelImageResult.ForeColor = Color.Red;
                labelImageResult.Text = "Error! Incorrect shape selected.";
            }
        }

        private void btnRefreshImageCaptcha_Click(object sender, EventArgs e)
        {
            GenerateImageCaptcha();
        }

        #endregion

        #region Math CAPTCHA Methods

        private void GenerateMathCaptcha()
        {
            int num1 = random.Next(1, 20);
            int num2 = random.Next(1, 20);
            int operation = random.Next(3); // 0: add, 1: subtract, 2: multiply

            switch (operation)
            {
                case 0: // Addition
                    currentMathCaptcha = $"{num1} + {num2} = ?";
                    currentMathResult = (num1 + num2).ToString();
                    break;
                case 1: // Subtraction
                    // Make sure result is positive
                    if (num1 < num2)
                    {
                        int temp = num1;
                        num1 = num2;
                        num2 = temp;
                    }
                    currentMathCaptcha = $"{num1} - {num2} = ?";
                    currentMathResult = (num1 - num2).ToString();
                    break;
                case 2: // Multiplication
                    num1 = random.Next(1, 10); // Use smaller numbers for multiplication
                    num2 = random.Next(1, 10);
                    currentMathCaptcha = $"{num1} × {num2} = ?";
                    currentMathResult = (num1 * num2).ToString();
                    break;
            }

            // Create bitmap for the math captcha
            Bitmap bitmap = new Bitmap(pictureBoxMathCaptcha.Width, pictureBoxMathCaptcha.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Fill background
                g.Clear(Color.White);

                // Add noise (dots)
                for (int i = 0; i < 80; i++)
                {
                    int x = random.Next(bitmap.Width);
                    int y = random.Next(bitmap.Height);
                    bitmap.SetPixel(x, y, Color.FromArgb(random.Next(100, 200), random.Next(100, 200), random.Next(100, 200)));
                }

                // Add wavy lines
                for (int i = 0; i < 3; i++)
                {
                    Point[] points = new Point[bitmap.Width / 10];
                    for (int x = 0; x < points.Length; x++)
                    {
                        points[x] = new Point(
                            x * 10,
                            bitmap.Height / 2 + random.Next(-10, 10)
                        );
                    }
                    using (Pen pen = new Pen(Color.FromArgb(200, 200, 200), 1))
                    {
                        g.DrawCurve(pen, points);
                    }
                }

                // Draw the math equation
                using (Font font = new Font("Arial", 18, FontStyle.Bold))
                {
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    g.DrawString(currentMathCaptcha, font, Brushes.DarkBlue,
                                 new PointF(bitmap.Width / 2 - 60, bitmap.Height / 2 - 15));
                }
            }

            if (pictureBoxMathCaptcha.Image != null)
            {
                pictureBoxMathCaptcha.Image.Dispose();
            }
            pictureBoxMathCaptcha.Image = bitmap;

            // Clear input field
            textBoxMathCaptcha.Clear();
            labelMathResult.Text = "";
        }

        private void btnVerifyMathCaptcha_Click(object sender, EventArgs e)
        {
            string userInput = textBoxMathCaptcha.Text.Trim();

            if (userInput == currentMathResult)
            {
                labelMathResult.ForeColor = Color.Green;
                labelMathResult.Text = "Success! CAPTCHA verified.";
            }
            else
            {
                labelMathResult.ForeColor = Color.Red;
                labelMathResult.Text = "Error! Incorrect answer.";
            }
        }

        private void btnRefreshMathCaptcha_Click(object sender, EventArgs e)
        {
            GenerateMathCaptcha();
        }

        #endregion

        #region Checkbox CAPTCHA Methods

        private void ResetCheckboxCaptcha()
        {
            checkBoxCaptcha.Checked = false;
            isCheckboxCaptchaChecked = false;
            labelCheckboxResult.Text = "";
        }

        private void CheckBoxCaptcha_CheckedChanged(object sender, EventArgs e)
        {
            // Simple implementation - just checking the checkbox verifies
            isCheckboxCaptchaChecked = checkBoxCaptcha.Checked;
        }

        private void btnVerifyCheckboxCaptcha_Click(object sender, EventArgs e)
        {
            if (isCheckboxCaptchaChecked)
            {
                labelCheckboxResult.ForeColor = Color.Green;
                labelCheckboxResult.Text = "Success! You're verified as human.";
            }
            else
            {
                labelCheckboxResult.ForeColor = Color.Red;
                labelCheckboxResult.Text = "Error! Please check the box to verify.";
            }
        }

        private void btnRefreshCheckboxCaptcha_Click(object sender, EventArgs e)
        {
            ResetCheckboxCaptcha();
        }

        #endregion
    }
}
