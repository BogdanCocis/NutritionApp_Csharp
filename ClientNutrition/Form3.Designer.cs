namespace ClientNutrition
{
    partial class Form3
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
            this.listBoxViewPlans = new System.Windows.Forms.ListBox();
            this.buttonAddAliment = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxViewAliment = new System.Windows.Forms.ListBox();
            this.textBoxAddElement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxViewAddAliment = new System.Windows.Forms.ListBox();
            this.textBoxNumberfOfCalorie = new System.Windows.Forms.TextBox();
            this.calculateIdealWeightResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMacronutrient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCalorieConsumed = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculateIdealWeightResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxViewPlans
            // 
            this.listBoxViewPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxViewPlans.FormattingEnabled = true;
            this.listBoxViewPlans.ItemHeight = 46;
            this.listBoxViewPlans.Location = new System.Drawing.Point(1278, 96);
            this.listBoxViewPlans.Name = "listBoxViewPlans";
            this.listBoxViewPlans.Size = new System.Drawing.Size(804, 970);
            this.listBoxViewPlans.TabIndex = 0;
            this.listBoxViewPlans.SelectedIndexChanged += new System.EventHandler(this.listBoxViewPlans_SelectedIndexChanged);
            // 
            // buttonAddAliment
            // 
            this.buttonAddAliment.Location = new System.Drawing.Point(62, 1004);
            this.buttonAddAliment.Name = "buttonAddAliment";
            this.buttonAddAliment.Size = new System.Drawing.Size(196, 62);
            this.buttonAddAliment.TabIndex = 1;
            this.buttonAddAliment.Text = "ADD";
            this.buttonAddAliment.UseVisualStyleBackColor = true;
            this.buttonAddAliment.Click += new System.EventHandler(this.buttonAddAliment_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1017, 1004);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(196, 62);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(369, 1004);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(196, 62);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(687, 1004);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(196, 62);
            this.buttonMove.TabIndex = 4;
            this.buttonMove.Text = "MOVE";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hELPToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2094, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.hELPToolStripMenuItem.Text = "HELP";
            this.hELPToolStripMenuItem.Click += new System.EventHandler(this.hELPToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // listBoxViewAliment
            // 
            this.listBoxViewAliment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxViewAliment.FormattingEnabled = true;
            this.listBoxViewAliment.ItemHeight = 46;
            this.listBoxViewAliment.Location = new System.Drawing.Point(48, 96);
            this.listBoxViewAliment.Name = "listBoxViewAliment";
            this.listBoxViewAliment.Size = new System.Drawing.Size(559, 464);
            this.listBoxViewAliment.TabIndex = 6;
            this.listBoxViewAliment.SelectedIndexChanged += new System.EventHandler(this.listBoxViewAliment_SelectedIndexChanged);
            // 
            // textBoxAddElement
            // 
            this.textBoxAddElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddElement.Location = new System.Drawing.Point(514, 617);
            this.textBoxAddElement.Name = "textBoxAddElement";
            this.textBoxAddElement.Size = new System.Drawing.Size(734, 53);
            this.textBoxAddElement.TabIndex = 7;
            this.textBoxAddElement.TextChanged += new System.EventHandler(this.textBoxAddElement_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 712);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of calorie";
            // 
            // listBoxViewAddAliment
            // 
            this.listBoxViewAddAliment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxViewAddAliment.FormattingEnabled = true;
            this.listBoxViewAddAliment.ItemHeight = 46;
            this.listBoxViewAddAliment.Location = new System.Drawing.Point(671, 96);
            this.listBoxViewAddAliment.Name = "listBoxViewAddAliment";
            this.listBoxViewAddAliment.Size = new System.Drawing.Size(577, 464);
            this.listBoxViewAddAliment.TabIndex = 9;
            this.listBoxViewAddAliment.SelectedIndexChanged += new System.EventHandler(this.listBoxViewAddAliment_SelectedIndexChanged);
            // 
            // textBoxNumberfOfCalorie
            // 
            this.textBoxNumberfOfCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberfOfCalorie.Location = new System.Drawing.Point(514, 709);
            this.textBoxNumberfOfCalorie.Name = "textBoxNumberfOfCalorie";
            this.textBoxNumberfOfCalorie.Size = new System.Drawing.Size(734, 44);
            this.textBoxNumberfOfCalorie.TabIndex = 10;
            this.textBoxNumberfOfCalorie.TextChanged += new System.EventHandler(this.textBoxNumberfOfCalorie_TextChanged);
            // 
            // calculateIdealWeightResponseBindingSource
            // 
            this.calculateIdealWeightResponseBindingSource.DataSource = typeof(ClientNutrition.ServiceNutrition.CalculateIdealWeightResponse);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name of aliment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 808);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Macronutrient";
            // 
            // textBoxMacronutrient
            // 
            this.textBoxMacronutrient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMacronutrient.Location = new System.Drawing.Point(514, 801);
            this.textBoxMacronutrient.Name = "textBoxMacronutrient";
            this.textBoxMacronutrient.Size = new System.Drawing.Size(734, 44);
            this.textBoxMacronutrient.TabIndex = 13;
            this.textBoxMacronutrient.TextChanged += new System.EventHandler(this.textBoxMacronutrient_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 888);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "Calories consumed";
            // 
            // textBoxCalorieConsumed
            // 
            this.textBoxCalorieConsumed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalorieConsumed.Location = new System.Drawing.Point(518, 881);
            this.textBoxCalorieConsumed.Name = "textBoxCalorieConsumed";
            this.textBoxCalorieConsumed.Size = new System.Drawing.Size(730, 44);
            this.textBoxCalorieConsumed.TabIndex = 15;
            this.textBoxCalorieConsumed.TextChanged += new System.EventHandler(this.textBoxCalorieConsumed_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2094, 1120);
            this.Controls.Add(this.textBoxCalorieConsumed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMacronutrient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumberfOfCalorie);
            this.Controls.Add(this.listBoxViewAddAliment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddElement);
            this.Controls.Add(this.listBoxViewAliment);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddAliment);
            this.Controls.Add(this.listBoxViewPlans);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculateIdealWeightResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxViewPlans;
        private System.Windows.Forms.Button buttonAddAliment;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.BindingSource calculateIdealWeightResponseBindingSource;
        private System.Windows.Forms.ListBox listBoxViewAliment;
        private System.Windows.Forms.TextBox textBoxAddElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxViewAddAliment;
        private System.Windows.Forms.TextBox textBoxNumberfOfCalorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMacronutrient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCalorieConsumed;
    }
}