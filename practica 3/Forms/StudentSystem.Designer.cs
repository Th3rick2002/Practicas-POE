namespace practica3.Forms
{
    partial class StudentSystem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxCareer = new TextBox();
            buttonRegister = new Button();
            buttonDelete = new Button();
            listBoxRegister = new ListBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 68);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de almno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 109);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos del alumno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 158);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 2;
            label3.Text = "Número de telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 204);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 3;
            label4.Text = "Carrera del alumno";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(224, 65);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(342, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(224, 109);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(342, 23);
            textBoxLastName.TabIndex = 5;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(224, 158);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(342, 23);
            textBoxPhoneNumber.TabIndex = 6;
            // 
            // textBoxCareer
            // 
            textBoxCareer.Location = new Point(224, 211);
            textBoxCareer.Name = "textBoxCareer";
            textBoxCareer.Size = new Size(342, 23);
            textBoxCareer.TabIndex = 7;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.White;
            buttonRegister.Location = new Point(175, 269);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(75, 23);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "Registrar";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.White;
            buttonDelete.Location = new Point(329, 269);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // listBoxRegister
            // 
            listBoxRegister.FormattingEnabled = true;
            listBoxRegister.ItemHeight = 15;
            listBoxRegister.Location = new Point(53, 318);
            listBoxRegister.Name = "listBoxRegister";
            listBoxRegister.Size = new Size(514, 139);
            listBoxRegister.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(214, 16);
            label5.Name = "label5";
            label5.Size = new Size(190, 28);
            label5.TabIndex = 11;
            label5.Text = "Registro de alumnos";
            // 
            // StudentSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(638, 505);
            Controls.Add(label5);
            Controls.Add(listBoxRegister);
            Controls.Add(buttonDelete);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxCareer);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentSystem";
            Text = "StudentSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxCareer;
        private Button buttonRegister;
        private Button buttonDelete;
        private ListBox listBoxRegister;
        private Label label5;
    }
}