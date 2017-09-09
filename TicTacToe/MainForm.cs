using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBrain;
using ExtentionMethods;
using static TheBrain.TicTacToeLogic;
using static TheBrain.TicTacToeLogic.CellAssignmentArgs;

/*
 * Nathan Robson
 */

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private TicTacToeLogic ticTacToeLogic = new TicTacToeLogic();

        private void TicTacToeButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var buttonClicked = sender as Button;
                if (buttonClicked == null) { return; }
                if (buttonClicked.Name.Length != 11) { return; }

                var rowNo = buttonClicked.Name.Substring(9, 1).toInt(-1);
                var colNo = buttonClicked.Name.Substring(10, 1).toInt(-1);

                ticTacToeLogic.PlaySquare(rowNo, colNo, TicTacToeEnums.CellOwners.Human);
                CheckForWinner();
            }
            catch
            {
                MessageBox.Show("Error in TicTacToeButtonClicked","Try block thrown", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckForWinner()
        {
            var winner = ticTacToeLogic.IdentifyWinner();
            if(winner.Length > 0)
            {
                MessageBox.Show(winner, "The winner is:");
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            ticTacToeLogic.ResetGrid();

            foreach(var item in tableLayoutPanel1.Controls)
            {
                var btn = item as Button;
                if ((btn != null) && (btn.Text != "Free Space"))
                {
                    if (btn.Name.Length == 11)
                    {
                        var rowNo = btn.Name.Substring(9, 1).toInt(-1);
                        var colNo = btn.Name.Substring(9, 1).toInt(-1);
                        if ((rowNo >= 0) && (colNo >= 0))
                        {
                            btn.Text = "?";
                            btn.Enabled = true;
                            btn.BackColor = Color.Transparent;
                        }
                    }
                    
                }
            }
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            ticTacToeLogic.InitiateAutoplay();
            CheckForWinner();
        }

        

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            ticTacToeLogic.PlayerName = txtPlayerName.Text;
        }

        public void TicTacToeLogic_CellAssignmentChanged(object sender, TicTacToeLogic.CellAssignmentArgs e)
        {
            foreach (var item in tableLayoutPanel1.Controls)
            {
                var btn = item as Button;
                if (btn != null)
                {
                    if ((e.RowId.ToString() == btn.Name.ElementAt(9).ToString()) && (e.ColId.ToString() == btn.Name.ElementAt(10).ToString()))
                    {
                        switch (e.SquareOwner)
                        {
                            case TicTacToeEnums.CellOwners.Computer:
                                btn.Text = "O";
                                btn.BackColor = Color.Red;
                                break;
                            case TicTacToeEnums.CellOwners.Error:
                                btn.Text = "*";
                                break;
                            case TicTacToeEnums.CellOwners.Human:
                                btn.Text = "X";
                                btn.BackColor = Color.Aqua;
                                break;
                            case TicTacToeEnums.CellOwners.Open:
                                btn.Text = "?";
                                break;
                            case TicTacToeEnums.CellOwners.WildCard:
                                btn.Text = "Free Space";
                                break;
                            default:
                                btn.Text = "*";
                                break;
                        }

                        btn.Enabled = false;
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ticTacToeLogic.CellAssignment += 
                new TicTacToeLogic.CellAssignmentChanged(this.TicTacToeLogic_CellAssignmentChanged);
        }
    }
}
