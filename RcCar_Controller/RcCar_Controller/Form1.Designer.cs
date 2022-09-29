namespace RcCar_Controller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_CodeBlock = new System.Windows.Forms.ListBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_front = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_left = new System.Windows.Forms.Button();
            this.bt_right = new System.Windows.Forms.Button();
            this.pb_Route = new System.Windows.Forms.PictureBox();
            this.bt_handbreak = new System.Windows.Forms.Button();
            this.bt_light = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Route)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Title.Location = new System.Drawing.Point(5, 5);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(916, 28);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "RC카 코드블럭 컨트롤";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CodeBlock
            // 
            this.lb_CodeBlock.FormattingEnabled = true;
            this.lb_CodeBlock.ItemHeight = 15;
            this.lb_CodeBlock.Location = new System.Drawing.Point(728, 38);
            this.lb_CodeBlock.Name = "lb_CodeBlock";
            this.lb_CodeBlock.Size = new System.Drawing.Size(194, 274);
            this.lb_CodeBlock.TabIndex = 2;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(728, 319);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(194, 44);
            this.bt_delete.TabIndex = 3;
            this.bt_delete.Text = "삭제";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_front
            // 
            this.bt_front.Location = new System.Drawing.Point(539, 119);
            this.bt_front.Name = "bt_front";
            this.bt_front.Size = new System.Drawing.Size(78, 38);
            this.bt_front.TabIndex = 4;
            this.bt_front.Text = "전진";
            this.bt_front.UseVisualStyleBackColor = true;
            this.bt_front.Click += new System.EventHandler(this.bt_front_Click);
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(539, 173);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(78, 38);
            this.bt_back.TabIndex = 5;
            this.bt_back.Text = "후진";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_left
            // 
            this.bt_left.Location = new System.Drawing.Point(445, 173);
            this.bt_left.Name = "bt_left";
            this.bt_left.Size = new System.Drawing.Size(78, 38);
            this.bt_left.TabIndex = 6;
            this.bt_left.Text = "좌회전";
            this.bt_left.UseVisualStyleBackColor = true;
            this.bt_left.Click += new System.EventHandler(this.bt_left_Click);
            // 
            // bt_right
            // 
            this.bt_right.Location = new System.Drawing.Point(633, 173);
            this.bt_right.Name = "bt_right";
            this.bt_right.Size = new System.Drawing.Size(78, 38);
            this.bt_right.TabIndex = 7;
            this.bt_right.Text = "우회전";
            this.bt_right.UseVisualStyleBackColor = true;
            this.bt_right.Click += new System.EventHandler(this.bt_right_Click);
            // 
            // pb_Route
            // 
            this.pb_Route.Image = ((System.Drawing.Image)(resources.GetObject("pb_Route.Image")));
            this.pb_Route.Location = new System.Drawing.Point(4, 38);
            this.pb_Route.Name = "pb_Route";
            this.pb_Route.Size = new System.Drawing.Size(429, 325);
            this.pb_Route.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Route.TabIndex = 8;
            this.pb_Route.TabStop = false;
            // 
            // bt_handbreak
            // 
            this.bt_handbreak.Location = new System.Drawing.Point(445, 229);
            this.bt_handbreak.Name = "bt_handbreak";
            this.bt_handbreak.Size = new System.Drawing.Size(124, 38);
            this.bt_handbreak.TabIndex = 9;
            this.bt_handbreak.Text = "브레이크";
            this.bt_handbreak.UseVisualStyleBackColor = true;
            this.bt_handbreak.Click += new System.EventHandler(this.bt_handbreak_Click);
            // 
            // bt_light
            // 
            this.bt_light.Location = new System.Drawing.Point(587, 229);
            this.bt_light.Name = "bt_light";
            this.bt_light.Size = new System.Drawing.Size(124, 38);
            this.bt_light.TabIndex = 10;
            this.bt_light.Text = "비상깜박이";
            this.bt_light.UseVisualStyleBackColor = true;
            this.bt_light.Click += new System.EventHandler(this.bt_light_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(895, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(926, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_light);
            this.Controls.Add(this.bt_handbreak);
            this.Controls.Add(this.pb_Route);
            this.Controls.Add(this.bt_right);
            this.Controls.Add(this.bt_left);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_front);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.lb_CodeBlock);
            this.Controls.Add(this.lb_Title);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Route)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lb_Title;
        private ListBox lb_CodeBlock;
        private Button bt_delete;
        private Button bt_front;
        private Button bt_back;
        private Button bt_left;
        private Button bt_right;
        private PictureBox pb_Route;
        private Button bt_handbreak;
        private Button bt_light;
        private Button button1;
    }
}