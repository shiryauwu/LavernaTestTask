namespace TestTask
{
    partial class Form1
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
            this.getWeatherButton = new System.Windows.Forms.Button();
            this.temperatureBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.getCityNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getWeatherButton
            // 
            this.getWeatherButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getWeatherButton.Location = new System.Drawing.Point(204, 218);
            this.getWeatherButton.Name = "getWeatherButton";
            this.getWeatherButton.Size = new System.Drawing.Size(167, 33);
            this.getWeatherButton.TabIndex = 0;
            this.getWeatherButton.Text = "Узнать погоду!";
            this.getWeatherButton.UseVisualStyleBackColor = true;
            this.getWeatherButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // temperatureBox
            // 
            this.temperatureBox.Location = new System.Drawing.Point(362, 50);
            this.temperatureBox.Name = "temperatureBox";
            this.temperatureBox.Size = new System.Drawing.Size(150, 23);
            this.temperatureBox.TabIndex = 1;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(363, 114);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(149, 23);
            this.descriptionBox.TabIndex = 2;
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(363, 183);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(149, 23);
            this.speedBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(373, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Температура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(373, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(373, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Скорость ветра";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Введите название города";
            // 
            // getCityNameBox
            // 
            this.getCityNameBox.Location = new System.Drawing.Point(29, 67);
            this.getCityNameBox.Name = "getCityNameBox";
            this.getCityNameBox.Size = new System.Drawing.Size(185, 23);
            this.getCityNameBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 299);
            this.Controls.Add(this.getCityNameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.temperatureBox);
            this.Controls.Add(this.getWeatherButton);
            this.Name = "Form1";
            this.Text = "Узнаватель погоды";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button getWeatherButton;
        private TextBox temperatureBox;
        private TextBox descriptionBox;
        private TextBox speedBox;
        private Label label1;
        private Label label2;
        private Label label3;
        
        private Label label7;
        private TextBox getCityNameBox;
    }
}