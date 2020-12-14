
namespace MyRRGame
{
    partial class Form1
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_shootaway = new System.Windows.Forms.Button();
            this.picbox_main = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_playagain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(619, 34);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(91, 44);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.Location = new System.Drawing.Point(619, 127);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(81, 39);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = true;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // btn_shoot
            // 
            this.btn_shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shoot.Location = new System.Drawing.Point(619, 218);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(91, 38);
            this.btn_shoot.TabIndex = 2;
            this.btn_shoot.Text = "Shoot";
            this.btn_shoot.UseVisualStyleBackColor = true;
            this.btn_shoot.Click += new System.EventHandler(this.btn_shoot_Click);
            // 
            // btn_shootaway
            // 
            this.btn_shootaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shootaway.Location = new System.Drawing.Point(619, 309);
            this.btn_shootaway.Name = "btn_shootaway";
            this.btn_shootaway.Size = new System.Drawing.Size(116, 69);
            this.btn_shootaway.TabIndex = 3;
            this.btn_shootaway.Text = "Shoot Away";
            this.btn_shootaway.UseVisualStyleBackColor = true;
            this.btn_shootaway.Click += new System.EventHandler(this.btn_shootaway_Click);
            // 
            // picbox_main
            // 
            this.picbox_main.Location = new System.Drawing.Point(34, 34);
            this.picbox_main.Name = "picbox_main";
            this.picbox_main.Size = new System.Drawing.Size(544, 300);
            this.picbox_main.TabIndex = 4;
            this.picbox_main.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(363, 386);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 38);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_playagain
            // 
            this.btn_playagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playagain.Location = new System.Drawing.Point(69, 373);
            this.btn_playagain.Name = "btn_playagain";
            this.btn_playagain.Size = new System.Drawing.Size(131, 65);
            this.btn_playagain.TabIndex = 6;
            this.btn_playagain.Text = "Play Again";
            this.btn_playagain.UseVisualStyleBackColor = true;
            this.btn_playagain.Click += new System.EventHandler(this.btn_playagain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_playagain);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.picbox_main);
            this.Controls.Add(this.btn_shootaway);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.Name = "Form1";
            this.Text = "MyRRGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.Button btn_shootaway;
        private System.Windows.Forms.PictureBox picbox_main;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_playagain;
    }
}

