using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogicLayer;
using GameObjects;

namespace WinformPresentation
{
    public partial class mainFrm : Form
    {
        private Dealer _dealer = new Dealer();
        private ResourceManager _RM =
            new ResourceManager("WinformPresentation.CardsFile",
                Assembly.GetExecutingAssembly());
        private Hand _hand;

        // When the program starts set bank to $1000
        private int _pBank = 1000;

        public mainFrm()
        {
            InitializeComponent();
        }

        // When the program is started it resets the cards
        private void mainFrm_Load(object sender, EventArgs e)
        {
            resetCardDisplay();
        }

        // Reset the game so that the cards display the card back
        private void resetCardDisplay()
        {
            dealersCard1.Image = (Image)_RM.GetObject("CardBack");
            dealersCard2.Image = (Image)_RM.GetObject("CardBack");
            dealersCard3.Image = (Image)_RM.GetObject("CardBack");
            dealersCard4.Image = (Image)_RM.GetObject("CardBack");

            playerCard1.Image = (Image)_RM.GetObject("CardBack");
            playerCard2.Image = (Image)_RM.GetObject("CardBack");
            playerCard3.Image = (Image)_RM.GetObject("CardBack");
            playerCard4.Image = (Image)_RM.GetObject("CardBack");

            // Add the players winnings (if any) to the bank
            playerBank.Text = "$" + _pBank.ToString() + ".00";

            // Reset the player and dealers score back to zero
            DlrScore.Text = "0";
            plyerScore.Text = "0";

            // The deal button and the betting are enabled
            hitBtn.Enabled = false;
            standBtn.Enabled = false;
            dealBtn.Enabled = true;
            betAmount.Enabled = true;

            standBtn.Text = "Stand";
        }

        // Deals two cards to the player and user
        private void startGame()
        {
            // Displays the players first two cards
            playerCard1.Image = (Image)_RM.GetObject(_hand.Cards[0].ImageName);
            playerCard2.Image = (Image)_RM.GetObject(_hand.Cards[1].ImageName);
            playerCard3.Image = (Image)_RM.GetObject("");
            playerCard4.Image = (Image)_RM.GetObject("");

            // Displays only one card for the dealer
            dealersCard1.Image = (Image)_RM.GetObject(_hand.Cards[4].ImageName);
            dealersCard2.Image = (Image)_RM.GetObject("CardBack");
            dealersCard3.Image = (Image)_RM.GetObject("");
            dealersCard4.Image = (Image)_RM.GetObject("");
        }

        // When clicked it starts the game
        private void dealBtn_Click(object sender, EventArgs e)
        {
            // If the bank is at 0 display the message and end the game
            if (_pBank <= 0)
            {
                MessageBox.Show("You are out of credits!");
                Close();
            }
            // If the bet amount is more than whats in the bank display the message and return
            else if ((int)betAmount.Value > _pBank)
            {
                MessageBox.Show("You cannot bet more than what is in the bank!");
                return;
            }

            // Subtracts the bet amount from the bank
            _pBank -= (int)betAmount.Value;

            // When the deal button is clicked it disables betting and itself
            dealBtn.Enabled = false;
            betAmount.Enabled = false;
            hitBtn.Enabled = true;
            standBtn.Enabled = true;

            // Displays the bank after the bet amount has been subtracted
            playerBank.Text = "$" + _pBank.ToString() + ".00";

            // Creates 8 random cards to use
            _hand = _dealer.NewHand();
            startGame();

            // Scores the players first two cards
            plyerScore.Text = _dealer.GetScore(_hand).ToString();
            
        }

        // Deals a card to the player everytime it is clicked
        int HitButtonClick = 0;
        private void hitBtn_Click(object sender, EventArgs e)
        {
            // Increament HitButtonClick
            ++HitButtonClick;

            // Switch case is created to have the hit button do something different
            // after it is clicked
            switch (HitButtonClick)
            {
                // The first click will display the third card and add it to the score
                case 1:
                    playerCard3.Image = (Image)_RM.GetObject(_hand.Cards[2].ImageName);
                    plyerScore.Text = _dealer.GetNextScore(_hand).ToString();

                    // If the players score goes over 21 the game stops and is reset
                    if (_dealer.GetNextScore(_hand) > 21)
                    {
                        MessageBox.Show("Score went over 21, Dealer Wins!");
                        resetCardDisplay();
                        HitButtonClick = 0;
                    }
                    break;

                // The second click will display the fourth card and add it to the score
                case 2:
                    playerCard4.Image = (Image)_RM.GetObject(_hand.Cards[3].ImageName);
                    plyerScore.Text = _dealer.GetLastScore(_hand).ToString();
                    hitBtn.Enabled = false;

                    // If the players score goes over 21 the game stops and is reset
                    if (_dealer.GetLastScore(_hand) > 21)
                    {
                        MessageBox.Show("Score went over 21, Dealer Wins!");
                        resetCardDisplay();
                        HitButtonClick = 0;
                    }
                    break;
                default:
                    // other clicks
                    break;
            }
        }

        // Scores the players hand and shows the dealers hand
        int StandButtonClick = 0;
        private void standBtn_Click(object sender, EventArgs e)
        {
            ++StandButtonClick;

            // Switch case is created to have the stand button do something different
            // after it is clicked
            switch (StandButtonClick)
            {
                case 1:
                    dealersCard2.Image = (Image)_RM.GetObject(_hand.Cards[5].ImageName);
                    DlrScore.Text = _dealer.GetDealerScore(_hand).ToString();
                    hitBtn.Enabled = false;

                    // If the dealers score is less than 17 draw another card
                    if (_dealer.GetDealerScore(_hand) < 17)
                    {
                        dealersCard3.Image = (Image)_RM.GetObject(_hand.Cards[6].ImageName);
                        if (_dealer.GetDealerNextScore(_hand) > 21)
                        {
                                int earnings = (int)betAmount.Value * 2;
                                _pBank += earnings;

                                //StandButtonClick = 0;
                                //resetCardDisplay();
                                
                                MessageBox.Show("Dealer went over 21, you win $" + earnings + "!");

                                standBtn.Text = "End Game";

                                DlrScore.Text = _dealer.GetDealerNextScore(_hand).ToString();

                                break;
                        
                        }
                        // If the dealers score is less than 17 draw the last card
                        else if (_dealer.GetDealerNextScore(_hand) < 17)
                        {
                            dealersCard4.Image = (Image)_RM.GetObject(_hand.Cards[7].ImageName);
                            DlrScore.Text = _dealer.GetDealerLastScore(_hand).ToString();
                            if (_dealer.GetDealerLastScore(_hand) > 21)
                            {
                                int earnings = (int)betAmount.Value * 2;
                                _pBank += earnings;

                                //StandButtonClick = 0;
                                //resetCardDisplay();
                                
                                MessageBox.Show("Dealer went over 21, you win $" + earnings + "!");

                                standBtn.Text = "End Game";

                                DlrScore.Text = _dealer.GetDealerLastScore(_hand).ToString();

                                break;
                            }
                            
                        }
                        
                        else
                        {
                            DlrScore.Text = _dealer.GetDealerNextScore(_hand).ToString();
                        }
                    }
                    
                    // Decide who the winner is
                    // If two cards are only used for the dealer and the player
                    if(plyerScore.Text == _dealer.GetScore(_hand).ToString() &&
                       DlrScore.Text == _dealer.GetDealerScore(_hand).ToString())
                    {
                        if(_dealer.GetScore(_hand) > _dealer.GetDealerScore(_hand))
                        {
                            int earnings = (int)betAmount.Value * 2;
                            _pBank += earnings;
                            MessageBox.Show("You win $" + earnings + "!");
                        }
                        else if (_dealer.GetScore(_hand) < _dealer.GetDealerScore(_hand))
                        {
                            MessageBox.Show("Dealer Wins!");
                        }
                        else
                        {
                            MessageBox.Show("You tied!");
                            _pBank += (int)betAmount.Value;
                        }
                    }
                    // If the player has 3 cards and the dealer has 2
                    else if (plyerScore.Text == _dealer.GetNextScore(_hand).ToString() &&
                             DlrScore.Text == _dealer.GetDealerScore(_hand).ToString())
                    {
                        if (_dealer.GetNextScore(_hand) > _dealer.GetDealerScore(_hand))
                        {
                            int earnings = (int)betAmount.Value * 2;
                            _pBank += earnings;
                            MessageBox.Show("You win $" + earnings + "!");
                        }
                        else if (_dealer.GetNextScore(_hand) < _dealer.GetDealerScore(_hand))
                        {
                            MessageBox.Show("Dealer Wins!");
                        }
                        else
                        {
                            MessageBox.Show("You tied!");
                            _pBank += (int)betAmount.Value;
                        }
                    }
                    // If the player has 2 cards and the dealer has 3
                    else if (plyerScore.Text == _dealer.GetScore(_hand).ToString() &&
                             DlrScore.Text == _dealer.GetDealerNextScore(_hand).ToString())
                    {
                        if (_dealer.GetScore(_hand) > _dealer.GetDealerNextScore(_hand))
                        {
                            int earnings = (int)betAmount.Value * 2;
                            _pBank += earnings;
                            MessageBox.Show("You win $" + earnings + "!");
                        }
                        else if (_dealer.GetScore(_hand) < _dealer.GetDealerNextScore(_hand))
                        {
                            MessageBox.Show("Dealer Wins!");
                        }
                        else
                        {
                            MessageBox.Show("You tied!");
                            _pBank += (int)betAmount.Value;
                        }
                    }
                    // If the player has 3 cards and the dealer also has 3 cards
                    else if (plyerScore.Text == _dealer.GetNextScore(_hand).ToString() &&
                             DlrScore.Text == _dealer.GetDealerNextScore(_hand).ToString())
                    {
                        if (_dealer.GetNextScore(_hand) > _dealer.GetDealerNextScore(_hand))
                        {
                            int earnings = (int)betAmount.Value * 2;
                            _pBank += earnings;
                            MessageBox.Show("You win $" + earnings + "!");
                        }
                        else if (_dealer.GetNextScore(_hand) < _dealer.GetDealerNextScore(_hand))
                        {
                            MessageBox.Show("Dealer Wins!");
                        }
                        else
                        {
                            MessageBox.Show("You tied!");
                            _pBank += (int)betAmount.Value;
                        }
                    }
                    // If the player has 4 cards and the dealer has 3 cards
                    else if (plyerScore.Text == _dealer.GetLastScore(_hand).ToString() &&
                             DlrScore.Text == _dealer.GetDealerNextScore(_hand).ToString())
                    {
                        if (_dealer.GetLastScore(_hand) > _dealer.GetDealerNextScore(_hand))
                        {
                            int earnings = (int)betAmount.Value * 2;
                            _pBank += earnings;
                            MessageBox.Show("You win $" + earnings + "!");
                        }
                        else if (_dealer.GetLastScore(_hand) < _dealer.GetDealerNextScore(_hand))
                        {
                            MessageBox.Show("Dealer Wins!");
                        }
                        else
                        {
                            MessageBox.Show("You tied!");
                            _pBank += (int)betAmount.Value;
                        }
                    }
                    // If the player has 3 cards and the dealer has 4 cards
                    else if (plyerScore.Text == _dealer.GetNextScore(_hand).ToString() &&
                             DlrScore.Text == _dealer.GetDealerLastScore(_hand).ToString())
                    {
                        if (_dealer.GetNextScore(_hand) > _dealer.GetDealerLastScore(_hand))
                        {
                            int earnings = (int)betAmount.Value * 2;
                            _pBank += earnings;
                            MessageBox.Show("You win $" + earnings + "!");
                        }
                        else if (_dealer.GetNextScore(_hand) < _dealer.GetDealerLastScore(_hand))
                        {
                            MessageBox.Show("Dealer Wins!");
                        }
                        else
                        {
                            MessageBox.Show("You tied!");
                            _pBank += (int)betAmount.Value;
                        }
                    }
                    // If the player has 2 cards and the dealer has 4 cards
                    else if (plyerScore.Text == _dealer.GetScore(_hand).ToString() &&
                             DlrScore.Text == _dealer.GetDealerLastScore(_hand).ToString())
                    {
                        if (_dealer.GetScore(_hand) > _dealer.GetDealerLastScore(_hand))
                        {
                            int earnings = (int)betAmount.Value * 2;
                            _pBank += earnings;
                            MessageBox.Show("You win $" + earnings + "!");
                        }
                        else if (_dealer.GetScore(_hand) < _dealer.GetDealerLastScore(_hand))
                        {
                            MessageBox.Show("Dealer Wins!");
                        }
                        else
                        {
                            MessageBox.Show("You tied!");
                            _pBank += (int)betAmount.Value;
                        }
                    }
                    // If the player has 4 cards and the dealer has 2 cards
                    else if (plyerScore.Text == _dealer.GetLastScore(_hand).ToString() &&
                             DlrScore.Text == _dealer.GetDealerScore(_hand).ToString())
                    {
                        if (_dealer.GetLastScore(_hand) > _dealer.GetDealerScore(_hand))
                        {
                            int earnings = (int)betAmount.Value * 2;
                            _pBank += earnings;
                            MessageBox.Show("You win $" + earnings + "!");
                        }
                        else if (_dealer.GetLastScore(_hand) < _dealer.GetDealerScore(_hand))
                        {
                            MessageBox.Show("Dealer Wins!");
                        }
                        else
                        {
                            MessageBox.Show("You tied!");
                            _pBank += (int)betAmount.Value;
                        }
                    }
                    // If the player has 4 cards and the dealer also has 4 cards
                    else if (plyerScore.Text == _dealer.GetLastScore(_hand).ToString() &&
                             DlrScore.Text == _dealer.GetDealerLastScore(_hand).ToString())
                    {
                        if (_dealer.GetLastScore(_hand) > _dealer.GetDealerLastScore(_hand))
                        {
                            int earnings = (int)betAmount.Value * 2;
                            _pBank += earnings;
                            MessageBox.Show("You win $" + earnings + "!");
                        }
                        else if (_dealer.GetLastScore(_hand) < _dealer.GetDealerLastScore(_hand))
                        {
                            MessageBox.Show("Dealer Wins!");
                        }
                        else
                        {
                            MessageBox.Show("You tied!");
                            _pBank += (int)betAmount.Value;
                        }
                    }
                    
                    standBtn.Text = "End Game";
                    break;
                case 2:
                    resetCardDisplay();
                    StandButtonClick = 0;
                    standBtn.Text = "Stand";
                    break;
                default:
                    // other clicks
                    break;
            }
            HitButtonClick = 0;
        }
    }
}
