using EpsilonNet.CodingSchool2022.UniversityLib;
using System;
using System.IO;
using System.Windows.Forms;

namespace EpsilonNet.CodingSchool2022.Session_07_08
{
    public partial class UniversityForm : Form
    {
        private const string JsonFileName = "university.json";

        private University _university;

        private Professor _activeProfessor;

        private Professor ActiveProfessor
        {
            get => _activeProfessor;
            set
            {
                if (value == _activeProfessor)
                    return;

                if (_activeProfessor != null)
                {
                    _activeProfessor.Name = tbProfName.Text;
                    _activeProfessor.Age = (int) tbProfAge.Value;
                    if (int.TryParse(tbProfAge.Text, out int age))
                        _activeProfessor.Age = age;
                }

                _activeProfessor = value;
            }
        }

        public UniversityForm()
        {
            InitializeComponent();
        }

        private static University CreateUniversity()
        {
            return new University
            {
                Name = "Theodore's University",
                YearsInService = 184
            };
        }

        private University LoadUniversity(bool notifyDataNotFound)
        {
            try
            {
                return UniversitySerialization.ReadFromFile(JsonFileName) ?? CreateUniversity();
            }
            catch (FileNotFoundException)
            {
                string fullPath = Path.GetFullPath(JsonFileName);
                if (notifyDataNotFound)
                    MessageBox.Show(this, $"The university data file was not found. It will be created at {fullPath}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return CreateUniversity();
            }
        }

        private static string FormatProfessorListItem(Professor prof) => prof.GetName() ?? "<null>";

        private void UpdateViewState()
        {
            lbProfessors.Items.Clear();
            foreach (var prof in _university.Professors)
                lbProfessors.Items.Add(FormatProfessorListItem(prof));
            if (_university.Professors.Count != 0)
            {
                lbProfessors.SelectedIndex = 0;
            }

            tbUniversityName.Text = _university.Name;
            nudUniversityYearsInService.Value = _university.YearsInService;
        }

        private void UniversityForm_Load(object sender, EventArgs e)
        {
            _university = LoadUniversity(true);
            UpdateViewState();
        }

        private void UniversityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cbCommitOnClose.Checked)
                CommitChanges();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            CommitChanges();
        }

        private void CommitChanges()
        {
            _university.Name = tbUniversityName.Text;
            _university.YearsInService = (int)nudUniversityYearsInService.Value;
            UniversitySerialization.WriteToFile(_university, JsonFileName);
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            _university = LoadUniversity(false);
            UpdateViewState();
        }

        private void btnNewProfessor_Click(object sender, EventArgs e)
        {
            var newProf = new Professor();
            _university.Professors.Add(newProf);
            ActiveProfessor = newProf;
        }
    }
}
