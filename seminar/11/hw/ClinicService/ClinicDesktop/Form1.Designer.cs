namespace ClinicDesktop
{
    partial class ClinicMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewClients = new ListView();
            btnUpdateClients = new Button();
            columnHeaderId = new ColumnHeader();
            columnHeaderSurName = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderSurName, columnHeaderFirstName, columnHeaderPatronymic });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(12, 12);
            listViewClients.MultiSelect = false;
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(507, 397);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            // 
            // btnUpdateClients
            // 
            btnUpdateClients.Location = new Point(12, 415);
            btnUpdateClients.Name = "btnUpdateClients";
            btnUpdateClients.Size = new Size(111, 23);
            btnUpdateClients.TabIndex = 2;
            btnUpdateClients.Text = "Update Clients";
            btnUpdateClients.UseVisualStyleBackColor = true;
            btnUpdateClients.Click += btnUpdateClients_Click;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "#";
            // 
            // columnHeaderSurName
            // 
            columnHeaderSurName.Text = "SurName";
            columnHeaderSurName.Width = 150;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "FirstName";
            columnHeaderFirstName.Width = 150;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Patronymic";
            columnHeaderPatronymic.Width = 150;
            // 
            // ClinicMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(btnUpdateClients);
            Controls.Add(listViewClients);
            Name = "ClinicMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic";
            ResumeLayout(false);
        }

        #endregion
        private ListView listViewClients;
        private Button btnUpdateClients;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
    }
}