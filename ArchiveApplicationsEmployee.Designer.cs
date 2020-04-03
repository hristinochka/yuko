namespace Diploma
{
    partial class ArchiveApplicationsEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveApplicationsEmployee));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataListView = new System.Windows.Forms.ListView();
            this.id_applic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_equip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_app = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.applicationdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datestart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(392, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Составить отчет";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(392, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataListView
            // 
            this.dataListView.BackColor = System.Drawing.Color.LightBlue;
            this.dataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_applic,
            this.id_equip,
            this.id_job,
            this.id_app,
            this.id_user,
            this.applicationdate,
            this.datestart,
            this.dateend});
            this.dataListView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataListView.HideSelection = false;
            this.dataListView.Location = new System.Drawing.Point(11, 12);
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(965, 303);
            this.dataListView.TabIndex = 3;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.View = System.Windows.Forms.View.Details;
            // 
            // id_applic
            // 
            this.id_applic.Text = "№ п/п";
            this.id_applic.Width = 57;
            // 
            // id_equip
            // 
            this.id_equip.Text = "Название оборудования";
            this.id_equip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_equip.Width = 163;
            // 
            // id_job
            // 
            this.id_job.Text = "Статус работы оборудования";
            this.id_job.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_job.Width = 186;
            // 
            // id_app
            // 
            this.id_app.Text = "Статус заявки";
            this.id_app.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_app.Width = 114;
            // 
            // id_user
            // 
            this.id_user.Text = "ФИО пользователя";
            this.id_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_user.Width = 128;
            // 
            // applicationdate
            // 
            this.applicationdate.Text = "Дата подачи заявки";
            this.applicationdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.applicationdate.Width = 132;
            // 
            // datestart
            // 
            this.datestart.Text = "Дата принятия заявки";
            this.datestart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datestart.Width = 140;
            // 
            // dateend
            // 
            this.dateend.Text = "Дата закрытия заявки";
            this.dateend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateend.Width = 142;
            // 
            // ArchiveApplicationsEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(988, 437);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArchiveApplicationsEmployee";
            this.Text = "Архив заявок";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView dataListView;
        private System.Windows.Forms.ColumnHeader id_applic;
        private System.Windows.Forms.ColumnHeader id_equip;
        private System.Windows.Forms.ColumnHeader id_job;
        private System.Windows.Forms.ColumnHeader id_app;
        private System.Windows.Forms.ColumnHeader id_user;
        private System.Windows.Forms.ColumnHeader applicationdate;
        private System.Windows.Forms.ColumnHeader datestart;
        private System.Windows.Forms.ColumnHeader dateend;
    }
}