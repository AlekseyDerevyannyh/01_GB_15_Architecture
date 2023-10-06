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
            columnHeaderId = new ColumnHeader();
            columnHeaderSurName = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            btnUpdateClients = new Button();
            groupBoxAddClient = new GroupBox();
            buttonAddClient = new Button();
            dateTimePickerBirthday = new DateTimePicker();
            labelBirthday = new Label();
            labelPatronymic = new Label();
            textBoxPatronymic = new TextBox();
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            labelSurName = new Label();
            textBoxSurName = new TextBox();
            labelDocument = new Label();
            textBoxDocument = new TextBox();
            listViewPets = new ListView();
            columnHeaderPetId = new ColumnHeader();
            columnHeaderPetClientId = new ColumnHeader();
            columnHeaderPetName = new ColumnHeader();
            columnHeaderPetBirthday = new ColumnHeader();
            btnUpdatePets = new Button();
            columnHeaderDocument = new ColumnHeader();
            columnHeaderClientBirthday = new ColumnHeader();
            groupBoxAddClient.SuspendLayout();
            SuspendLayout();
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderDocument, columnHeaderSurName, columnHeaderFirstName, columnHeaderPatronymic, columnHeaderClientBirthday });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(12, 12);
            listViewClients.MultiSelect = false;
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(677, 204);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "#";
            columnHeaderId.Width = 40;
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
            // btnUpdateClients
            // 
            btnUpdateClients.Location = new Point(12, 222);
            btnUpdateClients.Name = "btnUpdateClients";
            btnUpdateClients.Size = new Size(111, 23);
            btnUpdateClients.TabIndex = 2;
            btnUpdateClients.Text = "View Clients";
            btnUpdateClients.UseVisualStyleBackColor = true;
            btnUpdateClients.Click += btnUpdateClients_Click;
            // 
            // groupBoxAddClient
            // 
            groupBoxAddClient.Controls.Add(buttonAddClient);
            groupBoxAddClient.Controls.Add(dateTimePickerBirthday);
            groupBoxAddClient.Controls.Add(labelBirthday);
            groupBoxAddClient.Controls.Add(labelPatronymic);
            groupBoxAddClient.Controls.Add(textBoxPatronymic);
            groupBoxAddClient.Controls.Add(labelFirstName);
            groupBoxAddClient.Controls.Add(textBoxFirstName);
            groupBoxAddClient.Controls.Add(labelSurName);
            groupBoxAddClient.Controls.Add(textBoxSurName);
            groupBoxAddClient.Controls.Add(labelDocument);
            groupBoxAddClient.Controls.Add(textBoxDocument);
            groupBoxAddClient.Location = new Point(12, 251);
            groupBoxAddClient.Name = "groupBoxAddClient";
            groupBoxAddClient.Size = new Size(314, 220);
            groupBoxAddClient.TabIndex = 3;
            groupBoxAddClient.TabStop = false;
            groupBoxAddClient.Text = "Add new client";
            // 
            // buttonAddClient
            // 
            buttonAddClient.Location = new Point(16, 181);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(95, 23);
            buttonAddClient.TabIndex = 11;
            buttonAddClient.Text = "Add new client";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(89, 138);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(200, 23);
            dateTimePickerBirthday.TabIndex = 10;
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(16, 141);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(51, 15);
            labelBirthday.TabIndex = 9;
            labelBirthday.Text = "Birthday";
            // 
            // labelPatronymic
            // 
            labelPatronymic.AutoSize = true;
            labelPatronymic.Location = new Point(16, 112);
            labelPatronymic.Name = "labelPatronymic";
            labelPatronymic.Size = new Size(68, 15);
            labelPatronymic.TabIndex = 7;
            labelPatronymic.Text = "Patronymic";
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(89, 109);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(200, 23);
            textBoxPatronymic.TabIndex = 6;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(16, 83);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(61, 15);
            labelFirstName.TabIndex = 5;
            labelFirstName.Text = "FirstName";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(89, 80);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(200, 23);
            textBoxFirstName.TabIndex = 4;
            // 
            // labelSurName
            // 
            labelSurName.AutoSize = true;
            labelSurName.Location = new Point(16, 54);
            labelSurName.Name = "labelSurName";
            labelSurName.Size = new Size(56, 15);
            labelSurName.TabIndex = 3;
            labelSurName.Text = "SurName";
            // 
            // textBoxSurName
            // 
            textBoxSurName.Location = new Point(89, 51);
            textBoxSurName.Name = "textBoxSurName";
            textBoxSurName.Size = new Size(200, 23);
            textBoxSurName.TabIndex = 2;
            // 
            // labelDocument
            // 
            labelDocument.AutoSize = true;
            labelDocument.Location = new Point(16, 25);
            labelDocument.Name = "labelDocument";
            labelDocument.Size = new Size(63, 15);
            labelDocument.TabIndex = 1;
            labelDocument.Text = "Document";
            // 
            // textBoxDocument
            // 
            textBoxDocument.Location = new Point(89, 22);
            textBoxDocument.Name = "textBoxDocument";
            textBoxDocument.Size = new Size(200, 23);
            textBoxDocument.TabIndex = 0;
            // 
            // listViewPets
            // 
            listViewPets.Columns.AddRange(new ColumnHeader[] { columnHeaderPetId, columnHeaderPetClientId, columnHeaderPetName, columnHeaderPetBirthday });
            listViewPets.FullRowSelect = true;
            listViewPets.GridLines = true;
            listViewPets.Location = new Point(346, 260);
            listViewPets.MultiSelect = false;
            listViewPets.Name = "listViewPets";
            listViewPets.Size = new Size(343, 152);
            listViewPets.TabIndex = 4;
            listViewPets.UseCompatibleStateImageBehavior = false;
            listViewPets.View = View.Details;
            // 
            // columnHeaderPetId
            // 
            columnHeaderPetId.Text = "#";
            columnHeaderPetId.Width = 40;
            // 
            // columnHeaderPetClientId
            // 
            columnHeaderPetClientId.Text = "ClientId";
            // 
            // columnHeaderPetName
            // 
            columnHeaderPetName.Text = "Name";
            columnHeaderPetName.Width = 130;
            // 
            // columnHeaderPetBirthday
            // 
            columnHeaderPetBirthday.Text = "Birthday";
            columnHeaderPetBirthday.Width = 150;
            // 
            // btnUpdatePets
            // 
            btnUpdatePets.Location = new Point(346, 432);
            btnUpdatePets.Name = "btnUpdatePets";
            btnUpdatePets.Size = new Size(87, 23);
            btnUpdatePets.TabIndex = 5;
            btnUpdatePets.Text = "View Pets";
            btnUpdatePets.UseVisualStyleBackColor = true;
            btnUpdatePets.Click += btnUpdatePets_Click;
            // 
            // columnHeaderDocument
            // 
            columnHeaderDocument.DisplayIndex = 4;
            columnHeaderDocument.Text = "Document";
            columnHeaderDocument.Width = 100;
            // 
            // columnHeaderClientBirthday
            // 
            columnHeaderClientBirthday.Text = "Birthday";
            columnHeaderClientBirthday.Width = 86;
            // 
            // ClinicMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 477);
            Controls.Add(btnUpdatePets);
            Controls.Add(listViewPets);
            Controls.Add(groupBoxAddClient);
            Controls.Add(btnUpdateClients);
            Controls.Add(listViewClients);
            Name = "ClinicMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic";
            groupBoxAddClient.ResumeLayout(false);
            groupBoxAddClient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView listViewClients;
        private Button btnUpdateClients;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
        private GroupBox groupBoxAddClient;
        private TextBox textBoxDocument;
        private Label labelDocument;
        private Label labelSurName;
        private TextBox textBoxSurName;
        private Label labelBirthday;
        private TextBox textBox4;
        private Label labelPatronymic;
        private TextBox textBoxPatronymic;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private DateTimePicker dateTimePickerBirthday;
        private Button buttonAddClient;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listViewPets;
        private ColumnHeader columnHeaderPetId;
        private ColumnHeader columnHeaderPetClientId;
        private ColumnHeader columnHeaderPetName;
        private ColumnHeader columnHeaderPetBirthday;
        private Button btnUpdatePets;
        private ColumnHeader columnHeaderDocument;
        private ColumnHeader columnHeaderClientBirthday;
    }
}