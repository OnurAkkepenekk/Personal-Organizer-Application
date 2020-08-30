namespace Personal_Organizer_Application
{
    partial class Reminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            this.lblReminder = new System.Windows.Forms.Label();
            this.rdoMeeting = new System.Windows.Forms.RadioButton();
            this.rdoTask = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.mtxtTime = new System.Windows.Forms.MaskedTextBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvRemainderList = new System.Windows.Forms.DataGridView();
            this.lblType = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.Day_TimeShow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemainderList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReminder.Location = new System.Drawing.Point(410, 23);
            this.lblReminder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(105, 30);
            this.lblReminder.TabIndex = 0;
            this.lblReminder.Text = "Reminder";
            // 
            // rdoMeeting
            // 
            this.rdoMeeting.AutoSize = true;
            this.rdoMeeting.Location = new System.Drawing.Point(181, 62);
            this.rdoMeeting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMeeting.Name = "rdoMeeting";
            this.rdoMeeting.Size = new System.Drawing.Size(87, 27);
            this.rdoMeeting.TabIndex = 1;
            this.rdoMeeting.TabStop = true;
            this.rdoMeeting.Text = "Meeting";
            this.rdoMeeting.UseVisualStyleBackColor = true;
            // 
            // rdoTask
            // 
            this.rdoTask.AutoSize = true;
            this.rdoTask.Location = new System.Drawing.Point(294, 62);
            this.rdoTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTask.Name = "rdoTask";
            this.rdoTask.Size = new System.Drawing.Size(63, 27);
            this.rdoTask.TabIndex = 2;
            this.rdoTask.TabStop = true;
            this.rdoTask.Text = "Task";
            this.rdoTask.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(127, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 23);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(127, 151);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 23);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(96, 202);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(81, 23);
            this.lblSummary.TabIndex = 5;
            this.lblSummary.Text = "Summary:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(77, 341);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // mtxtTime
            // 
            this.mtxtTime.Location = new System.Drawing.Point(183, 148);
            this.mtxtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtTime.Mask = "00:00:00";
            this.mtxtTime.Name = "mtxtTime";
            this.mtxtTime.Size = new System.Drawing.Size(102, 30);
            this.mtxtTime.TabIndex = 8;
            this.mtxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(183, 202);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(403, 119);
            this.txtSummary.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(181, 341);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(403, 119);
            this.txtDescription.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(928, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "Update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "List";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Bisque;
            this.BtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.BackgroundImage")));
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnUpdate.Location = new System.Drawing.Point(909, 299);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(90, 86);
            this.BtnUpdate.TabIndex = 65;
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Bisque;
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnDelete.Location = new System.Drawing.Point(798, 300);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(97, 86);
            this.BtnDelete.TabIndex = 64;
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Bisque;
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnAdd.Location = new System.Drawing.Point(696, 300);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(88, 86);
            this.BtnAdd.TabIndex = 63;
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnList
            // 
            this.BtnList.BackColor = System.Drawing.Color.Bisque;
            this.BtnList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnList.BackgroundImage")));
            this.BtnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnList.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnList.Location = new System.Drawing.Point(596, 299);
            this.BtnList.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(87, 87);
            this.BtnList.TabIndex = 62;
            this.BtnList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnList.UseVisualStyleBackColor = false;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 30);
            this.dateTimePicker1.TabIndex = 70;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 38);
            this.btnBack.TabIndex = 71;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvRemainderList
            // 
            this.dgvRemainderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRemainderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemainderList.Location = new System.Drawing.Point(12, 479);
            this.dgvRemainderList.Name = "dgvRemainderList";
            this.dgvRemainderList.Size = new System.Drawing.Size(990, 346);
            this.dgvRemainderList.TabIndex = 72;
            this.dgvRemainderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemainderList_CellDoubleClick);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(125, 62);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 23);
            this.lblType.TabIndex = 73;
            this.lblType.Text = "Type:";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Location = new System.Drawing.Point(771, 64);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(0, 23);
            this.lblShowTime.TabIndex = 74;
            // 
            // Day_TimeShow
            // 
            this.Day_TimeShow.Enabled = true;
            this.Day_TimeShow.Interval = 1000;
            this.Day_TimeShow.Tick += new System.EventHandler(this.Day_TimeShow_Tick);
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1014, 837);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.dgvRemainderList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.mtxtTime);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rdoTask);
            this.Controls.Add(this.rdoMeeting);
            this.Controls.Add(this.lblReminder);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Reminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.Reminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemainderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.RadioButton rdoMeeting;
        private System.Windows.Forms.RadioButton rdoTask;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.MaskedTextBox mtxtTime;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvRemainderList;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Timer Day_TimeShow;
    }
}