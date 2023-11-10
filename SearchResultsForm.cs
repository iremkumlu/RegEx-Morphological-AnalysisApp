using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace RegEx_Morfolojik_Analiz_App
{
    public partial class SearchResultsForm : Form
    {
        private object lstAnalysisResults;

        public SearchResultsForm()
        {
            InitializeComponent();
        }
       
        private void SearchResultsForm_Load(object sender, EventArgs e)
        {

        }

        public SearchResultsForm(List<string> results)
        {
            InitializeComponent();
            DisplayResults(results);
        }
      
        private void DisplayResults(List<string> results)
        {
            lstResults.Items.Clear();
            lstResults.Items.AddRange(results.ToArray());
        }

      
    
    }
}
