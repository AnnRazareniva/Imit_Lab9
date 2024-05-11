namespace _9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.NN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Prob4 = new System.Windows.Forms.TextBox();
            this.Prob3 = new System.Windows.Forms.TextBox();
            this.Prob2 = new System.Windows.Forms.TextBox();
            this.Prob1 = new System.Windows.Forms.TextBox();
            this.auto = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.Avarage = new System.Windows.Forms.Label();
            this.Variance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Xi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // NN
            // 
            this.NN.Location = new System.Drawing.Point(206, 413);
            this.NN.Name = "NN";
            this.NN.Size = new System.Drawing.Size(67, 20);
            this.NN.TabIndex = 31;
            this.NN.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Количество попыток";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(298, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 96);
            this.button1.TabIndex = 29;
            this.button1.Text = "ПОЕХАЛИ!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Вероятность 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Вероятность 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Вероятность 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Вероятность 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Вероятность 1";
            // 
            // Prob4
            // 
            this.Prob4.Location = new System.Drawing.Point(188, 316);
            this.Prob4.Name = "Prob4";
            this.Prob4.Size = new System.Drawing.Size(67, 20);
            this.Prob4.TabIndex = 23;
            this.Prob4.Text = "0,1";
            // 
            // Prob3
            // 
            this.Prob3.Location = new System.Drawing.Point(188, 273);
            this.Prob3.Name = "Prob3";
            this.Prob3.Size = new System.Drawing.Size(67, 20);
            this.Prob3.TabIndex = 22;
            this.Prob3.Text = "0,2";
            // 
            // Prob2
            // 
            this.Prob2.Location = new System.Drawing.Point(188, 227);
            this.Prob2.Name = "Prob2";
            this.Prob2.Size = new System.Drawing.Size(67, 20);
            this.Prob2.TabIndex = 21;
            this.Prob2.Text = "0,2";
            // 
            // Prob1
            // 
            this.Prob1.Location = new System.Drawing.Point(188, 182);
            this.Prob1.Name = "Prob1";
            this.Prob1.Size = new System.Drawing.Size(67, 20);
            this.Prob1.TabIndex = 20;
            this.Prob1.Text = "0,1";
            // 
            // auto
            // 
            this.auto.Location = new System.Drawing.Point(188, 359);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(61, 21);
            this.auto.TabIndex = 19;
            this.auto.Text = "Авто";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(310, 78);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Data";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(439, 355);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Мат. ожидание";
            // 
            // Avarage
            // 
            this.Avarage.AutoSize = true;
            this.Avarage.Location = new System.Drawing.Point(439, 464);
            this.Avarage.Name = "Avarage";
            this.Avarage.Size = new System.Drawing.Size(54, 13);
            this.Avarage.TabIndex = 34;
            this.Avarage.Text = "значение";
            // 
            // Variance
            // 
            this.Variance.AutoSize = true;
            this.Variance.Location = new System.Drawing.Point(439, 510);
            this.Variance.Name = "Variance";
            this.Variance.Size = new System.Drawing.Size(54, 13);
            this.Variance.TabIndex = 35;
            this.Variance.Text = "значение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Дисперсия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 555);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Хи-квадрад";
            // 
            // Xi
            // 
            this.Xi.AutoSize = true;
            this.Xi.Location = new System.Drawing.Point(439, 555);
            this.Xi.Name = "Xi";
            this.Xi.Size = new System.Drawing.Size(54, 13);
            this.Xi.TabIndex = 38;
            this.Xi.Text = "значение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 709);
            this.Controls.Add(this.Xi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Variance);
            this.Controls.Add(this.Avarage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.NN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prob4);
            this.Controls.Add(this.Prob3);
            this.Controls.Add(this.Prob2);
            this.Controls.Add(this.Prob1);
            this.Controls.Add(this.auto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Prob4;
        private System.Windows.Forms.TextBox Prob3;
        private System.Windows.Forms.TextBox Prob2;
        private System.Windows.Forms.TextBox Prob1;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Avarage;
        private System.Windows.Forms.Label Variance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Xi;
    }
}

