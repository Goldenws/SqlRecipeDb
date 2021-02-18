namespace RecipeDB
{
    partial class CookBook
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
            this.listRecipe = new System.Windows.Forms.ListBox();
            this.Recipe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listIngredient = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listRecipe
            // 
            this.listRecipe.FormattingEnabled = true;
            this.listRecipe.ItemHeight = 16;
            this.listRecipe.Location = new System.Drawing.Point(58, 77);
            this.listRecipe.Name = "listRecipe";
            this.listRecipe.Size = new System.Drawing.Size(151, 148);
            this.listRecipe.TabIndex = 0;
            this.listRecipe.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Recipe
            // 
            this.Recipe.AutoSize = true;
            this.Recipe.Location = new System.Drawing.Point(55, 57);
            this.Recipe.Name = "Recipe";
            this.Recipe.Size = new System.Drawing.Size(52, 17);
            this.Recipe.TabIndex = 1;
            this.Recipe.Text = "Recipe";
            this.Recipe.Click += new System.EventHandler(this.Recipe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // listIngredient
            // 
            this.listIngredient.FormattingEnabled = true;
            this.listIngredient.ItemHeight = 16;
            this.listIngredient.Location = new System.Drawing.Point(250, 77);
            this.listIngredient.Name = "listIngredient";
            this.listIngredient.Size = new System.Drawing.Size(148, 148);
            this.listIngredient.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingredients";
            // 
            // CookBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listIngredient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Recipe);
            this.Controls.Add(this.listRecipe);
            this.Name = "CookBook";
            this.Text = "CookBook";
            this.Load += new System.EventHandler(this.CookBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRecipe;
        private System.Windows.Forms.Label Recipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listIngredient;
        private System.Windows.Forms.Label label2;
    }
}

