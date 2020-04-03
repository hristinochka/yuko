namespace Diploma
{
    partial class EquipmentListAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataListView = new System.Windows.Forms.ListView();
            this.id_equip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_nameofequip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brandequip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workplace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventorynumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_applying = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(299, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataListView
            // 
            this.dataListView.BackColor = System.Drawing.Color.LightBlue;
            this.dataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_equip,
            this.id_type,
            this.id_nameofequip,
            this.brandequip,
            this.workplace,
            this.inventorynumber,
            this.id_applying});
            this.dataListView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataListView.HideSelection = false;
            this.dataListView.Location = new System.Drawing.Point(7, 22);
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(786, 345);
            this.dataListView.TabIndex = 3;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.View = System.Windows.Forms.View.Details;
            // 
            // id_equip
            // 
            this.id_equip.Text = "№ п/п";
            this.id_equip.Width = 49;
            // 
            // id_type
            // 
            this.id_type.Text = "Вид оборудования";
            this.id_type.Width = 122;
            // 
            // id_nameofequip
            // 
            this.id_nameofequip.Text = "Название оборудования";
            this.id_nameofequip.Width = 154;
            // 
            // brandequip
            // 
            this.brandequip.Text = "Марка оборудования";
            this.brandequip.Width = 148;
            // 
            // workplace
            // 
            this.workplace.Text = "Рабочее место";
            this.workplace.Width = 99;
            // 
            // inventorynumber
            // 
            this.inventorynumber.Text = "Инвентарный номер оборудования";
            this.inventorynumber.Width = 220;
            // 
            // id_applying
            // 
            this.id_applying.Text = "Применение";
            this.id_applying.Width = 92;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(299, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EquipmentListAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataListView);
            this.Name = "EquipmentListAdmin";
            this.Text = "EquipmentListAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView dataListView;
        private System.Windows.Forms.ColumnHeader id_equip;
        private System.Windows.Forms.ColumnHeader id_type;
        private System.Windows.Forms.ColumnHeader id_nameofequip;
        private System.Windows.Forms.ColumnHeader brandequip;
        private System.Windows.Forms.ColumnHeader workplace;
        private System.Windows.Forms.ColumnHeader inventorynumber;
        private System.Windows.Forms.ColumnHeader id_applying;
        private System.Windows.Forms.Button button2;
    }
}