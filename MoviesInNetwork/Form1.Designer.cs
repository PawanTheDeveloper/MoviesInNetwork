namespace MoviesProjectUpdated
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label_copystatus = new System.Windows.Forms.Label();
            this.button_explore = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listbox_movie_list = new System.Windows.Forms.ListBox();
            this.button_download_file = new System.Windows.Forms.Button();
            this.button_loadserverlist = new System.Windows.Forms.Button();
            this.button_saveserverlist = new System.Windows.Forms.Button();
            this.button_refresh_selected = new System.Windows.Forms.Button();
            this.button_refresh_all = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listbox_server = new System.Windows.Forms.ListBox();
            this.button_remove_server = new System.Windows.Forms.Button();
            this.button_add_server = new System.Windows.Forms.Button();
            this.textbox_add_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listbox_searched = new System.Windows.Forms.ListBox();
            this.textBox_search_movie = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.movie_count = new System.Windows.Forms.Label();
            this.movie_completed_count = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.movie_count);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.label_copystatus);
            this.tabPage1.Controls.Add(this.button_explore);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button_download_file);
            this.tabPage1.Controls.Add(this.button_loadserverlist);
            this.tabPage1.Controls.Add(this.button_saveserverlist);
            this.tabPage1.Controls.Add(this.button_refresh_selected);
            this.tabPage1.Controls.Add(this.button_refresh_all);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MovieList";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(479, 388);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 30;
            this.button7.Text = "Load";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(357, 388);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 29;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label_copystatus
            // 
            this.label_copystatus.AutoSize = true;
            this.label_copystatus.Location = new System.Drawing.Point(20, 407);
            this.label_copystatus.Name = "label_copystatus";
            this.label_copystatus.Size = new System.Drawing.Size(35, 13);
            this.label_copystatus.TabIndex = 28;
            this.label_copystatus.Text = "label2";
            // 
            // button_explore
            // 
            this.button_explore.Location = new System.Drawing.Point(714, 163);
            this.button_explore.Name = "button_explore";
            this.button_explore.Size = new System.Drawing.Size(111, 39);
            this.button_explore.TabIndex = 16;
            this.button_explore.Text = "Open Explorer";
            this.button_explore.UseVisualStyleBackColor = true;
            this.button_explore.Click += new System.EventHandler(this.button_explore_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listbox_movie_list);
            this.groupBox2.Location = new System.Drawing.Point(337, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 343);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MovieList";
            // 
            // listbox_movie_list
            // 
            this.listbox_movie_list.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_movie_list.FormattingEnabled = true;
            this.listbox_movie_list.HorizontalExtent = 2;
            this.listbox_movie_list.HorizontalScrollbar = true;
            this.listbox_movie_list.ItemHeight = 19;
            this.listbox_movie_list.Location = new System.Drawing.Point(6, 19);
            this.listbox_movie_list.Name = "listbox_movie_list";
            this.listbox_movie_list.Size = new System.Drawing.Size(347, 308);
            this.listbox_movie_list.TabIndex = 0;
            // 
            // button_download_file
            // 
            this.button_download_file.Location = new System.Drawing.Point(714, 100);
            this.button_download_file.Name = "button_download_file";
            this.button_download_file.Size = new System.Drawing.Size(111, 39);
            this.button_download_file.TabIndex = 15;
            this.button_download_file.Text = "Download File";
            this.button_download_file.UseVisualStyleBackColor = true;
            this.button_download_file.Click += new System.EventHandler(this.button_download_file_Click);
            // 
            // button_loadserverlist
            // 
            this.button_loadserverlist.Location = new System.Drawing.Point(212, 244);
            this.button_loadserverlist.Name = "button_loadserverlist";
            this.button_loadserverlist.Size = new System.Drawing.Size(75, 23);
            this.button_loadserverlist.TabIndex = 26;
            this.button_loadserverlist.Text = "Load";
            this.button_loadserverlist.UseVisualStyleBackColor = true;
            this.button_loadserverlist.Click += new System.EventHandler(this.button_loadserverlist_Click);
            // 
            // button_saveserverlist
            // 
            this.button_saveserverlist.Location = new System.Drawing.Point(212, 196);
            this.button_saveserverlist.Name = "button_saveserverlist";
            this.button_saveserverlist.Size = new System.Drawing.Size(75, 23);
            this.button_saveserverlist.TabIndex = 25;
            this.button_saveserverlist.Text = "Save";
            this.button_saveserverlist.UseVisualStyleBackColor = true;
            this.button_saveserverlist.Click += new System.EventHandler(this.button_saveserverlist_Click);
            // 
            // button_refresh_selected
            // 
            this.button_refresh_selected.Location = new System.Drawing.Point(196, 130);
            this.button_refresh_selected.Name = "button_refresh_selected";
            this.button_refresh_selected.Size = new System.Drawing.Size(114, 59);
            this.button_refresh_selected.TabIndex = 24;
            this.button_refresh_selected.Text = "Search Selected";
            this.button_refresh_selected.UseVisualStyleBackColor = true;
            // 
            // button_refresh_all
            // 
            this.button_refresh_all.Location = new System.Drawing.Point(196, 65);
            this.button_refresh_all.Name = "button_refresh_all";
            this.button_refresh_all.Size = new System.Drawing.Size(114, 59);
            this.button_refresh_all.TabIndex = 23;
            this.button_refresh_all.Text = "Refresh List";
            this.button_refresh_all.UseVisualStyleBackColor = true;
            this.button_refresh_all.Click += new System.EventHandler(this.button_refresh_all_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listbox_server);
            this.groupBox1.Controls.Add(this.button_remove_server);
            this.groupBox1.Controls.Add(this.button_add_server);
            this.groupBox1.Controls.Add(this.textbox_add_server);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 344);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server List";
            // 
            // listbox_server
            // 
            this.listbox_server.FormattingEnabled = true;
            this.listbox_server.Location = new System.Drawing.Point(11, 19);
            this.listbox_server.Name = "listbox_server";
            this.listbox_server.Size = new System.Drawing.Size(151, 225);
            this.listbox_server.TabIndex = 0;
            // 
            // button_remove_server
            // 
            this.button_remove_server.Location = new System.Drawing.Point(92, 307);
            this.button_remove_server.Name = "button_remove_server";
            this.button_remove_server.Size = new System.Drawing.Size(75, 23);
            this.button_remove_server.TabIndex = 1;
            this.button_remove_server.Text = "Remove";
            this.button_remove_server.UseVisualStyleBackColor = true;
            this.button_remove_server.Click += new System.EventHandler(this.button_remove_server_Click);
            // 
            // button_add_server
            // 
            this.button_add_server.AccessibleName = "add_button";
            this.button_add_server.Location = new System.Drawing.Point(11, 307);
            this.button_add_server.Name = "button_add_server";
            this.button_add_server.Size = new System.Drawing.Size(75, 23);
            this.button_add_server.TabIndex = 2;
            this.button_add_server.Text = "Add";
            this.button_add_server.UseVisualStyleBackColor = true;
            this.button_add_server.Click += new System.EventHandler(this.button_add_server_Click);
            // 
            // textbox_add_server
            // 
            this.textbox_add_server.Location = new System.Drawing.Point(11, 277);
            this.textbox_add_server.Name = "textbox_add_server";
            this.textbox_add_server.Size = new System.Drawing.Size(151, 20);
            this.textbox_add_server.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Server Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 39);
            this.button4.TabIndex = 26;
            this.button4.Text = "Open Explorer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.listbox_searched);
            this.groupBox3.Controls.Add(this.textBox_search_movie);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(689, 451);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Results";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listbox_searched
            // 
            this.listbox_searched.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_searched.FormattingEnabled = true;
            this.listbox_searched.ItemHeight = 18;
            this.listbox_searched.Location = new System.Drawing.Point(330, 8);
            this.listbox_searched.Name = "listbox_searched";
            this.listbox_searched.Size = new System.Drawing.Size(353, 436);
            this.listbox_searched.TabIndex = 18;
            // 
            // textBox_search_movie
            // 
            this.textBox_search_movie.Location = new System.Drawing.Point(6, 59);
            this.textBox_search_movie.Name = "textBox_search_movie";
            this.textBox_search_movie.Size = new System.Drawing.Size(258, 20);
            this.textBox_search_movie.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(710, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 39);
            this.button5.TabIndex = 25;
            this.button5.Text = "Download File";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.movie_completed_count);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(843, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IMDB";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "GetDetails";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(507, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(316, 357);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Single Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(61, 102);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(146, 23);
            this.search.TabIndex = 18;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(330, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 148);
            this.listBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 20);
            this.textBox2.TabIndex = 19;
            // 
            // movie_count
            // 
            this.movie_count.AutoSize = true;
            this.movie_count.Location = new System.Drawing.Point(589, 398);
            this.movie_count.Name = "movie_count";
            this.movie_count.Size = new System.Drawing.Size(35, 13);
            this.movie_count.TabIndex = 31;
            this.movie_count.Text = "Count";
            this.movie_count.Click += new System.EventHandler(this.movie_count_Click);
            // 
            // movie_completed_count
            // 
            this.movie_completed_count.AutoSize = true;
            this.movie_completed_count.Location = new System.Drawing.Point(409, 72);
            this.movie_completed_count.Name = "movie_completed_count";
            this.movie_completed_count.Size = new System.Drawing.Size(35, 13);
            this.movie_completed_count.TabIndex = 4;
            this.movie_completed_count.Text = "label2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 431);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(809, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Movie DataBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listbox_server;
        private System.Windows.Forms.Button button_remove_server;
        private System.Windows.Forms.Button button_add_server;
        private System.Windows.Forms.TextBox textbox_add_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_loadserverlist;
        private System.Windows.Forms.Button button_saveserverlist;
        private System.Windows.Forms.Button button_refresh_selected;
        private System.Windows.Forms.Button button_refresh_all;
        private System.Windows.Forms.Button button_explore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listbox_movie_list;
        private System.Windows.Forms.Button button_download_file;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listbox_searched;
        private System.Windows.Forms.TextBox textBox_search_movie;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label_copystatus;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label movie_count;
        private System.Windows.Forms.Label movie_completed_count;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

