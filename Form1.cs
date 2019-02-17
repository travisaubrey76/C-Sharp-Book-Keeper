using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

/// <summary>
/// Author: Travis Aubrey
/// Red id: 814041534
/// Date Completed: 2/11/2019
/// Project 2 Date Completed: 2/18/2019
/// 
/// Summary: Basic intro program to summarize my knowledge on C# as learned through SDSU's CompE 361 class. Most methods known, but a lot of shortcuts
///          were found via research! Everything borrowed, manipulated and turned mine have been documented. Please let me know if this type of documentation
///          is sufficient or if more is needed!
///          
///         Project 2 utilizes the same as the above, but we are grabbing the book information from an existing file and then upon confirming the order, writing
///         the order to a new file deemed "orders.txt"
/// 
/// Changelog: Changed the way I created objects. Changed where my Books class is located from seperate file to same file as Main_Menu (just makes
///            it a tad easier for a small program like this so I don't get lost amongst many class files when there aren't many necessary)
///            
/// PROJECT 2 CHANGELOG: Since this same framework is being used to update the reading and writing portion. I will just amend my current code to accomodate the new
///                      requirements. Therefore, following changes will apear in this section as necessary.
/// 
/// Ideas:
///         -Thinking about utilizing additional techniques, if I can remember them.
///         -Can decrease variable memory size if needed for further optomizations.
///         
/// Credits (if any): Seen above methods in their comment sections.
///     
///         I found something that was a bit of a pain... by default a Windows Form application does not allow you to see the console.. so a Console.WriteLine("anything"); 
///         could not be seen for debugging... I was able to find a workaround to show me what I wanted to see and I found out how to enable a different output here:
///         https://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
///         This allowed me to have both my forms application load and see a debugging window via Console.
/// 
/// 
/// Comments/Concerns: Email me at travisaubrey76@gmail.com
/// 
/// </summary>



namespace Compe561_Project1
{
    public partial class Main_Menu : Form
    {

        /// <summary>
        /// Required books class
        /// </summary>
        private class Books
        {
            public string Author;
            public string ISBN;
            public string Price;
            public string Title;

            public Books(string author, string iSBN, string price, string title)
            {
                Author = author;
                ISBN = iSBN;
                Price = price;
                Title = title;
            }
            
            //Defailt constructor needed when not implicitly creating books as per part 1 of this project
            public Books()
            {

            }
        }


        // Making these objects "global" for this scope just so it's easy to access these... plus I don't intend for them to change during program execution
        Books bookOne = new Books("Book 1 Author", "00000", "20", "How to get an easy A: Book 1");
        Books bookTwo = new Books("Book 2 Author", "11111", "30", "Senior Semester Projects: Book 2");
        Books bookThree = new Books("Book 3 Author", "22222", "40", "C# for Dummies: Book 3");

        //Global variables for total end price.
        int subTotal = 0;
        double totalPrice = 0;
        double tax = 0;

        //This is where I needed systems.Collection
        ArrayList myArrayList = new ArrayList();
        String recordIn;
        String[] fields;

        List<String> encodingStringArray = new List<string>();


        //CONSTANT STRINGS defined for what is in my book.txt file
        const String fileTitle1 = "testTitle1";
        const String fileTitle2 = "testTitle2";


        /// <summary>
        /// This is where I would need to call my loops to read the book information from the text file so that it loads as the form is loaded.
        /// </summary>
        public Main_Menu()
        {
            InitializeComponent();



            //Generating items for initial book select combo box on form creation
            bookSelectComboBox.Items.Add(bookOne.Title);
            bookSelectComboBox.Items.Add(bookTwo.Title);
            bookSelectComboBox.Items.Add(bookThree.Title);

            DataGridSetup();
            quantityUserInputTextBox.Text = "1";

            //Preset the subtotal, tax, and total boxes
            subtotalTextBox.Text = subTotal.ToString("C");
            taxTextBox.Text = tax.ToString("C");
            totalTextBox.Text = totalPrice.ToString("C");


            //Testing FileStream Write capabilities
            //FileStream test = new FileStream("testtext.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter testWriter = new StreamWriter(test);
            //string text = "test";
            //testWriter.WriteLine(text);
            //testWriter.Close();
            //test.Close();

            //As required and shown on the slides for the course under filestreamIO.ppt
            const char DELIMITER = ':';
            const String FILENAME = "book.txt";

            

            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);



            recordIn = reader.ReadLine();

            while(recordIn != null)
            {
                Books bk = new Books();
                fields = recordIn.Split(DELIMITER);
                bk.Title = fields[0];
                bk.Author = fields[1];
                bk.ISBN = fields[2];
                bk.Price = fields[3];

                myArrayList.Add(bk);

                recordIn = reader.ReadLine();

            }

            reader.Close();
            inFile.Close();

            //This portion would be where I send my books into the form application combobox
            foreach(Books bk_data in myArrayList)
            {
                Console.WriteLine("{0} {1} {2} {3}", bk_data.Title, bk_data.Author, bk_data.ISBN, bk_data.Price);
                bookSelectComboBox.Items.Add(bk_data.Title);

                //Add the 4 items to a single dimension list<STRING>
                encodingStringArray.Add(bk_data.Title);
                encodingStringArray.Add(bk_data.Author);
                encodingStringArray.Add(bk_data.ISBN);
                encodingStringArray.Add(bk_data.Price);
            }

            

            //String[] finalImportedArray = (String[]) myArrayList.ToArray(typeof(string));

            //for(int i = 0;  i < finalImportedArray.Length; i++)
            //{
            //    Console.WriteLine("\t[{0}]:\t{1}", i, finalImportedArray[i]);
            //}


        }

        
        /// <summary>
        /// Adds the selected book into the DataGridView
        /// 
        /// Also added some data type validation to check for empty or bad user input selections
        /// 
        /// Attempted a try catch block, but couldn't get a simple isNullorWhitespace() check to work correctly in the try section
        /// 
        /// Calling update totals function in most places ensuring constant updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTitleButton_Click(object sender, EventArgs e)
        {
            int qty;

            if (String.IsNullOrWhiteSpace(quantityUserInputTextBox.Text))
            {
                MessageBox.Show($"Please enter a valid number greater than 0! Currently quantity is empty.");
                quantityUserInputTextBox.Text = "1";
                quantityUserInputTextBox.Focus();
            }
            else if ( (qty = int.Parse(quantityUserInputTextBox.Text)) != 0 )
            {
                if (bookSelectComboBox.Text.Equals(bookOne.Title))
                {
                    dataGridView1.Rows.Add(bookOne.Title, int.Parse(bookOne.Price).ToString("C"), qty.ToString(), (qty * int.Parse(bookOne.Price)).ToString("C"));
                    quantityUserInputTextBox.Text = "1";
                    updateTotals();
                }
                else if (bookSelectComboBox.Text.Equals(bookTwo.Title))
                {
                    dataGridView1.Rows.Add(bookTwo.Title, int.Parse(bookTwo.Price).ToString("C"), qty.ToString(), (qty * int.Parse(bookTwo.Price)).ToString("C"));
                    quantityUserInputTextBox.Text = "1";
                    updateTotals();
                }
                else if (bookSelectComboBox.Text.Equals(bookThree.Title))
                {
                    dataGridView1.Rows.Add(bookThree.Title, int.Parse(bookThree.Price).ToString("C"), qty.ToString(), (qty * int.Parse(bookThree.Price)).ToString("C"));
                    quantityUserInputTextBox.Text = "1";
                    updateTotals();
                }
                else if (bookSelectComboBox.Text.Equals(encodingStringArray[0])) //<-- Change this number if needed and for the following blocks as well
                {
                    dataGridView1.Rows.Add(encodingStringArray[0], int.Parse(encodingStringArray[3]).ToString("C"), qty.ToString(), (qty * int.Parse(encodingStringArray[3])).ToString("C"));
                    quantityUserInputTextBox.Text = "1";
                    updateTotals();
                }
                else if (bookSelectComboBox.Text.Equals(encodingStringArray[4]))
                {
                    dataGridView1.Rows.Add(encodingStringArray[4], int.Parse(encodingStringArray[7]).ToString("C"), qty.ToString(), (qty * int.Parse(encodingStringArray[7])).ToString("C"));
                    quantityUserInputTextBox.Text = "1";
                    updateTotals();
                }
                else //Keep entries blank
                {
                    author_TextBox.Text = "";
                    quantityUserInputTextBox.Text = "1";
                    MessageBox.Show($"Please select a valid book - currently, a book is not selected!");
                    bookSelectComboBox.Focus(); //Per part 2 instructions
                    updateTotals();
                }
            }
            else //entered quanitity is 0 thus don't add anything to data grid view
            {
                MessageBox.Show($"The Quantity Box is a zero value, please enter a number greater than 0.");
                quantityUserInputTextBox.Focus();

            }
        }

        /// <summary>
        /// Function called to update totals as books are added
        /// 
        /// In addition, I was able to utilize the int.parse method with this:
        /// https://stackoverflow.com/questions/4094334/how-to-format-a-currency-string-to-integer
        /// </summary>
        private void updateTotals()
        {
            subTotal = 0;

            // Since the headers count as a row... if there is 1 row it means the grid is empty
            if(dataGridView1.Rows.Count <= 1) //Check if my data grid is empty
            {
                //Do nothing essentially
                //MessageBox.Show($"EMPTY"); <-- This was for testing in Lab1
            }
            else //If not empty
            {
                for (int row = 0; row < dataGridView1.Rows.Count - 1; row++)
                {
                    //subTotal += int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString());
                     subTotal += int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString(), System.Globalization.NumberStyles.Currency);
                }

                tax = (subTotal * .1);
                totalPrice = subTotal + tax;
            }

            subtotalTextBox.Text = subTotal.ToString("C");
            taxTextBox.Text = tax.ToString("C");
            totalTextBox.Text = totalPrice.ToString("C");

        }

        /// <summary>
        /// Called when user selects something from the title select combo box. useful since the form loads empty. If you need to change the amount
        /// of needed books then it can be easily entered by copying and pasting the final statement and incrementing the index marker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bookSelectComboBox.Text.Equals(bookOne.Title))
            {
                author_TextBox.Text = bookOne.Author;
                isbn_TextBox.Text = bookOne.ISBN;
                bookPriceTextBox.Text = int.Parse(bookOne.Price).ToString("C");
            }
            else if (bookSelectComboBox.Text.Equals(bookTwo.Title))
            {
                author_TextBox.Text = bookTwo.Author;
                isbn_TextBox.Text = bookTwo.ISBN;
                bookPriceTextBox.Text = int.Parse(bookTwo.Price).ToString("C");
            }
            else if (bookSelectComboBox.Text.Equals(bookThree.Title))
            {
                author_TextBox.Text = bookThree.Author;
                isbn_TextBox.Text = bookThree.ISBN;
                bookPriceTextBox.Text = int.Parse(bookThree.Price).ToString("C");
            }
            else if (bookSelectComboBox.Text.Equals(encodingStringArray[0]))
            {
                author_TextBox.Text = encodingStringArray[1];
                isbn_TextBox.Text = encodingStringArray[2];
                bookPriceTextBox.Text = int.Parse(encodingStringArray[3]).ToString("C");
            }
            else if (bookSelectComboBox.Text.Equals(encodingStringArray[4]))
            {
                author_TextBox.Text = encodingStringArray[5];
                isbn_TextBox.Text = encodingStringArray[6];
                bookPriceTextBox.Text = int.Parse(encodingStringArray[7]).ToString("C");
            }
            else //Keep entries blank
            {
                author_TextBox.Text = "";
                isbn_TextBox.Text = "";
                bookPriceTextBox.Text = "";
            }
        }


        /// <summary>
        /// This is where I would be outputting my confirmed order to order.txt
        /// In addition, for the second lab - I did some research outside of the available documents for a more efficinet way to handle
        /// IO exceptions as per the requirements. I stumbled upon using a specific keyword within a try/catch block that allows us to
        /// open/create the order.txt file and then test for an io exception thus eliminating a "racing" condition. Please see the
        /// following link for more information and where the inspiration came from:
        /// https://stackoverflow.com/questions/86766/how-to-properly-handle-exceptions-when-performing-file-io
        /// 
        /// In addition, from the MSDN docs, I also found out that the using statement automatically flushes the streamwriter in a
        /// more efficient manner than what is shown on the slides:
        /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file
        /// 
        /// Wanted to find a clever way to add a timestamp to a persistent orders page to differentiate when different orders took place.
        /// Found that in the following MSDN documentation:
        /// https://docs.microsoft.com/en-us/dotnet/api/system.datetime.toshorttimestring?redirectedfrom=MSDN&view=netframework-4.7.2#System_DateTime_ToShortTimeString
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmOrderButton_Click(object sender, EventArgs e)
        {


            if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show($"Purchase Order is empty, please add some books!");
            }
            else
            {
                MessageBox.Show($"Purchase Order is complete!");


                //This is where we send the information to an output file
                try
                {
                    //This will create my file and flush the StreamWriter for me! Very useful!
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Travis\source\repos\TravisAubrey_Lab1\Compe561_Project1\bin\Debug\orders.txt", true))
                    {
                        file.WriteLine("------------------------  Order Created: {0} ------------------------", DateTime.Now.ToString("HH:mm:ss tt")); //<--- This will be my order dividing header

                        // Traversing my dataGridView
                        if (dataGridView1.Rows.Count <= 1) //Check if my data grid is empty
                        {
                            //Do nothing essentially
                            //MessageBox.Show($"EMPTY"); <-- This was for testing in Lab1
                        }
                        else //If not empty
                        {
                            for (int row = 0; row < dataGridView1.Rows.Count - 1; row++) //Below adds information to file.
                            {
                                //subTotal += int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString());
                                //subTotal += int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString(), System.Globalization.NumberStyles.Currency);
                                file.WriteLine("Book:{0}\tPrice:{1}\tQTY:{2}\tTotal:{3}", dataGridView1.Rows[row].Cells[0].Value.ToString(), dataGridView1.Rows[row].Cells[1].Value.ToString(), 
                                    dataGridView1.Rows[row].Cells[2].Value.ToString(), dataGridView1.Rows[row].Cells[3].Value.ToString());
                            }
                            file.WriteLine("------------> Subtotal:{0} \tTax:{1}\tTotal:{2} <------------", subtotalTextBox.Text.ToString(), taxTextBox.Text.ToString(), totalTextBox.Text.ToString());
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("An IO exception has occured.");
                }
                catch (Exception) //This will catch any generic error and throw a message to the user.
                {
                    MessageBox.Show("A Generic Error has occured.");
                }





                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                subTotal = 0;
                tax = 0;
                totalPrice = 0;

                subtotalTextBox.Text = subTotal.ToString("C");
                taxTextBox.Text = tax.ToString("C");
                totalTextBox.Text = totalPrice.ToString("C");
            }
        }


        /// <summary>
        /// Idea on how to clear the entire datagrid since everything is manually entered found here:
        /// https://stackoverflow.com/questions/3744882/datagridview-clear
        /// 
        /// Also resets the totals section to 0.
        /// 
        /// I looked through the textbook trying to find an easy way to not have to create a new form to ask the "are you sure" question...
        /// BUT, i was able to find some information regarding the MessageBox method and then did some digging and found the following
        /// information:
        /// https://stackoverflow.com/questions/5414270/messagebox-buttons
        /// Really came in clutch!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelOrderButton_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure you want to cancel this order?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                subTotal = 0;
                tax = 0;
                totalPrice = 0;

                subtotalTextBox.Text = subTotal.ToString("C");
                taxTextBox.Text = tax.ToString("C");
                totalTextBox.Text = totalPrice.ToString("C");
            }
            else
            {
                //Then the user clicked no... and therefore nothing changes
            }
            
        }

        /// <summary>
        /// Information and how-to learned from:
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview?view=netframework-4.7.2
        /// </summary>
        private void DataGridSetup()
        {
            //this.Controls.Add(dataGridView1);
            dataGridView1.ColumnCount = 4;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[0].Name = "Title";
            dataGridView1.Columns[1].Name = "Price";
            dataGridView1.Columns[2].Name = "QTY";
            dataGridView1.Columns[3].Name = "Line Total";

            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            //dataGridView1.Dock = DockStyle.Fill;

        }
    }
}
