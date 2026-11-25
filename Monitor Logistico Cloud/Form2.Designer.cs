namespace Monitor_Logistico_Cloud
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.basicotxt = new System.Windows.Forms.MaskedTextBox();
            this.pisostxt = new System.Windows.Forms.MaskedTextBox();
            this.areiatxt = new System.Windows.Forms.MaskedTextBox();
            this.atulizarbasicobtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basico/ Diversos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pisos/ Porcelanatos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Areia/ Pedra:";
            // 
            // basicotxt
            // 
            this.basicotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicotxt.Location = new System.Drawing.Point(351, 129);
            this.basicotxt.Mask = "00:00";
            this.basicotxt.Name = "basicotxt";
            this.basicotxt.Size = new System.Drawing.Size(119, 34);
            this.basicotxt.TabIndex = 3;
            this.basicotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pisostxt
            // 
            this.pisostxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisostxt.Location = new System.Drawing.Point(351, 224);
            this.pisostxt.Mask = "00:00";
            this.pisostxt.Name = "pisostxt";
            this.pisostxt.Size = new System.Drawing.Size(119, 34);
            this.pisostxt.TabIndex = 4;
            this.pisostxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // areiatxt
            // 
            this.areiatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areiatxt.Location = new System.Drawing.Point(351, 320);
            this.areiatxt.Mask = "00:00";
            this.areiatxt.Name = "areiatxt";
            this.areiatxt.Size = new System.Drawing.Size(119, 34);
            this.areiatxt.TabIndex = 5;
            this.areiatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // atulizarbasicobtn
            // 
            this.atulizarbasicobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atulizarbasicobtn.Location = new System.Drawing.Point(549, 129);
            this.atulizarbasicobtn.Name = "atulizarbasicobtn";
            this.atulizarbasicobtn.Size = new System.Drawing.Size(130, 34);
            this.atulizarbasicobtn.TabIndex = 6;
            this.atulizarbasicobtn.Text = "Atualizar";
            this.atulizarbasicobtn.UseVisualStyleBackColor = true;
            this.atulizarbasicobtn.Click += new System.EventHandler(this.atulizarbasicobtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(549, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(549, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(770, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Insira o tempo medio para entrega no campo adequado ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.atulizarbasicobtn);
            this.Controls.Add(this.areiatxt);
            this.Controls.Add(this.pisostxt);
            this.Controls.Add(this.basicotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox basicotxt;
        private System.Windows.Forms.MaskedTextBox pisostxt;
        private System.Windows.Forms.MaskedTextBox areiatxt;
        private System.Windows.Forms.Button atulizarbasicobtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}