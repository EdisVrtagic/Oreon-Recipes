
namespace OreonRecipes
{
    partial class FoodControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodControl));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ClickRecipe = new System.Windows.Forms.Label();
            this.FoodTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FoodName = new System.Windows.Forms.Label();
            this.FoodPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.FPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodPic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FPanel
            // 
            this.FPanel.BorderColor = System.Drawing.Color.Silver;
            this.FPanel.BorderRadius = 6;
            this.FPanel.BorderThickness = 2;
            this.FPanel.Controls.Add(this.ClickRecipe);
            this.FPanel.Controls.Add(this.FoodTime);
            this.FPanel.Controls.Add(this.pictureBox1);
            this.FPanel.Controls.Add(this.FoodName);
            this.FPanel.Controls.Add(this.FoodPic);
            this.FPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.FPanel.Location = new System.Drawing.Point(-1, -1);
            this.FPanel.Name = "FPanel";
            this.FPanel.Size = new System.Drawing.Size(200, 224);
            this.FPanel.TabIndex = 0;
            // 
            // ClickRecipe
            // 
            this.ClickRecipe.AutoSize = true;
            this.ClickRecipe.BackColor = System.Drawing.Color.Transparent;
            this.ClickRecipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClickRecipe.ForeColor = System.Drawing.Color.DimGray;
            this.ClickRecipe.Location = new System.Drawing.Point(58, 192);
            this.ClickRecipe.Name = "ClickRecipe";
            this.ClickRecipe.Size = new System.Drawing.Size(86, 15);
            this.ClickRecipe.TabIndex = 277;
            this.ClickRecipe.Text = "Click for recipe";
            // 
            // FoodTime
            // 
            this.FoodTime.AutoSize = true;
            this.FoodTime.BackColor = System.Drawing.Color.Transparent;
            this.FoodTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FoodTime.Location = new System.Drawing.Point(141, 157);
            this.FoodTime.Name = "FoodTime";
            this.FoodTime.Size = new System.Drawing.Size(33, 15);
            this.FoodTime.TabIndex = 276;
            this.FoodTime.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 275;
            this.pictureBox1.TabStop = false;
            // 
            // FoodName
            // 
            this.FoodName.AutoSize = true;
            this.FoodName.BackColor = System.Drawing.Color.Transparent;
            this.FoodName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FoodName.Location = new System.Drawing.Point(5, 155);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(87, 19);
            this.FoodName.TabIndex = 274;
            this.FoodName.Text = "Food Name";
            // 
            // FoodPic
            // 
            this.FoodPic.BackColor = System.Drawing.Color.Transparent;
            this.FoodPic.BorderRadius = 8;
            this.FoodPic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.FoodPic.ImageRotate = 0F;
            this.FoodPic.InitialImage = null;
            this.FoodPic.Location = new System.Drawing.Point(4, 4);
            this.FoodPic.Name = "FoodPic";
            this.FoodPic.Size = new System.Drawing.Size(192, 145);
            this.FoodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodPic.TabIndex = 273;
            this.FoodPic.TabStop = false;
            // 
            // FoodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.FPanel);
            this.Name = "FoodControl";
            this.Size = new System.Drawing.Size(200, 224);
            this.Load += new System.EventHandler(this.FoodControl_Load);
            this.FPanel.ResumeLayout(false);
            this.FPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel FPanel;
        private System.Windows.Forms.Label ClickRecipe;
        private System.Windows.Forms.Label FoodTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FoodName;
        private Guna.UI2.WinForms.Guna2PictureBox FoodPic;
    }
}
