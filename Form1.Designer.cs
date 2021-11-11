
namespace ShotGun
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
            this.components = new System.ComponentModel.Container();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer = new System.Windows.Forms.PictureBox();
            this.picBoxCpu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountDown = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.txtPlayerAmmo = new System.Windows.Forms.Label();
            this.txtCpuAmmo = new System.Windows.Forms.Label();
            this.btnShotGun = new System.Windows.Forms.Button();
            this.btnDuelAgain = new System.Windows.Forms.Button();
            this.txtMakeAMove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(38, 40);
            this.btnShoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(82, 22);
            this.btnShoot.TabIndex = 5;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(38, 76);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 22);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(38, 112);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(82, 22);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShotGun.Properties.Resources.Duel;
            this.pictureBox1.Location = new System.Drawing.Point(199, 207);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxPlayer
            // 
            this.picBoxPlayer.Image = global::ShotGun.Properties.Resources.QuestionMark;
            this.picBoxPlayer.Location = new System.Drawing.Point(153, 40);
            this.picBoxPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxPlayer.Name = "picBoxPlayer";
            this.picBoxPlayer.Size = new System.Drawing.Size(184, 150);
            this.picBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayer.TabIndex = 6;
            this.picBoxPlayer.TabStop = false;
            // 
            // picBoxCpu
            // 
            this.picBoxCpu.Image = global::ShotGun.Properties.Resources.QuestionMark;
            this.picBoxCpu.Location = new System.Drawing.Point(451, 40);
            this.picBoxCpu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxCpu.Name = "picBoxCpu";
            this.picBoxCpu.Size = new System.Drawing.Size(184, 150);
            this.picBoxCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCpu.TabIndex = 8;
            this.picBoxCpu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(524, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPU";
            // 
            // txtCountDown
            // 
            this.txtCountDown.AutoSize = true;
            this.txtCountDown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCountDown.Location = new System.Drawing.Point(379, 99);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(0, 37);
            this.txtCountDown.TabIndex = 10;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.CountDownTimer);
            // 
            // txtPlayerAmmo
            // 
            this.txtPlayerAmmo.AutoSize = true;
            this.txtPlayerAmmo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPlayerAmmo.Location = new System.Drawing.Point(47, 183);
            this.txtPlayerAmmo.Name = "txtPlayerAmmo";
            this.txtPlayerAmmo.Size = new System.Drawing.Size(57, 15);
            this.txtPlayerAmmo.TabIndex = 11;
            this.txtPlayerAmmo.Text = "Ammo: 0";
            // 
            // txtCpuAmmo
            // 
            this.txtCpuAmmo.AutoSize = true;
            this.txtCpuAmmo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCpuAmmo.Location = new System.Drawing.Point(665, 183);
            this.txtCpuAmmo.Name = "txtCpuAmmo";
            this.txtCpuAmmo.Size = new System.Drawing.Size(57, 15);
            this.txtCpuAmmo.TabIndex = 11;
            this.txtCpuAmmo.Text = "Ammo: 0";
            // 
            // btnShotGun
            // 
            this.btnShotGun.Location = new System.Drawing.Point(38, 148);
            this.btnShotGun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShotGun.Name = "btnShotGun";
            this.btnShotGun.Size = new System.Drawing.Size(82, 22);
            this.btnShotGun.TabIndex = 12;
            this.btnShotGun.Text = "SHOT GUN!";
            this.btnShotGun.UseVisualStyleBackColor = true;
            this.btnShotGun.Click += new System.EventHandler(this.btnShotGun_Click);
            // 
            // btnDuelAgain
            // 
            this.btnDuelAgain.Location = new System.Drawing.Point(350, 377);
            this.btnDuelAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDuelAgain.Name = "btnDuelAgain";
            this.btnDuelAgain.Size = new System.Drawing.Size(82, 22);
            this.btnDuelAgain.TabIndex = 0;
            this.btnDuelAgain.Text = "Duel Again";
            this.btnDuelAgain.UseVisualStyleBackColor = true;
            this.btnDuelAgain.Click += new System.EventHandler(this.btnDuelAgain_Click);
            // 
            // txtMakeAMove
            // 
            this.txtMakeAMove.AutoSize = true;
            this.txtMakeAMove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMakeAMove.Location = new System.Drawing.Point(314, 345);
            this.txtMakeAMove.Name = "txtMakeAMove";
            this.txtMakeAMove.Size = new System.Drawing.Size(155, 15);
            this.txtMakeAMove.TabIndex = 13;
            this.txtMakeAMove.Text = "Make Your Move Gunman!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 410);
            this.Controls.Add(this.txtMakeAMove);
            this.Controls.Add(this.btnDuelAgain);
            this.Controls.Add(this.btnShotGun);
            this.Controls.Add(this.txtCpuAmmo);
            this.Controls.Add(this.txtPlayerAmmo);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxCpu);
            this.Controls.Add(this.picBoxPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnShoot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Shot Gun";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxPlayer;
        private System.Windows.Forms.PictureBox picBoxCpu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label txtPlayerAmmo;
        private System.Windows.Forms.Label txtCpuAmmo;
        private System.Windows.Forms.Button btnShotGun;
        private System.Windows.Forms.Button btnDuelAgain;
        private System.Windows.Forms.Label txtMakeAMove;
    }
}

