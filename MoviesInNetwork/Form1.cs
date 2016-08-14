using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Xml;

namespace MoviesProjectUpdated
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Examples

        /* Dictionary Usage Example
         *  Dictionary<string,string> myDictionary = new Dictionary<string,string>();
            myDictionary["str"] = "ABCDEF";
            var valueinstr = myDictionary["str"];
         * */
        #endregion

        #region Private Variables

        private bool DownloadStatus = false;
        private string source, destination;
        private Dictionary<string, string> dictionaryMovieList = new Dictionary<string, string>();
        private Thread download_thread;
        #endregion


        #region ServerList

        private void button_add_server_Click(object sender, EventArgs e)
        {
            string path = textbox_add_server.Text;
            if (String.IsNullOrEmpty(path.Trim()))
            {
                MessageBox.Show("Please Enter Valid Path/Server");
            }
            else
            {
                listbox_server.Items.Add(path);
                textbox_add_server.Clear();
            }
            if (listbox_server.Items.Count > 0)
                DisplayHScroll(listbox_server);
        }
        private void button_remove_server_Click(object sender, EventArgs e)
        {
            listbox_server.Items.Remove(listbox_server.SelectedItem);
        }

        #endregion

        #region MovieListing

        private void button_refresh_all_Click(object sender, EventArgs e)
        {
            try
            {
                if (listbox_server.Items.Count != 0)
                {
                    int count;
                 
                    listbox_movie_list.Items.Clear();
                    DirectoryInfo dir;
                    for (count = 0; count < listbox_server.Items.Count; count++)
                    {
                        dir = new DirectoryInfo(listbox_server.Items[count].ToString());
                        getDirsFiles(dir);
                    }
                    DisplayHScroll(listbox_movie_list);
                    if (listbox_movie_list.Items.Count > 0)
                    {
                        movie_count.Text = listbox_movie_list.Items.Count.ToString();
                    }
                }
                else
                    MessageBox.Show("Please Add Server");
            }
            catch (Exception Refresh_Exception)
            {
                MessageBox.Show("Caught an Exception");
            }
        }
        private void getDirsFiles(DirectoryInfo dir)
        {
            FileInfo[] files;
            string previous_movie_name = "Default";
            string new_movie_name = string.Empty;
            int index;
            files = dir.GetFiles("*.*");
            foreach (FileInfo file in files)
            {
                if (file.Extension.Equals(".avi") || file.Extension.Equals(".mkv") || file.Extension.Equals(".mp4") || file.Extension.Equals(".wmv") || file.Extension.Equals(".mpeg4")|| file.Extension.Equals(".mov") || file.Extension.Equals(".vob") || file.Extension.Equals(".m4v"))
                {
                    if (file.Name.Length < 6)
                        continue;
                    if (!((file.FullName.ToLower().Contains("sample")) || (file.FullName.ToLower().Contains("trailer"))))
                    {
                        new_movie_name = file.FullName;
                        index = (new_movie_name.Length) / 2;
                        if (string.Compare(previous_movie_name, 0, new_movie_name, 0, index)==0)
                        {
                            previous_movie_name = new_movie_name;
                            continue;
                        }
                        dictionaryMovieList[file.Name] = file.FullName;
                        listbox_movie_list.Items.Add(file.Name);
                        previous_movie_name = new_movie_name;
                    }
                }

            }
            //get sub-folders for the current directory
            DirectoryInfo[] dirs = dir.GetDirectories("*.*");
            foreach (DirectoryInfo otherdir in dirs)
            {
                getDirsFiles(otherdir);
            }
        }
        #endregion

        #region Download File

        private void ThreadStatus()
        {
            if (DownloadStatus)
            {
                MessageBox.Show("Download was completed successfully");
                label_copystatus.Text = " ";
                return;
            }
            else
            {
                MessageBox.Show("Something went wrong:");
                label_copystatus.Text = " ";
                return;
            }
        }

        private void DownloadFile()
        {
            try
            {
                File.Copy(source, destination);
                DownloadStatus = true;
                ThreadStatus();
                return;
            }
            catch (Exception exp)
            {
                DownloadStatus = false;
                ThreadStatus();
                return;
            }

        }
        

        private void button_download_file_Click(object sender, EventArgs e)
        {
            source = dictionaryMovieList[listbox_movie_list.SelectedItem.ToString()];
            destination = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            destination = destination + listbox_movie_list.SelectedItem.ToString();
            label_copystatus.Text = "Moving " + source + " TO " + destination;
            download_thread = new Thread(new ThreadStart(DownloadFile));
            download_thread.IsBackground = true;
            download_thread.Start();

        }
        #endregion
        #region SearchMovieList
        private void button3_Click(object sender, EventArgs e)
        {
            string movieToSearch = textBox_search_movie.Text.ToString();
            string movie;
            int count;
            listbox_searched.Items.Clear();
            for (count = 0; count < listbox_movie_list.Items.Count; count++)
            {
                movie = listbox_movie_list.Items[count].ToString();
                if (movie.ToLower().Contains(movieToSearch.ToLower()))
                    listbox_searched.Items.Add(movie);
            }
            if (listbox_searched.Items.Count > 0)
                DisplayHScroll(listbox_searched);
            else
                MessageBox.Show("No Movie was found");
        }
        #endregion

        #region Common_Functions
        private void DisplayHScroll(ListBox list)
        {
            // Make no partial items are displayed vertically.
            list.IntegralHeight = true;

            // Display a horizontal scroll bar.
            list.HorizontalScrollbar = true;

            // Create a Graphics object to use when determining the size of the largest item in the ListBox.
            Graphics g = list.CreateGraphics();

            // Determine the size for HorizontalExtent using the MeasureString method using the last item in the list. 
            int hzSize = (int)g.MeasureString(list.Items[list.Items.Count - 1].ToString(), list.Font).Width;
            // Set the HorizontalExtent property.
            list.HorizontalExtent = hzSize;
            return;
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (download_thread != null)
            {
                if (download_thread.IsAlive)
                {
                    MessageBox.Show("Thread Still Running,Movie will not be Copied", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_saveserverlist_Click(object sender, EventArgs e)
        {
            try
            {
                if (listbox_server.Items.Count != 0)
                {
                    if (File.Exists("serverlist.txt"))
                    {
                        File.Delete("serverlist.txt");
                    }
                    StreamWriter writefile = new StreamWriter("serverlist.txt");
                    for (int i = 0; i < listbox_server.Items.Count; i++)
                    {
                        writefile.WriteLine(listbox_server.Items[i]);
                    }
                    writefile.Close();
                }
                else
                    MessageBox.Show("There is nothing to Save");
            }
            catch (IOException saveException)
            {
                MessageBox.Show("Caught an Exception");
            }
        }

        private void button_loadserverlist_Click(object sender, EventArgs e)
        {
            if (!(File.Exists("serverlist.txt")))
            {
                MessageBox.Show("No file to Load");
            }
            else
            {
                listbox_server.Items.Clear();
                string hostname=string.Empty;
                StreamReader read_file = new StreamReader("serverlist.txt");
                while ((hostname=read_file.ReadLine())!=null)
                {
                    listbox_server.Items.Add(hostname);
                }
                read_file.Close();
            }
        }

        private void button_explore_Click(object sender, EventArgs e)
        {
            string fileDirectoryName = listbox_movie_list.SelectedItem.ToString();
            string RemovePart = "\\" + fileDirectoryName;
            string Directory = dictionaryMovieList[fileDirectoryName];
            Directory = Directory.Replace(RemovePart, "");
            System.Diagnostics.Process.Start("explorer.exe", Directory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string complete_name = textBox1.Text;
            MovieDetails(complete_name);
            
        }

        private bool GetResultByAddingNames(string[] name_split)
        {
            int i = 0;
            string respHTML=string.Empty;
            string name_build = string.Empty;
            bool done = false;
            foreach (string s in name_split)
            {
                name_build = name_build + name_split[i]+" ";
                name_build.ToString().Trim();
                respHTML = GetResponseFromIMDB(name_build);
                if (respHTML.Contains("False"))
                {
                    if (i < 4)
                    {
                        i++;
                        continue;
                    }
                    else
                       return false;
                }
                else
                {
                    BreakResponse(respHTML);
                    richTextBox1.AppendText("New Movie Detail Method3:\n " + respHTML + "\n" + "\n");
                    return true;
                }
            }
            return false;
        }
        private void MovieDetails(string name)
        {
            bool result = false;
            string respHTML;
            int index = 0;
            if (name.Contains("."))
            {
                index = name.LastIndexOf('.');
                name = name.Remove(index);
            }
            
            //Send the Name directly and check whether we get any result.
            result = GetResultByDirectName(name);
            if (result)
                return;
            
            name = name.Replace("(", "  ");
            //    name = name.Replace(")", " ");
            name = name.Replace("[", "  ");
            //  name = name.Replace("]", " ");
           name = name.Replace("_", " ");
           name = name.Replace("-", " ");
            //name = name.Replace(",", "  ");
            name = name.Replace("{", "  ");
            //name = name.Replace("}", " ");
            name = name.Replace(".", " ");
            //name = name.Replace("  ", " ");
            name = name.Trim();
            

            char[] seperator = {' ','|',};
            string[] name_split = name.Split(seperator);
            
            //Send the name till we get a date/number.
            result = GetResultByDateModifying(name_split);
            if (result)
                return;
            //Send the name splited as string and keep creating the name and check on imdb.
            result = GetResultByAddingNames(name_split);

            if (result)
                return;
            else
                richTextBox1.AppendText(name + ": No Database found \n\n");
        }

        private void ImdbInXml(string url)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Uri new_url = new Uri(url.ToString());
         Dictionary<string, string> movie_details = new Dictionary<string, string>();
            try
            {
                request = (HttpWebRequest)WebRequest.Create(new_url);
                response = (HttpWebResponse)request.GetResponse();
                Stream respStream = response.GetResponseStream();
                XmlTextReader reader = new XmlTextReader(respStream);
                while (reader.Read())
                {
                    if (reader.Name.Equals("movie"))
                    {
                        reader.MoveToNextAttribute();
                        for(int i=0;i<reader.AttributeCount;i++)
                        {
                            movie_details.Add(reader.Name, reader.Value);
                            reader.MoveToNextAttribute();
                        }
                    }
                }
                richTextBox1.AppendText("Written Everything");
            }
            catch (Exception e)
            {

            }
        }
    
        private string GetResponseFromIMDB(string movie_name)
        {
            string omdbapi = " http://www.omdbapi.com/?t=";
            string textToSearch = omdbapi+movie_name;
            //ImdbInXml(textToSearch);
            Uri uri = new Uri(textToSearch.ToString());
            HttpWebRequest httpRequest = null;
            HttpWebResponse httpResponse = null;
            try
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(uri);
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                Stream respStream = httpResponse.GetResponseStream();
                StreamReader reader = new StreamReader(respStream, Encoding.UTF8);
                String respHTML = reader.ReadToEnd();
                respStream.Close();
                httpResponse.Close();
                return respHTML;
            }
            catch (WebException excep)
            {
                return "Error";
            }
           
        }
        private void BreakResponse(string response)
        {
            Dictionary<string, string> movie_details = new Dictionary<string, string>();
            string[] response_break;
            response_break = response.Split(',');
            foreach (string details in response_break)
            {
                if (details.Contains("Title"))
                {
                }
            }
        }
        private bool GetResultByDirectName(string movie_name)
        {
            string result_response=GetResponseFromIMDB(movie_name);
            if (result_response.Contains("False"))
            {
                return false;
            }
            else
            {
                BreakResponse(result_response);
                richTextBox1.AppendText("New Movie Database Method1: \n" + result_response + "\n");
                return true;
            }
        }

        private bool GetResultByDateModifying(string[] movie_name)
        {
            StringBuilder name_build=new StringBuilder();
            int number;
            string response=string.Empty;
            foreach (string name in movie_name)
            {
                if (name.Equals(""))
                    break;
                
                else if (!(int.TryParse(name, out number)))
                {
                    name_build.Append(name + " ");
                    continue;
                }
                else
                {
                    break;
                }
            }
            string send_name = name_build.ToString().Trim();
            response = GetResponseFromIMDB(send_name);
            if (response.Contains("False"))
                return false;
            else
            {
                BreakResponse(response);
                richTextBox1.AppendText("New Movie DataBase: Method 2\n" + response + "\n");
                return true;
            }
        }

        private void StartThread()
        {
            string movie_name=string.Empty;
            progressBar1.Maximum = listbox_movie_list.Items.Count - 1 ;

            for (int i = 0; i < listbox_movie_list.Items.Count; i++)
            {
                movie_name = listbox_movie_list.Items[i].ToString();
                MovieDetails(listbox_movie_list.Items[i].ToString());
                progressBar1.Value = i;

            }
            MessageBox.Show("Completed");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Thread getdetails = new Thread(new ThreadStart(StartThread));
            getdetails.IsBackground = true;
            getdetails.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists("movielist.txt"))
            {
                File.Delete("movielist.txt");
            }
            StreamWriter writefile = new StreamWriter("movielist.txt");
            string movie_name = string.Empty;
          
            for (int i = 0; i < listbox_movie_list.Items.Count; i++)
            {
                movie_name = listbox_movie_list.Items[i].ToString();
                try
                {
                    writefile.WriteLine(movie_name);
                }
                catch (IOException saveException)
                {
                    MessageBox.Show("Caught an Exception");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!(File.Exists("movielist.txt")))
            {
                MessageBox.Show("No file to Load");
            }
            else
            {
                listbox_movie_list.Items.Clear();
                string movie_name = string.Empty;
                string previous_movie_name = "Default";
                string new_movie_name = string.Empty;
                int index;
            
                StreamReader read_file = new StreamReader("movielist.txt");
                while ((movie_name = read_file.ReadLine()) != null)
                {
                    if (movie_name.Length <= 5)
                       continue;
                    new_movie_name = movie_name;
                    //index = (new_movie_name.Length) / 2;
                    if (string.Compare(previous_movie_name, 0, new_movie_name, 0, 5) == 0)
                    {
                        previous_movie_name = new_movie_name;
                        continue;
                    }
                    listbox_movie_list.Items.Add(movie_name);
                    previous_movie_name = new_movie_name;
                }
                read_file.Close();
            }
        }

        private void movie_count_Click(object sender, EventArgs e)
        {
            movie_count.Text = listbox_movie_list.Items.Count.ToString();
        }       
    }
}
