using M64MM.Utils;
using Shapeshift.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Shapeshift
{
    public partial class mainForm : Form
    {
        string IsLatestVersion = "Unknown";
        string LatestVersion = "Unknown";
        static string CreatorName = "vazhka-dolya";
        static string AddonLinkName = "Shapeshift";
        static string AddonReleaseName = "Shapeshift";

        static frmAbout about = new frmAbout();

        uint ModelPointer = 0;

        public mainForm()
        {
            InitializeComponent();
            this.Text = $"Shapeshift v{ProductVersion}";
            this.Load += mainForm_Load;
        }

        private byte[] GetOneByteAsArray(int address)
        {
            return new byte[] { Core.ReadBytes(Core.BaseAddress + address, 1)[0] };
        }

        private void InjectExtractor()
        {
            FindModelPointer();
            Core.WriteBytes(Core.BaseAddress + 0x3145D0, Core.SwapEndian(Extractor.Injection1, 4));
            Core.WriteBytes(Core.BaseAddress + 0x310000, Core.SwapEndian(Extractor.Injection2, 4));
            Core.WriteBytes(Core.BaseAddress + 0x2CB1C0, Core.SwapEndian(Extractor.Injection3, 4));
            Core.WriteBytes(Core.BaseAddress + 0x2CA6D0, Core.SwapEndian(Extractor.Injection4, 4));
        }

        private void ModelSave()
        {
            FindModelPointer();
            long ExtractedModelPointerStart = Core.BaseAddress + 0x781EE0;
            long ExtractedModelPointerEnd = Core.BaseAddress + 0x7B9EE0;
            long ExtractedModelSize = ExtractedModelPointerEnd - ExtractedModelPointerStart;
            bool ProceedToExtract = false;

            if (BitConverter.ToUInt32(Core.ReadBytes(Core.BaseAddress + 0x781EE0, 4), 0) == 0)
            {
                DialogResult result = MessageBox.Show(Resources.ExtractWarning, Resources.ExtractWarningTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) ProceedToExtract = true;
            }
            else ProceedToExtract = true;

            if (ProceedToExtract)
            {

                byte[] ExtractedModelData =
                Core.SwapEndian(
                    Core.ReadBytes(ExtractedModelPointerStart, ExtractedModelSize), 4
                    );

                string PathName = Path.Combine(
                    Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Addons\\Shapeshift\\"
                    );
                if (!Directory.Exists(PathName)) Directory.CreateDirectory(PathName);

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = PathName;
                saveFileDialog1.Filter = Resources.SelectExtension;
                saveFileDialog1.Title = Resources.SelectSave;
                saveFileDialog1.FileName = Resources.SelectDefaultFilename;
                saveFileDialog1.OverwritePrompt = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, ExtractedModelData);
                }
            }
        }

        private void ModelLoad()
        {
            FindModelPointer();
            string PathName = Path.Combine(
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Addons\\Shapeshift\\"
                );
            if (!Directory.Exists(PathName)) Directory.CreateDirectory(PathName);

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = PathName;
            openFileDialog1.Filter = Resources.SelectExtension;
            openFileDialog1.Title = Resources.SelectOpen;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] ExtractedModelData = File.ReadAllBytes(openFileDialog1.FileName);
                Core.WriteBytes(Core.BaseAddress + 0x781EE0, Core.SwapEndian(ExtractedModelData, 4));
                Core.WriteBytes(Core.BaseAddress + ModelPointer, BitConverter.GetBytes(0x80781EE0));
            }
        }

        private void MarioLoad()
        {
            Core.WriteBytes(Core.BaseAddress + ModelPointer, BitConverter.GetBytes(0x800F0860));
        }

        private void Fast64Load()
        {
            Core.WriteBytes(Core.BaseAddress + ModelPointer, BitConverter.GetBytes(0x80117E30));
        }

        private void FindModelPointer()
        {
            Core.UpdateCoreEntityAddress();
            ModelPointer = Core.CoreEntityAddress + 0x14;
            UpdatePointerLabel();
        }

        private void UpdatePointerLabel()
        {
            labelModelPointer.Text = Resources.labelModelPointerString + ModelPointer.ToString("X");
        }

        public static byte[] AppendBytes(byte[] original, byte[] toAppend)
        {
            byte[] combined = new byte[original.Length + toAppend.Length];
            Buffer.BlockCopy(original, 0, combined, 0, original.Length);
            Buffer.BlockCopy(toAppend, 0, combined, original.Length, toAppend.Length);
            return combined;
        }

        private void StayOnTop()
        {
            this.TopMost = stayOnTopToolStripMenuItem.Checked;
        }

        // Version search methods

        private async void mainForm_Load(object sender, EventArgs e)
        {
            await CheckForUpdates();
        }

        private void UpdatesButtonPress()
        {
            switch (IsLatestVersion)
            {
                case "True":
                    Process.Start($"https://github.com/{CreatorName}/{AddonLinkName}/releases");
                    break;
                case "False":
                    Process.Start($"https://github.com/{CreatorName}/{AddonLinkName}/releases/latest");
                    break;
                default:
                    DialogResult result = MessageBox.Show(
                        Resources.updates_unknown_elaborate,
                        Resources.updates_unknown_string,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        Process.Start($"https://github.com/{CreatorName}/{AddonLinkName}/releases/latest");
                    }
                    break;
            }
        }

        private async Task CheckForUpdates()
        {
            optionsToolStripMenuItem.Image = Resources.updates_unknown;
            updatesToolStripMenuItem.Image = Resources.updates_unknown;
            updatesToolStripMenuItem.Text = Resources.updates_checking_string;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", $"{AddonLinkName}")
;
                    var LatestResponse = await client.GetStringAsync($"https://api.github.com/repos/{CreatorName}/{AddonLinkName}/releases/latest");

                    JObject json = JObject.Parse(LatestResponse);
                    LatestVersion = (string)json["name"];

                    if ($"{AddonReleaseName} v" + ProductVersion == LatestVersion)
                        IsLatestVersion = "True";
                    else IsLatestVersion = "False";
                }
            }
            catch
            {
                IsLatestVersion = "Unknown";
                LatestVersion = "Unknown";
            }

            switch (IsLatestVersion)
            {
                case "True":
                    optionsToolStripMenuItem.Image = Resources.updates_latest;
                    updatesToolStripMenuItem.Image = Resources.updates_latest;
                    updatesToolStripMenuItem.Text = Resources.updates_latest_string;
                    break;
                case "False":
                    optionsToolStripMenuItem.Image = Resources.updates_outdated;
                    updatesToolStripMenuItem.Image = Resources.updates_outdated;
                    updatesToolStripMenuItem.Text = Resources.updates_outdated_string;
                    break;
                default:
                    optionsToolStripMenuItem.Image = Resources.updates_unknown;
                    updatesToolStripMenuItem.Image = Resources.updates_unknown;
                    updatesToolStripMenuItem.Text = Resources.updates_unknown_string;
                    break;
            }
        }

        // UI

        private void buttonFindModel_Click(object sender, EventArgs e)
        {
            FindModelPointer();
        }

        private void buttonInjectExtractor_Click(object sender, EventArgs e)
        {
            InjectExtractor();
        }

        private void buttonSaveModel_Click(object sender, EventArgs e)
        {
            ModelSave();
        }

        private void buttonLoadModel_Click(object sender, EventArgs e)
        {
            ModelLoad();
        }

        private void buttonLoadMario_Click(object sender, EventArgs e)
        {
            MarioLoad();
        }

        private void buttonLoadF64_Click(object sender, EventArgs e)
        {
            Fast64Load();
        }

        private void stayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StayOnTop();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatesButtonPress();
        }

        private async void updatesRefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await CheckForUpdates();
        }
    }
}