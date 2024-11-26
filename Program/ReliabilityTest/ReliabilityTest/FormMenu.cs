using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ReliabilityTest
{
    public partial class FormMenu : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private string ID;
        private int scrWidth;
        private int scrHeight;
        public FormMenu(OleDbConnection dataConnection, bool isManager, string ID)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            this.ID = ID;
            WindowState = FormWindowState.Maximized;
            if(!isManager)
            {
                tablesToolStripMenuItem.Enabled = false;
                addToolStripMenuItem.Enabled = false;
                updateToolStripMenuItem.Enabled = false;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        void Form_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void questionsForCharToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UsersClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblUsers frUsers = new FormTblUsers();
            frUsers.Show();
            frUsers.Disposed += new EventHandler(Form_Disposed);
        }

        private void CitiesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblCities frCities = new FormTblCities();
            frCities.Show();
            frCities.Disposed += new EventHandler(Form_Disposed);
        }

        private void QuestionsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblQuestions frQuestions = new FormTblQuestions();
            frQuestions.Show();
            frQuestions.Disposed += new EventHandler(Form_Disposed);
        }

        private void CharactersClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblCharacters frCharacters = new FormTblCharacters();
            frCharacters.Show();
            frCharacters.Disposed += new EventHandler(Form_Disposed);
        }

        private void QuestionsForCharClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblQuestionsForChar frQuestionsForChar = new FormTblQuestionsForChar();
            frQuestionsForChar.Show();
            frQuestionsForChar.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblForms frForms = new FormTblForms();
            frForms.Show();
            frForms.Disposed += new EventHandler(Form_Disposed);
        }

        private void CharsInFormClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblCharsInForm frCharsInForm = new FormTblCharsInForm();
            frCharsInForm.Show();
            frCharsInForm.Disposed += new EventHandler(Form_Disposed);
        }

        private void QuestionsInFormClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblQuestionsInForm frQuestionsInForm = new FormTblQuestionsInForm();
            frQuestionsInForm.Show();
            frQuestionsInForm.Disposed += new EventHandler(Form_Disposed);
        }

        private void TestsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblTests frTests = new FormTblTests();
            frTests.Show();
            frTests.Disposed += new EventHandler(Form_Disposed);
        }

        private void AnswersInTestClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblAnswersInTest frAnswersInTest = new FormTblAnswersInTest();
            frAnswersInTest.Show();
            frAnswersInTest.Disposed += new EventHandler(Form_Disposed);
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddUsers frAddUsers = new FormAddUsers(dataConnection);
            frAddUsers.Show();
            frAddUsers.Disposed += new EventHandler(Form_Disposed);
        }

        private void addCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCharacters frAddCharacters = new FormAddCharacters(dataConnection);
            frAddCharacters.Show();
            frAddCharacters.Disposed += new EventHandler(Form_Disposed);
        }

        private void addCitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCities frAddCities = new FormAddCities(dataConnection);
            frAddCities.Show();
            frAddCities.Disposed += new EventHandler(Form_Disposed);
        }

        private void addQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddQuestions frAddQuestions = new FormAddQuestions(dataConnection);
            frAddQuestions.Show();
            frAddQuestions.Disposed += new EventHandler(Form_Disposed);
        }

        private void addQuestionsForCharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddQuestionsForChar frAddQuestionsForChar = new FormAddQuestionsForChar(dataConnection);
            frAddQuestionsForChar.Show();
            frAddQuestionsForChar.Disposed += new EventHandler(Form_Disposed);
        }

        private void addFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddForms frAddForms = new FormAddForms(dataConnection);
            frAddForms.Show();
            frAddForms.Disposed += new EventHandler(Form_Disposed);
        }

        private void addCharsInFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCharsInForm frAddCharsInForm = new FormAddCharsInForm(dataConnection);
            frAddCharsInForm.Show();
            frAddCharsInForm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addQuestionsInFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddQuestionsInForm frAddQuestionsInForm = new FormAddQuestionsInForm(dataConnection);
            frAddQuestionsInForm.Show();
            frAddQuestionsInForm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddTests frAddTests = new FormAddTests(dataConnection);
            frAddTests.Show();
            frAddTests.Disposed += new EventHandler(Form_Disposed);
        }

        private void addAnswersInTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddAnswersInTest frAddAnswersInTest = new FormAddAnswersInTest(dataConnection);
            frAddAnswersInTest.Show();
            frAddAnswersInTest.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateUsers frUpdateUsers = new FormUpdateUsers(dataConnection, isManager);
            frUpdateUsers.Show();
            frUpdateUsers.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateQuestions frUpdateQuestions = new FormUpdateQuestions(dataConnection, isManager);
            frUpdateQuestions.Show();
            frUpdateQuestions.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateCharacters frUpdateCharacters = new FormUpdateCharacters(dataConnection, isManager);
            frUpdateCharacters.Show();
            frUpdateCharacters.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateQuestionForCharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateQuestionsForChar frUpdateQuestionsForChar = new FormUpdateQuestionsForChar(dataConnection, isManager);
            frUpdateQuestionsForChar.Show();
            frUpdateQuestionsForChar.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateForms frUpdateForms = new FormUpdateForms(dataConnection, isManager);
            frUpdateForms.Show();
            frUpdateForms.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateQuestionsInFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateQuestionsInForm frUpdateQuestionsInForm = new FormUpdateQuestionsInForm(dataConnection, isManager);
            frUpdateQuestionsInForm.Show();
            frUpdateQuestionsInForm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateTests frUpdateTests = new FormUpdateTests(dataConnection, isManager);
            frUpdateTests.Show();
            frUpdateTests.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateAnswersInTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateAnswersInTest frUpdateAnswersInTest = new FormUpdateAnswersInTest(dataConnection, isManager);
            frUpdateAnswersInTest.Show();
            frUpdateAnswersInTest.Disposed += new EventHandler(Form_Disposed);
        }

        private void createTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTestCreate frTestCreate = new FormTestCreate(dataConnection,ID);
            frTestCreate.Show();
            frTestCreate.Disposed += new EventHandler(Form_Disposed);
        }

        private void testFormReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            FormRptTestForm frRptTestForm = new FormRptTestForm(dataConnection, isManager);
            frRptTestForm.Show();
            frRptTestForm.Disposed += new EventHandler(Form_Disposed);
        }

        private void testQustionsByCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptQuestionsByCharacter frRptQuestionsByCharacter = new FormRptQuestionsByCharacter(dataConnection, isManager);
            frRptQuestionsByCharacter.Show();
            frRptQuestionsByCharacter.Disposed += new EventHandler(Form_Disposed);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptTest frRptTest = new FormRptTest(dataConnection, isManager);
            frRptTest.Show();
            frRptTest.Disposed += new EventHandler(Form_Disposed);
        }

        private void doATestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTestExamination frTestExamination = new FormTestExamination(dataConnection, isManager);
            frTestExamination.Show();
            frTestExamination.Disposed += new EventHandler(Form_Disposed);
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchUsers frSearchUsers = new FormSearchUsers(dataConnection);
            frSearchUsers.Show();
            frSearchUsers.Disposed += new EventHandler(Form_Disposed);
        }

        private void searchQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchQuestions frSearchQuestions = new FormSearchQuestions(dataConnection);
            frSearchQuestions.Show();
            frSearchQuestions.Disposed += new EventHandler(Form_Disposed);
        }

        private void searchCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchCharacters frSearchCharacters = new FormSearchCharacters(dataConnection);
            frSearchCharacters.Show();
            frSearchCharacters.Disposed += new EventHandler(Form_Disposed);
        }

        private void searchFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchForms frSearchForms = new FormSearchForms(dataConnection);
            frSearchForms.Show();
            frSearchForms.Disposed += new EventHandler(Form_Disposed);
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            scrWidth = Width;
            scrHeight = Height;
            label1.Location = new Point((scrWidth - label1.Size.Width) / 2, label1.Location.Y);
            label2.Location = new Point((scrWidth - label2.Size.Width) / 2, label2.Location.Y);
        }

        private void חיפושתשובותבמבחןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchAnswersInTest frSearchAnswersInTest = new FormSearchAnswersInTest(dataConnection);
            frSearchAnswersInTest.Show();
            frSearchAnswersInTest.Disposed += new EventHandler(Form_Disposed);
        }

        private void חיפושתכונותבטופסToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchCharsInForm frSearchCharsInForm = new FormSearchCharsInForm(dataConnection);
            frSearchCharsInForm.Show();
            frSearchCharsInForm.Disposed += new EventHandler(Form_Disposed);
        }

        private void חיפושעריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchCities frSearchCities = new FormSearchCities(dataConnection);
            frSearchCities.Show();
            frSearchCities.Disposed += new EventHandler(Form_Disposed);
        }

        private void חיפוששאלותלתכונהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchQuestionsForChar frSearchQuestionsForChar = new FormSearchQuestionsForChar(dataConnection);
            frSearchQuestionsForChar.Show();
            frSearchQuestionsForChar.Disposed += new EventHandler(Form_Disposed);
        }

        private void חיפוששאלותבטופסToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchQuestionsInForm frSearchQuestionsInForm = new FormSearchQuestionsInForm(dataConnection);
            frSearchQuestionsInForm.Show();
            frSearchQuestionsInForm.Disposed += new EventHandler(Form_Disposed);
        }

        private void חיפושמבחניםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchTests frSearchTests = new FormSearchTests(dataConnection);
            frSearchTests.Show();
            frSearchTests.Disposed += new EventHandler(Form_Disposed);
        }

        private void תרשיםשאלותלטופסיבחינהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartQuestionsInTestForm frChartQuestionsInTestForm = new FormChartQuestionsInTestForm(dataConnection);
            frChartQuestionsInTestForm.Show();
            frChartQuestionsInTestForm.Disposed += new EventHandler(Form_Disposed);
        }

        private void תרשיםשאלותלתכונותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartQuestionsByPropertiy frChartQuestionsByPropertiy = new FormChartQuestionsByPropertiy(dataConnection);
            frChartQuestionsByPropertiy.Show();
            frChartQuestionsByPropertiy.Disposed += new EventHandler(Form_Disposed);
        }

        private void תרשיםשאלותלמבחניםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartQuestionsByTest frChartQuestionsByTest = new FormChartQuestionsByTest(dataConnection);
            frChartQuestionsByTest.Show();
            frChartQuestionsByTest.Disposed += new EventHandler(Form_Disposed);
        }
    }
}
