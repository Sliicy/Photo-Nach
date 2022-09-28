using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Nach
{
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        readonly Output_Window ow = new Output_Window();

        bool zoharMode;

        DirectBitmap bmp;

        public static bool stretchImage = true;

        public string SanitizeString(string input) {

            // Remove double spacing:
            while (input.Contains("  ")) {
                input = input.Replace("  ", " ");
            }

            // Assign colons as new lines:
            input = input.Replace("׃", Environment.NewLine);
            input = input.Replace(":", Environment.NewLine);
            
            // Remove foreign characters:
            input = input.Replace("[", string.Empty);
            input = input.Replace("]", string.Empty);
            input = input.Replace("`", string.Empty);
            input = input.Replace("~", string.Empty);
            input = input.Replace("!", string.Empty);
            input = input.Replace("@", string.Empty);
            input = input.Replace("#", string.Empty);
            input = input.Replace("$", string.Empty);
            input = input.Replace("%", string.Empty);
            input = input.Replace("^", string.Empty);
            input = input.Replace("&", string.Empty);
            input = input.Replace("*", string.Empty);
            input = input.Replace("(", string.Empty);
            input = input.Replace(")", string.Empty);
            input = input.Replace("{", string.Empty);
            input = input.Replace("}", string.Empty);
            input = input.Replace("\\", string.Empty);
            input = input.Replace("|", string.Empty);
            input = input.Replace(";", string.Empty);
            input = input.Replace("'", string.Empty);
            input = input.Replace("\"", string.Empty);
            input = input.Replace("<", string.Empty);
            input = input.Replace(">", string.Empty);
            input = input.Replace(",", string.Empty);
            input = input.Replace(".", string.Empty);
            input = input.Replace("/", string.Empty);
            input = input.Replace("?", string.Empty);
            input = input.Replace("=", string.Empty);
            input = input.Replace("+", string.Empty);
            input = input.Replace("_", string.Empty);
            return input;
        }

        public string StripSpaces(string input) {
            input = input.Replace(" ", string.Empty);
            return input;
        }
        public string StripTabs(string input) {
            input = input.Replace("־", string.Empty);
            input = input.Replace("\t", string.Empty);
            input = input.Replace("-", string.Empty);
            return input;
        }
        public string StripSofis(string input) {
            input = input.Replace("ךּ", "כּ");
            input = input.Replace("ך", "כ");
            input = input.Replace("ם", "מ");
            input = input.Replace("ן", "נ");
            input = input.Replace("ף", "פ");
            input = input.Replace("ץ", "צ");
            return input;
        }
        public string StripDots(string input) {
            input = input.Replace("\u05BC", string.Empty); // Dagesh or Mapiq
            return input;
        }
        public string StripNekudos(string input) {
            input = input.Replace("\u05B4", string.Empty); // Chirik
            input = input.Replace("\u05B0", string.Empty); // Shva
            input = input.Replace("\u05B8", string.Empty); // Kamatz
            input = input.Replace("\u05C7", string.Empty); // Kamatz Kattan
            input = input.Replace("\u05B7", string.Empty); // Patach
            input = input.Replace("\u05BB", string.Empty); // Kubutz
            input = input.Replace("\u05B5", string.Empty); // Tzeiri
            input = input.Replace("\u05B9", string.Empty); // Cholam
            input = input.Replace("\u05B6", string.Empty); // Segol
            input = input.Replace("\u05C1", string.Empty); // Shin dot
            input = input.Replace("\u05C2", string.Empty); // Sin dot
            input = input.Replace("\u05B1", string.Empty); // Chataf Segol
            input = input.Replace("\u05B2", string.Empty); // Chataf Patach
            input = input.Replace("\u05B3", string.Empty); // Chataf Kamatz
            input = input.Replace("\u05BF", string.Empty); // Rafe
            return input;
        }
        public string StripChataf(string input) {
            input = input.Replace("\u05B1", "\u05B6"); // Chataf Segol
            input = input.Replace("\u05B2", "\u05B7"); // Chataf Patach
            input = input.Replace("\u05B3", "\u05B8"); // Chataf Kamatz
            return input;
        }
        public string StripCantillations(string input) {
            input = input.Replace("\u0591", string.Empty); // Esnachta
            input = input.Replace("\u0592", string.Empty); // Segol
            input = input.Replace("\u0593", string.Empty); // Shalsheles
            input = input.Replace("\u0594", string.Empty); // Zakef Katan
            input = input.Replace("\u0595", string.Empty); // Zakef Gadol
            input = input.Replace("\u0596", string.Empty); // Tifcha
            input = input.Replace("\u0597", string.Empty); // Revi'i
            input = input.Replace("\u05AE", string.Empty); // Zarka
            input = input.Replace("\u0599", string.Empty); // Pashta
            input = input.Replace("\u059A", string.Empty); // Yesiv
            input = input.Replace("\u059B", string.Empty); // Tivir
            input = input.Replace("\u05A1", string.Empty); // Pazer
            input = input.Replace("\u059F", string.Empty); // Karne Farah
            input = input.Replace("\u05A0", string.Empty); // Telisha Gedolah
            input = input.Replace("\u059C", string.Empty); // Azla Geireish
            input = input.Replace("\u059E", string.Empty); // Gershayim
            input = input.Replace("\u05A5", string.Empty); // Mercha
            input = input.Replace("\u05A3", string.Empty); // Munach
            input = input.Replace("\u05A4", string.Empty); // Mahpach
            input = input.Replace("\u05A7", string.Empty); // Darga
            input = input.Replace("\u05A8", string.Empty); // Kadma
            input = input.Replace("\u05A9", string.Empty); // Telisha Ketana
            input = input.Replace("\u05A6", string.Empty); // Mercha Kefula
            input = input.Replace("\u05AA", string.Empty); // Yerach Ben Yomo
            input = input.Replace("׀", string.Empty); // Munach Legarmeh
            return input;
        }
        public string StripCrowns(string input) {

            return input;
        }

        public string CutIntoColumns(string input, int columns) {
            // Remove all old newlines:
            input = input.Replace(Environment.NewLine, string.Empty);

            // Generate newlines based on desired columns:
            return Regex.Replace(input, "(.{" + columns + "})", "$1" + Environment.NewLine);
        }

        public int GetLongestLineLength(string input) {
            var result = input.Split(new[] { '\r', '\n' });
            int longestLineCount = 0;
            for (int i = 0; i < result.Length; i++) {
                if (result[i].Length >= longestLineCount) {
                    longestLineCount = result[i].Length;
                }
            }
            return longestLineCount;
        }

        public double CubeRoot(double number) {
            return Math.Ceiling(Math.Pow(number, (double)1 / 3));
        }

        static IEnumerable<string> CombinationsWithRepetition(IEnumerable<int> input, int length) {
            // Source: https://stackoverflow.com/questions/25824376/combinations-with-repetitions-c-sharp
            if (length <= 0)
                yield return "";
            else {
                foreach (var i in input)
                    foreach (var c in CombinationsWithRepetition(input, length - 1))
                        yield return i.ToString() + "," + c;
            }
        }

        public Dictionary<char, Color> GenerateColorsFromCharacters(string inputList) {
            // This function calculates all permutations from 0 - 255 of RGB colors that are far enough apart to be recognized by color.
            // For example, if 8 colors are needed for A, B, C, D, E, F, G, H, this function will generate the following colors, one per letter:
            //
            // (0,0,0), (0,0,255), (0,255,0), (0,255,255), (255,0,0), (255,0,255), (255,255,0), (255,255,255)
            //
            // This will be outputted as a dictionary key-pair value, such as:
            //
            // A, (0,0,0), B (0,0,255), C (0,255,0), etc.


            // Clean the list and remove all duplicate characters:
            inputList = new string(inputList.ToCharArray().Distinct().ToArray());
            
            // Calculate the total needed colors for each character:
            int totalColorsNeeded = inputList.Length;

            // Calculate how many divisions of 255 are possible for each color:
            int denominator = (int)(CubeRoot(totalColorsNeeded) - 1);
            if (denominator == 0) denominator = 1;
            int splitSegment = 255 / denominator;

            // Create an list to remember all "cuts" that will be made.
            // For example:
            // If 8 colors are needed, this list will hold (0, 255)
            // If 27 colors are needed, this list will hold (0, 128, 255)
            List<int> cutArray = new List<int>();

            // Calculate every number between 0 - 255 by multiple of splitSegment.
            // If 27 colors are needed, this will be by multiples of 128.
            int counterSegment = -splitSegment;
            while (splitSegment + counterSegment <= 255) {
                cutArray.Add(splitSegment + counterSegment);
                counterSegment += splitSegment;
            }

            // Dictionary that will hold each pair of character and corresponding color as output:
            Dictionary<char, Color> colorDict = new Dictionary<char, Color>();

            // Counter to remember which character function is assigning a color to:
            int characterCounter = 0;

            // Using the cutArray, and length of 3 (corresponding to R, G, B), this loop calculates each permutation and assigns it to a character:
            foreach (string colorPermutation in CombinationsWithRepetition(cutArray, 3)) {

                // Stop if incrementor reaches the end of character list:
                if (characterCounter >= inputList.Length) {
                    break;
                }

                // Convert the string back into a color, and assigns it to each consecutive character:
                colorDict.Add(inputList[characterCounter], Color.FromArgb(
                    255, 
                    int.Parse(colorPermutation.TrimEnd(',').Split(',')[0]), 
                    int.Parse(colorPermutation.TrimEnd(',').Split(',')[1]), 
                    int.Parse(colorPermutation.TrimEnd(',').Split(',')[2])));
                characterCounter++;
            }
            return colorDict;
        }

        static string SortString(string input) {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }

        private void StateChanged_CheckedChanged(object sender, EventArgs e)
        {
            RedrawImage();
        }

        private void RedrawImage()
        {
            string dataInput = txtInput.Text;

            if (chkSanitize.Checked)
            {
                dataInput = SanitizeString(dataInput);
            }
            if (chkSofis.Checked)
            {
                dataInput = StripSofis(dataInput);
            }
            if (chkSpaces.Checked)
            {
                dataInput = StripSpaces(dataInput);
            }
            if (chkTabs.Checked)
            {
                dataInput = StripTabs(dataInput);
            }
            if (chkDottedLetters.Checked)
            {
                dataInput = StripDots(dataInput);
            }
            if (chkNekudos.Checked)
            {
                dataInput = StripNekudos(dataInput);
            }
            if (chkChataf.Checked)
            {
                dataInput = StripChataf(dataInput);
            }
            if (chkCantillations.Checked)
            {
                dataInput = StripCantillations(dataInput);
            }
            if (chkCrowns.Checked)
            {
                dataInput = StripCrowns(dataInput);
            }

            zoharMode = chkZoharMode.Checked;

            int width;

            if (numCustomWidth.Value == 0)
            {
                width = GetLongestLineLength(dataInput);
            } else
            {

                // Set width to custom amount specified by user:
                width = decimal.ToInt32(numCustomWidth.Value);

                // Regroup all words into X Columns (rearranges all newlines):
                dataInput = CutIntoColumns(dataInput, width);
            }

            int height = dataInput.Split('\n').Length;

            // Width & Height cannot be 0:
            if (width == 0)
            {
                width = 1;
            }
            if (height == 0)
            {
                height = 1;
            }
            if (ow.picOutput.Image != null)
            {
                ow.picOutput.Image.Dispose();
            }

            string uniqueListOfCharacters = SortString(new string(dataInput.ToCharArray().Distinct().ToArray()));

            if (chkTrackSingle.Checked)
            {
                if (dataInput.Length == 0)
                {
                    return;
                }
                if (trackBlack.Value > uniqueListOfCharacters.Length - 1)
                {
                    trackBlack.Value--;
                }
                chkTrackSingle.Text = "Trac&k single character: (" + uniqueListOfCharacters[trackBlack.Value].ToString() + ")";
                trackBlack.Maximum = uniqueListOfCharacters.Length - 1;
            }

            bmp = new DirectBitmap(width, height);
            List<string> wordMatrix;

            // Contains the color mapping needed to assign each character a unique high contrast color:
            Dictionary<char, Color> colorMapping = new Dictionary<char, Color>();
            if (!chkTrackSingle.Checked)
            {
                colorMapping = GenerateColorsFromCharacters(dataInput);
            }

            wordMatrix = dataInput.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int numberOfTargetedCharacter = 0;
            for (int line = 0; line < wordMatrix.Count; line++)
            {
                for (int column = 0; column < wordMatrix[line].Length; column++)
                {
                    if (zoharMode & !chkTrackSingle.Checked)
                    {
                        switch (wordMatrix[line][column])
                        {
                            case 'א':
                                bmp.SetPixel(column, line, Color.White);
                                break;
                            case 'ב':
                            case 'ג':
                            case 'ד':
                            case 'ה':
                            case 'ו':
                            case 'ז':
                            case 'ח':
                                bmp.SetPixel(column, line, Color.Red);
                                break;
                            case 'ט':
                            case 'י':
                            case 'כ':
                            case 'ך':
                            case 'ל':
                            case 'מ':
                            case 'ם':
                            case 'נ':
                            case 'ן':
                            case 'ס':
                                bmp.SetPixel(column, line, Color.Green);
                                break;
                            case 'ע':
                            case 'פ':
                            case 'ף':
                            case 'צ':
                            case 'ץ':
                            case 'ק':
                            case 'ר':
                            case 'ש':
                            case 'ת':
                                bmp.SetPixel(column, line, Color.Black);
                                break;
                        }
                    } else
                    {
                        if (chkTrackSingle.Checked)
                        {
                            if (wordMatrix[line][column] == uniqueListOfCharacters[trackBlack.Value])
                            {
                                numberOfTargetedCharacter++;
                            }
                            bmp.SetPixel(column, line, wordMatrix[line][column] == uniqueListOfCharacters[trackBlack.Value] ? Color.Black : Color.White);
                        } else
                        {
                            bmp.SetPixel(column, line, colorMapping[wordMatrix[line][column]]);
                        }
                    }
                }
            }
            if (chkTrackSingle.Checked)
            {
                chkTrackSingle.Text = "Trac&k single character: (" + uniqueListOfCharacters[trackBlack.Value].ToString() + ")" + " (" + numberOfTargetedCharacter + " found)";
            }
            lblIndex.Text = "Index: " + trackBlack.Value;
            ow.picOutput.Image = ResizeImage(bmp.Bitmap, ow.picOutput.Width, ow.picOutput.Height);
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            ow.Show();
            Left = (Screen.PrimaryScreen.Bounds.Width / 2) - ((Width + ow.Width) / 2);
            ow.Left = Right;
            Words_To_Letters wtl = new Words_To_Letters();
            wtl.Show();
        }

        private void ChkTrackSingle_CheckedChanged(object sender, EventArgs e) {
            trackBlack.Enabled = chkTrackSingle.Checked;
            RedrawImage();
            if (!chkTrackSingle.Checked)
                chkTrackSingle.Text = "Trac&k single character:";
        }

        /// Source: https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void BtnRemoveChapters_Click(object sender, EventArgs e)
        {
            txtInput.Text = Regex.Replace(txtInput.Text, "Chapter \\d+", "");
            RedrawImage();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RedrawImage();
        }

        private void ChkStretch_CheckedChanged(object sender, EventArgs e)
        {
            stretchImage = chkStretch.Checked;
            RedrawImage();
        }
    }
}