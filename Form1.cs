using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess
{
    public partial class Form1 : Form
    {
        public Button prevButton;
        public Color prevButtonColor;
        public Image prevButtonImage;
        public bool moving = false;

        public int[,] map = new int[8, 8]
        {
            { 0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0 },

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void moveChess(int number, string buttonname)
        {

        }

        private void image()
        {

        }

        private void resetMap()
        {
               
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            Button pressed = sender as Button;

            if (!moving && pressed.Image != null)
            {
                prevButton = pressed;
                prevButtonColor = pressed.BackColor;
                prevButtonImage = pressed.Image;
                moving = true;
            }
            else if (moving)
            {
                prevButton.Image = null;
                pressed.Image = prevButtonImage;
                prevButton.BackColor = prevButtonColor;

                prevButton = null;
                prevButtonImage = null;
                moving = false;
            }

            prevButtonColor = pressed.BackColor;
            prevButton = pressed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
