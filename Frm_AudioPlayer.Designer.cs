namespace AudioPlayer
{
    partial class Frm_AudioPlayer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AudioPlayer));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Duration = new System.Windows.Forms.Timer(this.components);
            this.dgv_PlayList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctrl_Box = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.Volume_Progress = new Guna.UI2.WinForms.Guna2TrackBar();
            this.Btn_Back10 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Move10 = new Guna.UI2.WinForms.Guna2Button();
            this.Audio_Progress = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.Btn_Volume = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Looped = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Next = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Prev = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Play = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlayList)).BeginInit();
            this.Ctrl_Box.SuspendLayout();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Duration
            // 
            this.Duration.Interval = 999;
            this.Duration.Tick += new System.EventHandler(this.Duration_Tick);
            // 
            // dgv_PlayList
            // 
            this.dgv_PlayList.AllowUserToAddRows = false;
            this.dgv_PlayList.AllowUserToDeleteRows = false;
            this.dgv_PlayList.AllowUserToOrderColumns = true;
            this.dgv_PlayList.AllowUserToResizeColumns = false;
            this.dgv_PlayList.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.dgv_PlayList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_PlayList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PlayList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dgv_PlayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_PlayList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PlayList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_PlayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PlayList.ColumnHeadersVisible = false;
            this.dgv_PlayList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PlayList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_PlayList.EnableHeadersVisualStyles = false;
            this.dgv_PlayList.Location = new System.Drawing.Point(0, 29);
            this.dgv_PlayList.MultiSelect = false;
            this.dgv_PlayList.Name = "dgv_PlayList";
            this.dgv_PlayList.ReadOnly = true;
            this.dgv_PlayList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PlayList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_PlayList.RowHeadersVisible = false;
            this.dgv_PlayList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_PlayList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dgv_PlayList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_PlayList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_PlayList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dgv_PlayList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.dgv_PlayList.RowTemplate.Height = 50;
            this.dgv_PlayList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_PlayList.Size = new System.Drawing.Size(1011, 544);
            this.dgv_PlayList.TabIndex = 0;
            this.dgv_PlayList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PlayList_CellClick);
            this.dgv_PlayList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyboard);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Ctrl_Box
            // 
            this.Ctrl_Box.BackColor = System.Drawing.Color.Transparent;
            this.Ctrl_Box.Controls.Add(this.Volume_Progress);
            this.Ctrl_Box.Controls.Add(this.Btn_Back10);
            this.Ctrl_Box.Controls.Add(this.Btn_Move10);
            this.Ctrl_Box.Controls.Add(this.Audio_Progress);
            this.Ctrl_Box.Controls.Add(this.lbl_Duration);
            this.Ctrl_Box.Controls.Add(this.Btn_Volume);
            this.Ctrl_Box.Controls.Add(this.Btn_Looped);
            this.Ctrl_Box.Controls.Add(this.Btn_Next);
            this.Ctrl_Box.Controls.Add(this.Btn_Prev);
            this.Ctrl_Box.Controls.Add(this.Btn_Play);
            this.Ctrl_Box.CustomBorderColor = System.Drawing.Color.Black;
            this.Ctrl_Box.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Ctrl_Box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ctrl_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Ctrl_Box.Location = new System.Drawing.Point(0, 573);
            this.Ctrl_Box.Name = "Ctrl_Box";
            this.Ctrl_Box.Size = new System.Drawing.Size(1011, 110);
            this.Ctrl_Box.TabIndex = 1;
            this.Ctrl_Box.Text = "guna2ContainerControl1";
            // 
            // Volume_Progress
            // 
            this.Volume_Progress.Location = new System.Drawing.Point(828, 64);
            this.Volume_Progress.Name = "Volume_Progress";
            this.Volume_Progress.Size = new System.Drawing.Size(84, 23);
            this.Volume_Progress.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.Volume_Progress.TabIndex = 2;
            this.Volume_Progress.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(61)))));
            this.Volume_Progress.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Volume_Progress_Scroll);
            // 
            // Btn_Back10
            // 
            this.Btn_Back10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Back10.BackgroundImage")));
            this.Btn_Back10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Back10.BorderRadius = 30;
            this.Btn_Back10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Back10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Back10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Back10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Back10.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Back10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Back10.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Back10.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Back10.Location = new System.Drawing.Point(374, 56);
            this.Btn_Back10.Name = "Btn_Back10";
            this.Btn_Back10.Size = new System.Drawing.Size(41, 39);
            this.Btn_Back10.TabIndex = 7;
            this.Btn_Back10.Tag = "Looped";
            this.Btn_Back10.Click += new System.EventHandler(this.Btn_Back10_Click);
            // 
            // Btn_Move10
            // 
            this.Btn_Move10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Move10.BackgroundImage")));
            this.Btn_Move10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Move10.BorderRadius = 30;
            this.Btn_Move10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Move10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Move10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Move10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Move10.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Move10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Move10.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Move10.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Move10.Location = new System.Drawing.Point(592, 56);
            this.Btn_Move10.Name = "Btn_Move10";
            this.Btn_Move10.Size = new System.Drawing.Size(41, 39);
            this.Btn_Move10.TabIndex = 6;
            this.Btn_Move10.Tag = "Looped";
            this.Btn_Move10.Click += new System.EventHandler(this.Btn_Move10_Click);
            // 
            // Audio_Progress
            // 
            this.Audio_Progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Audio_Progress.Location = new System.Drawing.Point(12, 16);
            this.Audio_Progress.Name = "Audio_Progress";
            this.Audio_Progress.Size = new System.Drawing.Size(923, 23);
            this.Audio_Progress.TabIndex = 2;
            this.Audio_Progress.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(61)))));
            this.Audio_Progress.Value = 0;
            this.Audio_Progress.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Audio_Progress_Scroll);
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.ForeColor = System.Drawing.Color.White;
            this.lbl_Duration.Location = new System.Drawing.Point(941, 16);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(70, 21);
            this.lbl_Duration.TabIndex = 2;
            this.lbl_Duration.Text = "00:00:00";
            // 
            // Btn_Volume
            // 
            this.Btn_Volume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Volume.BackgroundImage")));
            this.Btn_Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Volume.BorderRadius = 30;
            this.Btn_Volume.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Volume.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Volume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Volume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Volume.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Volume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Volume.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Volume.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Volume.Location = new System.Drawing.Point(769, 61);
            this.Btn_Volume.Name = "Btn_Volume";
            this.Btn_Volume.Size = new System.Drawing.Size(40, 29);
            this.Btn_Volume.TabIndex = 5;
            this.Btn_Volume.Tag = "Mute";
            this.Btn_Volume.Click += new System.EventHandler(this.Btn_Volume_Click);
            // 
            // Btn_Looped
            // 
            this.Btn_Looped.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Looped.BackgroundImage")));
            this.Btn_Looped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Looped.BorderRadius = 30;
            this.Btn_Looped.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Looped.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Looped.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Looped.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Looped.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Looped.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Looped.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Looped.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Looped.Location = new System.Drawing.Point(642, 62);
            this.Btn_Looped.Name = "Btn_Looped";
            this.Btn_Looped.Size = new System.Drawing.Size(35, 27);
            this.Btn_Looped.TabIndex = 4;
            this.Btn_Looped.Tag = "Looped";
            this.Btn_Looped.Click += new System.EventHandler(this.Btn_Looped_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Next.BackgroundImage")));
            this.Btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Next.BorderRadius = 30;
            this.Btn_Next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Next.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Next.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Next.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Next.Location = new System.Drawing.Point(542, 57);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(43, 37);
            this.Btn_Next.TabIndex = 3;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Btn_Prev
            // 
            this.Btn_Prev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Prev.BackgroundImage")));
            this.Btn_Prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Prev.BorderRadius = 30;
            this.Btn_Prev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Prev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Prev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Prev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Prev.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Prev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Prev.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Prev.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Prev.Location = new System.Drawing.Point(421, 57);
            this.Btn_Prev.Name = "Btn_Prev";
            this.Btn_Prev.Size = new System.Drawing.Size(43, 37);
            this.Btn_Prev.TabIndex = 2;
            this.Btn_Prev.Click += new System.EventHandler(this.Btn_Prev_Click);
            // 
            // Btn_Play
            // 
            this.Btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Play.BackgroundImage")));
            this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Play.BorderRadius = 30;
            this.Btn_Play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Play.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Play.ForeColor = System.Drawing.Color.White;
            this.Btn_Play.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Play.Location = new System.Drawing.Point(474, 50);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(58, 51);
            this.Btn_Play.TabIndex = 0;
            this.Btn_Play.Tag = "Play";
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Controls.Add(this.guna2ControlBox1);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1011, 29);
            this.guna2ContainerControl1.TabIndex = 8;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(976, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // Frm_AudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 683);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.Ctrl_Box);
            this.Controls.Add(this.dgv_PlayList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_AudioPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlayList)).EndInit();
            this.Ctrl_Box.ResumeLayout(false);
            this.Ctrl_Box.PerformLayout();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Timer Duration;
        private System.Windows.Forms.DataGridView dgv_PlayList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Guna.UI2.WinForms.Guna2ContainerControl Ctrl_Box;
        private Guna.UI2.WinForms.Guna2Button Btn_Play;
        private Guna.UI2.WinForms.Guna2Button Btn_Prev;
        private Guna.UI2.WinForms.Guna2Button Btn_Next;
        private Guna.UI2.WinForms.Guna2Button Btn_Looped;
        private Guna.UI2.WinForms.Guna2Button Btn_Volume;
        private System.Windows.Forms.Label lbl_Duration;
        private Guna.UI2.WinForms.Guna2TrackBar Audio_Progress;
        private Guna.UI2.WinForms.Guna2Button Btn_Move10;
        private Guna.UI2.WinForms.Guna2Button Btn_Back10;
        private Guna.UI2.WinForms.Guna2TrackBar Volume_Progress;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

