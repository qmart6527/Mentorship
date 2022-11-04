using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSIT_499
{
     public partial class Form1 : Form
     {
          //can be changed to fit what is needed
          string helpEmail = "Please reach out to Professor Joy for any questions. " +
               "\nEmail: denise.joy@fredonia.edu";

          public Form1()
          {
               InitializeComponent();
               loadMentorInfo();
               loadMenteeInfo();
               loadMentorMentee();
          }

          private void hlpBtn_Click(object sender, EventArgs e)
          {
               MessageBox.Show(helpEmail);
          }

          private void hlpBtn2_Click(object sender, EventArgs e)
          {
               MessageBox.Show(helpEmail);
          }

          private void hlpBtn3_Click(object sender, EventArgs e)
          {
               MessageBox.Show(helpEmail);
          }

          private void hlpBtn4_Click(object sender, EventArgs e)
          {
               MessageBox.Show(helpEmail);
          }

          private void hlpBtn4_Click_1(object sender, EventArgs e)
          {
               MessageBox.Show(helpEmail);
          }

          private void hlpBtn5_Click(object sender, EventArgs e)
          {
               MessageBox.Show(helpEmail);
          }

          private void mntrCmbBx_SelectedIndexChanged(object sender, EventArgs e)
          {
               getMentorInfo(mntrCmbBx.Text.ToString());
          }

          private void mnteCmbBx_SelectedIndexChanged(object sender, EventArgs e)
          {
               getMenteeInfo(mnteCmbBx.Text.ToString());
          }

          private void mnteMjrCntBtn_Click(object sender, EventArgs e)
          {
               getAllMenteeMajor();
          }

          private void sbmtBtn_Click(object sender, EventArgs e)
          {
               addActivity();
          }

          private void actvtCntBtn_Click(object sender, EventArgs e)
          {
               getMenteeNumber();
          }

          //functions

          //used to load mentors into program
          private void loadMentorInfo()
          {
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand getMentorName = conn.CreateCommand();
               getMentorName.CommandText = "Select Mentor_Fname FROM  t_mentor";
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = getMentorName.ExecuteReader();
               while (reader.Read())
               {
                    mntrCmbBx.Items.Add(reader["Mentor_Fname"].ToString());
               }
               conn.Close();
          }

          //load mentee info
          private void loadMenteeInfo()
          {
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand getMentorName = conn.CreateCommand();
               getMentorName.CommandText = "Select Mentee_Fname FROM  t_mentee";
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = getMentorName.ExecuteReader();
               while (reader.Read())
               {
                    mnteCmbBx.Items.Add(reader["Mentee_Fname"].ToString());
               }
               conn.Close();
          }

          //get mentor info
          private void getMentorInfo(string a)
          {
               string mentorName = mntrCmbBx.Text.ToString();
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand mentorInfo = conn.CreateCommand();
               mentorInfo.CommandText = "Select * FROM  t_mentor WHERE MENTOR_FNAME =  @a";
               mentorInfo.Parameters.Add("@a", MySqlDbType.VarChar).Value = a;
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = mentorInfo.ExecuteReader();
               while (reader.Read())
               {
                    if (a == mentorName)
                    {
                         mntrFstNmTxtBx.Text = reader["Mentor_Fname"].ToString() + " " +reader["Mentor_Lname"].ToString();
                         MntrMjrTxtBx.Text = reader["Mentor_Major"].ToString();
                    }
               }
               conn.Close();
          }

          //get mentee info
          private void getMenteeInfo(string a)
          {
               string menteeName = mnteCmbBx.Text.ToString();
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand mentorInfo = conn.CreateCommand();
               mentorInfo.CommandText = "Select * FROM  t_mentee WHERE MENTEE_FNAME =  @a";
               mentorInfo.Parameters.Add("@a", MySqlDbType.VarChar).Value = a;
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = mentorInfo.ExecuteReader();
               while (reader.Read())
               {
                    if (a == menteeName)
                    {
                         mnteNmTxtBx.Text = reader["Mentee_Fname"].ToString() + " " + reader["Mentee_Lname"].ToString();
                         mnteMjrTxtBx.Text = reader["Mentee_Major"].ToString();
                    }
               }
               conn.Close();
          }

          //get mentees by major
          private void getAllMenteeMajor()
          {
               rptLstBx.Items.Clear();
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand mentorInfo = conn.CreateCommand();
               mentorInfo.CommandText = "SELECT Mentee_Fname, Mentee_Lname, Mentee_Major from t_mentee ORDER BY Mentee_Major;";
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = mentorInfo.ExecuteReader();
               while (reader.Read())
               {
                    rptLstBx.Items.Add("\n" + reader["Mentee_Fname"].ToString() + " " + reader["Mentee_Lname"] + " "
                         + "\t" + reader["Mentee_Major"].ToString());
               }
               conn.Close();
          }

          //load mentors and mentees into activity
          private void loadMentorMentee()
          {
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand getMentorName = conn.CreateCommand();

               //loads mentors
               getMentorName.CommandText = "Select Mentor_Fname FROM  t_mentor";
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = getMentorName.ExecuteReader();
               while (reader.Read())
               {
                   mntrLstBxNm.Items.Add(reader["Mentor_Fname"].ToString());
               }
               conn.Close();

               //loads mentees
               getMentorName.CommandText = "Select Mentee_Fname FROM  t_mentee";
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               reader = getMentorName.ExecuteReader();
               while (reader.Read())
               {
                    mnteLstBxNm.Items.Add(reader["Mentee_Fname"].ToString());
               }
               conn.Close();
          }

          //add activity to database
          private void addActivity()
          {
               if (mntrLstBxNm.Text.ToString() == "" || mnteLstBxNm.Text.ToString() == "" || actvtTxtBx.Text == "" || hrLstBx.Text.ToString() == "")
               {
                    MessageBox.Show("Please fill out all appropriate fields.");
               }
               else
               {
                    string selectedMentor = mntrLstBxNm.Text.ToString();
                    string selectedMentee = mnteLstBxNm.Text.ToString();
                    string activity = actvtTxtBx.Text;
                    double hours = Int32.Parse(hrLstBx.Text.ToString());
                    int activityID = 0;
                    int selectedMentorID = 0;
                    int selectedMenteeID = 0;


                    activityID = getActivityID();
                    selectedMentorID = getMentorID(selectedMentor);
                    selectedMenteeID = getMenteeID(selectedMentee);

                    //update activty
                    string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
                    MySqlConnection conn = new MySqlConnection(connString);
                    MySqlCommand updateActivty = conn.CreateCommand();
                    updateActivty.CommandText = "INSERT INTO t_activity VALUES (@id, @mrID, @meID, @act, @hr)";
                    updateActivty.Parameters.Add("@id", MySqlDbType.Int32).Value = activityID;
                    updateActivty.Parameters.Add("@mrID", MySqlDbType.Int32).Value = selectedMentorID;
                    updateActivty.Parameters.Add("@meID", MySqlDbType.Int32).Value = selectedMenteeID;
                    updateActivty.Parameters.Add("@act", MySqlDbType.VarChar).Value = activity;
                    updateActivty.Parameters.Add("@hr", MySqlDbType.Int32).Value = hours;
                    try
                    {
                         conn.Open();
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show(ex.Message);
                    }
                    updateActivty.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Your hours have been logged!");
                    actvtTxtBx.Text = "";
                    mnteLstBxNm.SelectedIndex = -1;
                    mntrLstBxNm.SelectedIndex = -1;
                    hrLstBx.SelectedIndex = -1;
                    updateActivityNumber(selectedMentee);
               }
          }

          public int getActivityID()
          {
               int activity = 0;
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand getID = conn.CreateCommand();

               //get activityID
               getID.CommandText = "Select activityID from t_activity order by activityID desc limit 1";
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = getID.ExecuteReader();
               while (reader.Read())
               {
                    activity = Int32.Parse(reader["activityID"].ToString());
               }
               conn.Close();
               return activity + 1;
          }

          //getMentorID
          public int getMentorID(string a)
          {
               int id = 0;
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand getID = conn.CreateCommand();

               //get mentorID
               getID.CommandText = "Select mentorID from t_mentor WHERE Mentor_Fname = @mName";
               getID.Parameters.Add("@mName", MySqlDbType.VarChar).Value = a;
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = getID.ExecuteReader();
               while (reader.Read())
               {
                    id = Int32.Parse(reader["mentorID"].ToString());
               }
               conn.Close();
               return id;
          }

          //getMenteeID
          public int getMenteeID(string a)
          {
               int id = 0;
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand getID = conn.CreateCommand();

               //get menteeID
               getID.CommandText = "Select menteeID from t_mentee WHERE Mentee_Fname = @mName";
               getID.Parameters.Add("@mName", MySqlDbType.VarChar).Value = a;
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = getID.ExecuteReader();
               while (reader.Read())
               {
                    id = Int32.Parse(reader["menteeID"].ToString());
               }
               conn.Close();
               return id;
          }

          //update mentee activity number
          private void updateActivityNumber(string a)
          {
               int number = 0;
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand getActivityNum = conn.CreateCommand();

               //get number of activities
               getActivityNum.CommandText = "Select Mentee_Activities from t_mentee WHERE Mentee_Fname = @mName";
               getActivityNum.Parameters.Add("@mName", MySqlDbType.VarChar).Value = a;
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = getActivityNum.ExecuteReader();
               while (reader.Read())
               {
                    number = Int32.Parse(reader["Mentee_Activities"].ToString());
               }
               conn.Close();

               //update number of activities
               number++;
               getActivityNum.CommandText = "UPDATE t_mentee SET Mentee_Activities = @num WHERE Mentee_Fname = @mName";
               getActivityNum.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               getActivityNum.ExecuteNonQuery();
               conn.Close();
          }

          //get mentees by major
          private void getMenteeNumber()
          {
               rptLstBx.Items.Clear();
               string connString = "server = 127.0.0.1; user id = root;password=~{5hP&}Bbgq;database=csit_499;";
               MySqlConnection conn = new MySqlConnection(connString);
               MySqlCommand mentorInfo = conn.CreateCommand();
               mentorInfo.CommandText = "SELECT Mentee_Fname, Mentee_Lname, Mentee_Activities from t_mentee ORDER BY Mentee_Activities desc;";
               try
               {
                    conn.Open();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               MySqlDataReader reader = mentorInfo.ExecuteReader();
               while (reader.Read())
               {
                    rptLstBx.Items.Add("\n" + reader["Mentee_Fname"].ToString() + " " + reader["Mentee_Lname"] + " "
                         + "\t" + reader["Mentee_Activities"].ToString());
               }
               conn.Close();
          }

          private void actvtTxtBx_TextChanged(object sender, EventArgs e)
          {

          }

          private void mntrChckBxLst_SelectedIndexChanged(object sender, EventArgs e)
          {
               
          }


     }
}
