using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhosInSpace {
	public partial class WhosInSpaceForm : Form {
		private readonly HttpClient httpClient = new HttpClient();
		private string lastJson;

		public WhosInSpaceForm() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			LoadAstros();
		}

		private void ShowAstros(Astros astros) {
			astrosListBox.Items.Clear();
			foreach (Astronaut astro in astros.Astronauts) {
				astrosListBox.Items.Add(string.Format("{0} ({1})", astro.Name, astro.Craft));
			}
		}

		private async Task LoadAstros() {
			string loadedJson = "...";
			try {
				Uri uri = new Uri(urlTextBox.Text);
				var getStringTask = httpClient.GetStringAsync(uri);
				loadedJson = await getStringTask;
				var astros = JsonSerializer.Deserialize<Astros>(loadedJson);

				ShowAstros(astros);
				lastJson = loadedJson;
				viewJson.Enabled = true;
			} catch (JsonException e) {
				var response = MessageBox.Show("When refreshing, a JSON error occurred:\n---\n" + e.Message + "\n---\nWould you like to view the JSON?", "JSON Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				if (response == DialogResult.Yes) {
					string text = e.Message + Environment.NewLine
						+ "---" + Environment.NewLine
						+ loadedJson.Replace("\n", Environment.NewLine);
					TextDisplayForm form = new TextDisplayForm(text);
					form.Text = "JSON Error";
					form.Show(this);
				}
			} catch (Exception e) {
				MessageBox.Show("When refreshing, an error occurred:\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
			LoadAstros();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("\"Who's in Space?\"\n"
				+ "Author: Ozzy Callooh\n"
				+ "#47 from \"Exercises for Programmers\" by Brian P. Hogan\n"
				+ "Source data from http://open-notify.org",
				"About",
				MessageBoxButtons.OK
			);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e) {
			LoadAstros();
		}

		private void viewJSONToolStripMenuItem_Click(object sender, EventArgs e) {
			TextDisplayForm form = new TextDisplayForm(lastJson.Replace("\n", Environment.NewLine));
			form.Text = "View JSON";
			form.Show(this);
		}
	}
}
