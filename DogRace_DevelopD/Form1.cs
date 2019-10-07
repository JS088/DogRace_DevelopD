using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace_DevelopD
{
    public partial class Form1 : Form
    {

        //global variable and object of the class
        game obj_game = new game();

        String player_Index = "";
        String dog_Index = "";
        String bet_Amount = "";
        int frst = 100, scnd = 150, thrd = 130;

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // find the winner contestant from the player and display the result 

            First_Runner.Top = First_Runner.Top - obj_game.moveUp();
            Second_Runner.Top = Second_Runner.Top - obj_game.moveUp();
            Thrd_Runner.Top = Thrd_Runner.Top - obj_game.moveUp();
            Forth_Runner.Top = Forth_Runner.Top - obj_game.moveUp();

            if (First_Runner.Top <=20) {
                timer1.Stop();
                pb_Fan.Visible = true;
                MessageBox.Show("First is the Winner");
                result(1);
            } else if (Second_Runner.Top <= 20) {
                timer1.Stop();
                pb_Fan.Visible = true;
                MessageBox.Show("Second is the Winner");
                result(2);

            } else if (Thrd_Runner.Top <= 20) {
                timer1.Stop();
                pb_Fan.Visible = true;
                MessageBox.Show("Third is the Winner");
                result(3);

            } else if (Forth_Runner.Top<=20) {
                timer1.Stop();
                pb_Fan.Visible = true;
                MessageBox.Show("Forth is the Winner");
                result(4);
            }

            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sound.wav");
            player.Play();
        }

         //declare the result of the game after playing the game 
        public void result(int dog_No) {


            try
            {
                String[] pl = player_Index.Split(',');
                String[] dog = dog_Index.Split(',');
                String[] amt = bet_Amount.Split(',');

                //0 player_index
                //1 dog_index
                //12 bet_Amount

                //Comparer the winner dog with the betting dog and reset the account of the player
                for (int y = 0; y < pl.Length - 1; y++)
                {

                    int idx = Convert.ToInt32(pl[y]);

                    int ply_Amt = Convert.ToInt32(Cb_Player.Items[idx].ToString().Substring(0, Cb_Player.Items[idx].ToString().IndexOf(' ')));


                    String lst_details = Cb_Player.Items[idx].ToString().Substring(3);


                    if (Convert.ToInt32(dog[y]) == dog_No)
                    {
                        ply_Amt = ply_Amt + Convert.ToInt32(amt[y]);
                        Cb_Player.Items[idx] = ply_Amt + " " + lst_details;

                    }
                    else
                    {
                        ply_Amt = ply_Amt - Convert.ToInt32(amt[y]);
                        Cb_Player.Items[idx] = ply_Amt + " " + lst_details;
                    }

                }



                //after printing the result reset the game so can play again 
                frst = Convert.ToInt32(Cb_Player.Items[0].ToString().Substring(0, Cb_Player.Items[0].ToString().IndexOf(' ')));
                scnd = Convert.ToInt32(Cb_Player.Items[1].ToString().Substring(0, Cb_Player.Items[1].ToString().IndexOf(' ')));
                thrd = Convert.ToInt32(Cb_Player.Items[2].ToString().Substring(0, Cb_Player.Items[2].ToString().IndexOf(' ')));

            }
            catch (Exception ex) {
                    
            }


            First_Runner.Top =429;
            Second_Runner.Top = 429;
            Thrd_Runner.Top = 429;
            Forth_Runner.Top = 429;
            player_Index = "";
            dog_Index = "";
            bet_Amount = "";
            Cb_Player.Text = "";
            cb_Dog.Text = "";
            nm_Amount.Value =1;

            btn_Start.Enabled = false;
            btn_Start.Text = "wait";

            pb_Fan.Visible = false;



        }

        public Form1()
        {
            
            InitializeComponent();
            btn_Start.Enabled = false;
        }

        private void btn_Bet_Click(object sender, EventArgs e)
        {
            // get the information of the player who want to participate in the game and store the amount and dog no in the memory 
            try
            {
                int err = 0;
                if (!Cb_Player.Text.ToString().Equals("") && !cb_Dog.Text.ToString().Equals(""))
                {

                    

                    if (Cb_Player.SelectedIndex == 0 && nm_Amount.Value <= frst && !cb_Dog.SelectedItem.ToString().Equals(""))
                    {
                        player_Index = player_Index + Cb_Player.SelectedIndex + ",";
                        dog_Index = dog_Index + cb_Dog.SelectedItem + ",";
                        bet_Amount = bet_Amount + nm_Amount.Value + ",";
                        btn_Start.Enabled = true;
                        btn_Start.Text = "Run";
                    }
                    else if (Cb_Player.SelectedIndex == 1 && nm_Amount.Value <= scnd && !cb_Dog.SelectedItem.ToString().Equals(""))
                    {
                        player_Index = player_Index + Cb_Player.SelectedIndex + ",";
                        dog_Index = dog_Index + cb_Dog.SelectedItem + ",";
                        bet_Amount = bet_Amount + nm_Amount.Value + ",";
                        btn_Start.Enabled = true;
                        btn_Start.Text = "Run";

                    }
                    else if (Cb_Player.SelectedIndex == 2 && nm_Amount.Value <= thrd && !cb_Dog.SelectedItem.ToString().Equals(""))
                    {
                        player_Index = player_Index + Cb_Player.SelectedIndex + ",";
                        dog_Index = dog_Index + cb_Dog.SelectedItem + ",";
                        bet_Amount = bet_Amount + nm_Amount.Value + ",";
                        btn_Start.Enabled = true;
                        btn_Start.Text = "Run";

                    }
                    else
                    {
                        err++;
                    }
                    if (err > 0)
                    {
                        MessageBox.Show("Verify the Bet Amount or see the term and condition ");
                    }
                    else
                    {
                        err = 0;
                    }
                }
                else {
                    MessageBox.Show("Select the player first");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("verify the whole process once");
            }
        }
    }
}
