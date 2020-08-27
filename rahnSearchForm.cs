using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  HtmlAgilityPack;
using System.Xml;

namespace RahnMonitor
{
    public partial class rahnSearchForm : Form
    {

        public rahnSearchForm()
        {
            InitializeComponent();
            loginPanel.Visible = true;
            lastUpdatedLabel.Text = "Last updated on 10/08/2020";
        }
  
        // Clears all the text boxes
        public void Clear()
        {
            nameTextBox.Clear();
            idNumberTextBox.Clear();
            dateOfBirthTextBox.Clear();
            cityTextBox.Clear();
            stateProvinceTextBox.Clear();
            countryTextBox.Clear();

        }
        // Hiding most of the Entity coloumns in the preview searchResultPreviewGridView
        public void NewHide() 
        {
            this.searchResultGridView.Columns[0].Visible = false;
            this.searchResultGridView.Columns[2].Visible = false;
            this.searchResultGridView.Columns[3].Visible = false;
            this.searchResultGridView.Columns[4].Visible = false;
            this.searchResultGridView.Columns[5].Visible = false;
            this.searchResultGridView.Columns[6].Visible = false;
            this.searchResultGridView.Columns[7].Visible = false;
            this.searchResultGridView.Columns[8].Visible = false;
            this.searchResultGridView.Columns[9].Visible = false;
            this.searchResultGridView.Columns[10].Visible = false;
            this.searchResultGridView.Columns[11].Visible = false;
            this.searchResultGridView.Columns[12].Visible = false;
            this.searchResultGridView.Columns[13].Visible = false;
            this.searchResultGridView.Columns[14].Visible = false;
            this.searchResultGridView.Columns[15].Visible = false;
            this.searchResultGridView.Columns[17].Visible = false;
            this.searchResultGridView.Columns[20].Visible = false;
        }

        // Hiding Most of the Individual coloumns in the preview searchResultPreviewGridView
        public void NewHide2() 
        {
            this.searchResultGridView.Columns[0].Visible = false;
            this.searchResultGridView.Columns[1].Visible = false;
            this.searchResultGridView.Columns[3].Visible = false;
            this.searchResultGridView.Columns[4].Visible = false;
            this.searchResultGridView.Columns[5].Visible = false;
            this.searchResultGridView.Columns[6].Visible = false;
            this.searchResultGridView.Columns[7].Visible = false;
            this.searchResultGridView.Columns[9].Visible = false;
            this.searchResultGridView.Columns[10].Visible = false;
            this.searchResultGridView.Columns[11].Visible = false;
            this.searchResultGridView.Columns[12].Visible = false;
            this.searchResultGridView.Columns[13].Visible = false;
            this.searchResultGridView.Columns[14].Visible = false;
            this.searchResultGridView.Columns[15].Visible = false;
            this.searchResultGridView.Columns[16].Visible = false;
            this.searchResultGridView.Columns[17].Visible = false;
            this.searchResultGridView.Columns[18].Visible = false;
            this.searchResultGridView.Columns[19].Visible = false;
            this.searchResultGridView.Columns[20].Visible = false;
            this.searchResultGridView.Columns[21].Visible = false;
            this.searchResultGridView.Columns[22].Visible = false;
            this.searchResultGridView.Columns[23].Visible = false;
            this.searchResultGridView.Columns[24].Visible = false;
            this.searchResultGridView.Columns[25].Visible = false;
            this.searchResultGridView.Columns[26].Visible = false;
            this.searchResultGridView.Columns[27].Visible = false;
            this.searchResultGridView.Columns[28].Visible = false;
            this.searchResultGridView.Columns[29].Visible = false;
            this.searchResultGridView.Columns[30].Visible = false;
            this.searchResultGridView.Columns[31].Visible = false;
            this.searchResultGridView.Columns[32].Visible = false;
            this.searchResultGridView.Columns[33].Visible = false;
            this.searchResultGridView.Columns[34].Visible = false;
            this.searchResultGridView.Columns[36].Visible = false;
            this.searchResultGridView.Columns[39].Visible = false;
            this.searchResultGridView.Columns[40].Visible = false;
            this.searchResultGridView.Columns[41].Visible = false;
            this.searchResultGridView.Columns[42].Visible = false;
            this.searchResultGridView.Columns[43].Visible = false;
            this.searchResultGridView.Columns[45].Visible = false;
            this.searchResultGridView.Columns[46].Visible = false;
            this.searchResultGridView.Columns[47].Visible = false;
        }

        // Creates Local Variable so that we can edit the other Forms Controls from this form
        rahnMatchForm matchForm = new rahnMatchForm(); 

        // Creates a new Binding Source
        BindingSource bs = new BindingSource(); 

        //Creates a new List of Entities with all available data
        List<Entity> LoEntities = new Entity().PopulateEntity(); 

        //Creates a new List of Individuals with all available data
        List<Individual> LoIndividuals = new Individual().PopulateIndividual();  

        //Selects row when row header is clicked
        private void searchResultGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) 
        {
            // Clears Text Box viewMoreInfoTextBox
            matchForm.viewMoreInfoTextBox.Clear();
            //Initialize two strings
            string Header, Info = "";

            // When a Row Header is selected this will allow the View More Info Button to Appear
            viewMoreInfoButton.Visible = true;

            for (int i = 0; i < searchResultGridView.SelectedRows[0].Cells.Count; i++)
            {
                //Checks cell for null value
                if (searchResultGridView.SelectedRows[0].Cells[i].Value != null)
                {
                    //Populate two strings Header and Info
                    Info = searchResultGridView.SelectedRows[0].Cells[i].Value.ToString();
                    Header = searchResultGridView.Columns[i].Name.ToString();

                    // Checks if info has a value
                    if (Info != "")
                    {
                        // Checks and replace underscores with a space.
                        if (Header.Contains("_"))
                        {
                            Header = Header.Replace("_", " ");
                        }
                        //Populates viewMoreInfoTextBox with all available data.
                        matchForm.viewMoreInfoTextBox.AppendText("\n" + Header + ": " + Info);
                    }
                }
            }
        }

        // Connects the Entry Text Fields with the Enter Button and call KeyPressed Method
        private void rahnSearchForm_Activated(object sender, EventArgs e) 
        {
            nameTextBox.KeyPress += new KeyPressEventHandler(keypressed);
            idNumberTextBox.KeyPress += new KeyPressEventHandler(keypressed);
            dateOfBirthTextBox.KeyPress += new KeyPressEventHandler(keypressed);
            cityTextBox.KeyPress += new KeyPressEventHandler(keypressed);
            stateProvinceTextBox.KeyPress += new KeyPressEventHandler(keypressed);
            countryTextBox.KeyPress += new KeyPressEventHandler(keypressed);
            usernameTextBox.KeyPress += new KeyPressEventHandler(keypressed2);
            passwordTextBox.KeyPress += new KeyPressEventHandler(keypressed2);
        }

        // Allows ENTER Button To call searchButton.click
        private void keypressed(Object o, KeyPressEventArgs e) 
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                searchButton.PerformClick();
            }
        }

        // Allows ENTER Button To call loginButton.click
        private void keypressed2(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                loginButton.PerformClick();
            }
        }

        // When Login button is clicked Login Panel will disappear to reaveal Rahn Search App UI
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string[] users= new string[5];
            users[0] = "Ray";
            users[1] = "Roche";
            users[2] = "Mike";
            users[3] = "Victor";
            users[4] = "JuanLuke";

            string[] passwords = new string[5];
            passwords[0] = "1";
            passwords[1] = "12";
            passwords[2] = "123";
            passwords[3] = "1234";
            passwords[4] = "12345";

            // Checks if username and password is valid
            if (usernameTextBox.Text!="" && passwordTextBox.Text!="")
            {
               for (int i = 0; i <= 4; i++)
               {
                    username = users[i];
                   password = passwords[i];
                    if (usernameTextBox.Text == username && passwordTextBox.Text == password)
                    {
                          loginPanel.Visible = false;
                    }
                    if (i == 4 && loginPanel.Visible == true)
                        MessageBox.Show("Invalid Password or Username");
               }   
            }
            else
                MessageBox.Show("Please enter username");
        }

        // Clear the text input fields of all other textboxes
        private void nameTextBox_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Clear the text input fields of all other textboxes
        private void idNumberTextBox_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Clear the text input fields of all other textboxes
        private void dateOfBirthTextBox_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Clear the text input fields of all other textboxes
        private void cityTextBox_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Clear the text input fields of all other textboxes
        private void stateProvinceTextBox_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Clear the text input fields of all other textboxes
        private void countryTextBox_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // When the searchButton is clicked it will start by checking if Entity or Individual is selected.
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Checks which type is selected
            if (typeComboBox.Text == "Entity")
            {
                //Creates a List of Entities 
                List<Entity> relevant = new List<Entity>();

                //Creates a boolean 
                bool exists = false;

                foreach (Entity item in LoEntities)
                {
                    // Checks if all textboxes are empty 
                    if (nameTextBox.Text == "" && cityTextBox.Text == "" && stateProvinceTextBox.Text == "" && countryTextBox.Text == "")
                    {
                        // Adds item to List of Entities
                        relevant.Add(item);
                        // Changes the boolean to true
                        exists = true;
                    }
                    // Checks if any textboxes are a match and also that they aren't empty 
                    if (((nameTextBox.Text.ToLower() == item.FIRST_NAME.ToLower()) && nameTextBox.Text != "") ||
                        ((cityTextBox.Text.ToLower() == item.CITY.ToLower()) && cityTextBox.Text != "") ||
                        ((stateProvinceTextBox.Text.ToLower() == item.STATE_PROVINCE.ToLower()) && stateProvinceTextBox.Text != "") ||
                        ((countryTextBox.Text.ToLower() == item.COUNTRY.ToLower()) && countryTextBox.Text != ""))
                    {
                        // Adds item to List of Entities
                        relevant.Add(item);

                        // Changes the boolean to true
                        exists = true;
                    }
                }

                // Checks if boolean was changed to true
                if (exists)
                {
                    // Changes bs.DataSource to list of Entities
                    bs.DataSource = relevant;

                    // Populates searchResultGridView
                    searchResultGridView.DataSource = bs;

                    NewHide();

                    resultsNumberLabel.Visible = true;

                    // Tells you how many matches found
                    resultsNumberLabel.Text = relevant.Count() + " Matches found";
                    for (int i = 0; i < searchResultGridView.ColumnCount; i++)
                    {
                        searchResultGridView.Columns[i].Name = searchResultGridView.Columns[i].Name.Replace("_", " ");
                    }
                }
                else
                {
                    //Empties searchResultGridView
                    searchResultGridView.DataSource = null;

                    // Show message no matches found if there are no matches
                    resultsNumberLabel.Text = "0 Matches found";
                    resultsNumberLabel.Visible = true;
                }
            }

            else if (typeComboBox.Text == "Individual")
            {
                //Creates a List of Individuals 
                List<Individual> relevant = new List<Individual>();

                //Creates a boolean 
                bool exists = false;

                foreach (Individual item in LoIndividuals)
                {
                    // Checks if all textboxes are empty 
                    if (nameTextBox.Text == "" && dateOfBirthTextBox.Text == "" && idNumberTextBox.Text == "" && cityTextBox.Text == "" && stateProvinceTextBox.Text == "" && countryTextBox.Text == "")
                    {
                        // Adds item to List of Individuals
                        relevant.Add(item);

                        // Changes the boolean to true
                        exists = true;
                    }

                    // Checks if any textboxes are a match and also that they aren't empty 
                    if (((nameTextBox.Text.ToLower() == item.FIRST_NAME.ToLower()) && nameTextBox.Text != "") ||
                        ((idNumberTextBox.Text.ToLower() == item.IDNUMBER.ToLower()) && idNumberTextBox.Text != "") ||
                        ((cityTextBox.Text.ToLower() == item.CITY.ToLower()) && cityTextBox.Text != "") ||
                        ((stateProvinceTextBox.Text.ToLower() == item.STATE_PROVINCE.ToLower()) && stateProvinceTextBox.Text != "") ||
                        ((countryTextBox.Text.ToLower() == item.COUNTRY.ToLower()) && countryTextBox.Text != "") ||
                        ((dateOfBirthTextBox.Text.ToLower() == item.DATE_OF_BIRTH.ToLower()) && dateOfBirthTextBox.Text != ""))
                    {
                        // Adds item to List of Individuals
                        relevant.Add(item);

                        // Changes the boolean to true
                        exists = true;
                    }
                }

                // Checks if boolean was changed to true
                if (exists)
                {
                    // Changes bs.DataSource to list of Individuals
                    bs.DataSource = relevant;

                    // Populates searchResultGridView
                    searchResultGridView.DataSource = bs;

                    NewHide2();

                    resultsNumberLabel.Visible = true;

                    // Tells you how many matches found
                    resultsNumberLabel.Text = relevant.Count() + " Matches found";
                    for (int i = 0; i < searchResultGridView.ColumnCount; i++)
                    {
                        searchResultGridView.Columns[i].Name = searchResultGridView.Columns[i].Name.Replace("_", " ");
                    }
                }
                else
                {
                    //Empties searchResultGridView
                    searchResultGridView.DataSource = null;

                    // Show message no matches found if there are no matches
                    resultsNumberLabel.Text = "0 Matches found";
                    resultsNumberLabel.Visible = true;
                }
            }

            else
            {
                MessageBox.Show("   Please select Type! ");
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e) //This will hide the Id Number and date of birth when Entity is selected.
        {
            Clear();
            //Empties searchResultGridView
            searchResultGridView.DataSource = null;
            viewMoreInfoButton.Visible = false;
            resultsNumberLabel.Visible = false;
            if (typeComboBox.SelectedItem.ToString() == "Entity")
            {
                idNumberLabel.Visible = false;
                dateOfBirthLabel.Visible = false;

                idNumberTextBox.Visible = false;
                dateOfBirthTextBox.Visible = false;
            }
            else
            {
                idNumberLabel.Visible = true;
                dateOfBirthLabel.Visible = true;

                idNumberTextBox.Visible = true;
                dateOfBirthTextBox.Visible = true;
            }
        }

        private void viewMoreInfoButton_Click(object sender, EventArgs e) // rahnMatchForm will appear with more information. and viewmorebutton will dissappear
        {
            viewMoreInfoButton.Visible = false;
            matchForm.ShowDialog();
        }
    }
}