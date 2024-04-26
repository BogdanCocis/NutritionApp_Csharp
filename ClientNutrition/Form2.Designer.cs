namespace ClientNutrition
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
            this.buttonNewMenu = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxIdealWeight = new System.Windows.Forms.TextBox();
            this.textBoxBMI = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelHeightCm = new System.Windows.Forms.Label();
            this.labelWeightKg = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelIdealWeight = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewMenu
            // 
            this.buttonNewMenu.BackColor = System.Drawing.Color.White;
            this.buttonNewMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNewMenu.Location = new System.Drawing.Point(56, 791);
            this.buttonNewMenu.Name = "buttonNewMenu";
            this.buttonNewMenu.Size = new System.Drawing.Size(591, 62);
            this.buttonNewMenu.TabIndex = 0;
            this.buttonNewMenu.Text = "New menu";
            this.buttonNewMenu.UseVisualStyleBackColor = false;
            this.buttonNewMenu.Click += new System.EventHandler(this.buttonNewMenu_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.BackColor = System.Drawing.Color.White;
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(385, 180);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(262, 44);
            this.textBoxHeight.TabIndex = 1;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.BackColor = System.Drawing.Color.White;
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight.Location = new System.Drawing.Point(385, 256);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(262, 44);
            this.textBoxWeight.TabIndex = 2;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            // 
            // textBoxAge
            // 
            this.textBoxAge.BackColor = System.Drawing.Color.White;
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(385, 332);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(262, 44);
            this.textBoxAge.TabIndex = 3;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            // 
            // textBoxIdealWeight
            // 
            this.textBoxIdealWeight.BackColor = System.Drawing.Color.White;
            this.textBoxIdealWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdealWeight.Location = new System.Drawing.Point(385, 418);
            this.textBoxIdealWeight.Name = "textBoxIdealWeight";
            this.textBoxIdealWeight.ReadOnly = true;
            this.textBoxIdealWeight.Size = new System.Drawing.Size(262, 44);
            this.textBoxIdealWeight.TabIndex = 4;
            this.textBoxIdealWeight.TextChanged += new System.EventHandler(this.textBoxIdealWeight_TextChanged);
            // 
            // textBoxBMI
            // 
            this.textBoxBMI.BackColor = System.Drawing.Color.White;
            this.textBoxBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBMI.Location = new System.Drawing.Point(385, 511);
            this.textBoxBMI.Name = "textBoxBMI";
            this.textBoxBMI.ReadOnly = true;
            this.textBoxBMI.Size = new System.Drawing.Size(262, 44);
            this.textBoxBMI.TabIndex = 5;
            this.textBoxBMI.TextChanged += new System.EventHandler(this.textBoxBMI_TextChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.White;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(56, 670);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(591, 65);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelHeightCm
            // 
            this.labelHeightCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeightCm.Location = new System.Drawing.Point(86, 180);
            this.labelHeightCm.Name = "labelHeightCm";
            this.labelHeightCm.Size = new System.Drawing.Size(189, 44);
            this.labelHeightCm.TabIndex = 12;
            this.labelHeightCm.Text = "Height(cm)";
            // 
            // labelWeightKg
            // 
            this.labelWeightKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeightKg.Location = new System.Drawing.Point(86, 256);
            this.labelWeightKg.Name = "labelWeightKg";
            this.labelWeightKg.Size = new System.Drawing.Size(189, 44);
            this.labelWeightKg.TabIndex = 13;
            this.labelWeightKg.Text = "Weight(kg)";
            // 
            // labelAge
            // 
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(86, 335);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(189, 44);
            this.labelAge.TabIndex = 14;
            this.labelAge.Text = "Age";
            // 
            // labelIdealWeight
            // 
            this.labelIdealWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdealWeight.Location = new System.Drawing.Point(86, 421);
            this.labelIdealWeight.Name = "labelIdealWeight";
            this.labelIdealWeight.Size = new System.Drawing.Size(189, 44);
            this.labelIdealWeight.TabIndex = 15;
            this.labelIdealWeight.Text = "Ideal weight";
            // 
            // labelBMI
            // 
            this.labelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMI.Location = new System.Drawing.Point(86, 502);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(189, 44);
            this.labelBMI.TabIndex = 16;
            this.labelBMI.Text = "BMI";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 954);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.labelIdealWeight);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelWeightKg);
            this.Controls.Add(this.labelHeightCm);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxBMI);
            this.Controls.Add(this.textBoxIdealWeight);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonNewMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewMenu;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxIdealWeight;
        private System.Windows.Forms.TextBox textBoxBMI;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelHeightCm;
        private System.Windows.Forms.Label labelWeightKg;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelIdealWeight;
        private System.Windows.Forms.Label labelBMI;
    }
}