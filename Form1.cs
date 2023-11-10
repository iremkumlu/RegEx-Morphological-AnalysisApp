using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static RegEx_Morfolojik_Analiz_App.MorphologicalAnalyzer;

namespace RegEx_Morfolojik_Analiz_App
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> spellingCorrections = new Dictionary<string, string>();
       
        private object txtAnalysisResults;
        private ListBox lstAnalysisResults;
        private void LoadSpellingCorrections()
        {
        }

        public Form1()
        {
            InitializeComponent();
            LoadSpellingCorrections();
        }

        private string CorrectSpellingAndRemovePunctuation(string input)
        {
            // Sözlüğü kullanarak yazımı düzeltme
            string correctedInput = input;

            foreach (var correction in spellingCorrections)
            {
                correctedInput = correctedInput.Replace(correction.Key, correction.Value);
            }

            // Normal ifade kullanarak noktalama işaretlerini kaldırma
            correctedInput = Regex.Replace(correctedInput, @"[\p{P}-[']]|\s+", " ");
            return correctedInput;
        }


        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt|All Files|*.*"; // Metin dosyaları ve tüm dosyalar için bir filtre belirtme
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName; // Seçilen dosyanın yolunu almak için ofd.FileName kullanımı
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            string pattern = txtRegexPattern.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Lütfen geçerli bir dosya seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(pattern))
            {
                MessageBox.Show("Lütfen normal bir ifade modeli girin.");
                return;
            }

            string fileContents = File.ReadAllText(filePath);
            List<string> matches = RegexHelper.FindRegexMatches(fileContents, pattern);

            if (matches.Count == 0)
            {
                MessageBox.Show("Hiçbir sonuç bulunamadı.");
                return;
            }

            // Sonuç formunu oluşturma ve görüntüleme
            SearchResultsForm resultsForm = new SearchResultsForm(matches);
            resultsForm.Show();
        }



        private void btnGetMorphologyAnalytics_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Please select a valid file.");
                return;
            }

            string fileContents = File.ReadAllText(filePath);
            string cleanedText = CorrectSpellingAndRemovePunctuation(fileContents);
            lstAnalysisResults.Items.Add("Cleaned Text:\n\n" + cleanedText);

            MorphologicalAnalyzer analyzer = new MorphologicalAnalyzer();

            List<string> uniqueWords = analyzer.AnalyzeUniqueWords(cleanedText);
            List<string> roots = analyzer.AnalyzeRoots(cleanedText);
            List<string> morphemes = analyzer.AnalyzeMorphemes(cleanedText);

            ShowMorphologicalAnalysisResults(uniqueWords, roots, morphemes);
            btnGetMorphologyAnalytics.Click += new System.EventHandler(this.btnGetMorphologyAnalytics_Click);
        }

        private void ShowMorphologicalAnalysisResults(List<string> uniqueWords, List<string> roots, List<string> morphemes)
        {
            string results = "Unique Words:\n" + string.Join(", ", uniqueWords) + "\n\n" +
                                 "Roots:\n" + string.Join(", ", roots) + "\n\n" +
                                 "Morphemes:\n" + string.Join(", ", morphemes);

            lstAnalysisResults.Items.Add("Morphological Analysis Results:\n\n" + results);
        }

    }


}

