using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegEx_Morfolojik_Analiz_App
{
    public partial class AnalysisResultsForm : Form
    {
        public AnalysisResultsForm()
        {
            InitializeComponent();
        }

        private void AnalysisResultsForm_Load(object sender, EventArgs e)
        {

        }
        public AnalysisResultsForm(List<string> uniqueWords, List<string> roots, List<string> morphemes)
        {
            InitializeComponent();

            // Sonuçları ListBox'a ekle
            lstAnalysisResults.Items.Add("Unique Words:");
            lstAnalysisResults.Items.AddRange(uniqueWords.ToArray());
            lstAnalysisResults.Items.Add("Roots:");
            lstAnalysisResults.Items.AddRange(roots.ToArray());
            lstAnalysisResults.Items.Add("Morphemes:");
            lstAnalysisResults.Items.AddRange(morphemes.ToArray());
        }
    }
}
