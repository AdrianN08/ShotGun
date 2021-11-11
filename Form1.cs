using System;
using System.Windows.Forms;

namespace ShotGun
{
    public partial class Form1 : Form
    {
        CPU cpuDuelist = new CPU();
        Player player = new Player();

        bool gameOver;       
        int countTicker = 4;

        public Form1()
        {
            InitializeComponent();
            ResetDuel();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            picBoxPlayer.Image = Properties.Resources.Shot_gun;
            player.Action("shoot");
            countDownTimer.Enabled = true;

        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            picBoxPlayer.Image = Properties.Resources.Relaod;
            player.Action("reload");
            countDownTimer.Enabled = true;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            picBoxPlayer.Image = Properties.Resources.Block;
            player.Action("block");
            countDownTimer.Enabled = true;

        }
        private void btnShotGun_Click(object sender, EventArgs e)
        {
            picBoxPlayer.Image = Properties.Resources.Shot_gun;
            player.Action("shot gun");
            countDownTimer.Enabled = true;

        }
        private void btnDuelAgain_Click(object sender, EventArgs e)
        {
            ResetDuel();
        }

        private void CountDownTimer(object sender, EventArgs e)
        {
            countTicker -= 1;
            txtCountDown.Text = countTicker.ToString();

            if (countTicker < 1)
            {
                countDownTimer.Enabled = false;
                countTicker = 4;
                cpuDuelist.Action();

                switch (cpuDuelist.Choice)
                {
                    case "shoot":
                        picBoxCpu.Image = Properties.Resources.Shot_gunCPU;
                        break;
                    case "reload":
                        picBoxCpu.Image = Properties.Resources.Relaod;
                        break;
                    case "block":
                        picBoxCpu.Image = Properties.Resources.Block;
                        break;
                    case "shot gun":
                        picBoxCpu.Image = Properties.Resources.Shot_gunCPU;
                        break;
                }

                CheakGame();
            }

        }

        private void CheakGame()
        {
            switch (player.Choice, cpuDuelist.Choice)
            {
                case ("reload", "reload"):
                    player.Ammo ++;
                    cpuDuelist.Ammo ++;
                    MessageBox.Show("You both reloaded and got 1 more shot to shoot!");
                    break;
                case ("reload", "block"):
                    player.Ammo ++;
                    MessageBox.Show("Smooth reload! you got 1 more shot to shoot!");
                    break;
                case ("block", "reload"):
                    cpuDuelist.Ammo ++;
                    MessageBox.Show("Be careful! he got 1 more shot to shoot!");
                    break;
                case ("block", "block"):
                    MessageBox.Show("To afraid mutch?!");
                    break;
                case ("shoot", "block"):
                    player.Ammo --;
                    MessageBox.Show("Damn son! he blocked you good!");
                    break;
                case ("block", "shoot"):
                    cpuDuelist.Ammo --;
                    MessageBox.Show("Now thats what im talking about! Great block!");
                    break;
                case ("shoot", "shoot"):
                    player.Ammo --;
                    cpuDuelist.Ammo --;
                    MessageBox.Show("Good shoot! You both loose a shot");
                    break;
                case ("shoot", "reload"):
                    MessageBox.Show("YOU GOT HIM, YOU WON THE GAME");
                    gameOver = true;
                    break;
                case ("reload", "shoot"):
                    MessageBox.Show("YOU LOOSE!");
                    gameOver = true;
                    break;
                case ("shot gun", "shot gun"):
                    MessageBox.Show("BOOM! BOTH ARE DEAD! IT'S A DRAW!!");
                    break;
            }

            if (player.Choice == "shot gun")
            {
                MessageBox.Show("BOOM! YOU GOT HIM, YOU WON THE GAME");
                gameOver = true;
            }
            else if (cpuDuelist.Choice == "shot gun")
            {
                MessageBox.Show("YOU LOOSE!");
                gameOver = true;
            }

            CountinueDuel();
        }

        private void CountinueDuel()
        {
            if (gameOver == true) return;

            cpuDuelist.firstGame = false;
            countDownTimer.Enabled = false;
            txtCountDown.Text = "";

            if (player.Ammo < 1)
            {
                btnShoot.Enabled = false;
            }
            else if (player.Ammo == 3)
            {
                btnShotGun.Enabled = true;
            }
            else
            {
                btnShoot.Enabled = true;
            }
            QuestionMarkPic();
            CurrentAmmo();

        }
        public void ResetDuel()
        {
            player.Ammo = 0;
            cpuDuelist.Ammo = 0;

            btnShotGun.Enabled = false;
            btnShoot.Enabled = false;
            cpuDuelist.firstGame = true;
            gameOver = false;

            QuestionMarkPic();
            CurrentAmmo();
        }
        public void QuestionMarkPic()
        {
            picBoxCpu.Image = Properties.Resources.QuestionMark;
            picBoxPlayer.Image = Properties.Resources.QuestionMark;
        }
        public void CurrentAmmo()
        {
            txtPlayerAmmo.Text = "Ammo: " + player.Ammo;
            txtCpuAmmo.Text = "Ammo: " + cpuDuelist.Ammo;
        }

    }
}
