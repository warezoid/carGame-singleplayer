using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class GameMain : Form
    {
        /***** VARIABLES *****/
        private int scoreValue = 0;
        private int deathsValue = 0;
        private int highScoreValue = 0;

        private int windowWidth = 0;
        private int windowHeight = 0;

        private int maxRandom;
        private Random rnd = new Random();

        private List<PictureBox> listOfPictureBoxes = new List<PictureBox>();

        private bool isPlayerObjectDead = false;
        private bool isGameStarted = false;

        private string gameDifficulty;

        private int objectSize = 0;



        public GameMain(string difficulty)
        {
            InitializeComponent();

            gameDifficulty = difficulty;
        }

        private void gameMain_Load(object sender, EventArgs e)
        {
            SetResolution();

            SetGameDifficulty();

            DefaultValuesFunction();
        }

        /***** DefaultValuesFunction *****/
        private void DefaultValuesFunction()
        {
            this.Width = windowWidth + 20;
            this.Height = windowHeight + 43;

            this.Top = 0;
            this.Left = 0;

            SetUserInfoLabel(true);

            difficultyLabelValue.Text = gameDifficulty;

            playerObject.Width = objectSize;
            playerObject.Height = objectSize;

            playerObject.Top = ClientSize.Height - playerObject.Height;
            playerObject.Left = 0;

            maxRandom = (windowWidth / 100) + 1;

            isPlayerObjectDead = false;

            DeletingAllObjects();

            scoreValue = 0;
            SetLabelValue(0, scoreValueLabel);

            SetLabelValue(deathsValue, deathsValueLabel);
        }

        /***** SetResolution *****/
        private void SetResolution()
        {
            int userScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int userScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            int remainderWidth = userScreenWidth % 100;
            if (remainderWidth >= 20)
            {
                windowWidth = userScreenWidth - remainderWidth;
            }
            else
            {
                windowWidth = (userScreenWidth - 100) - remainderWidth;
            }

            int remainderHeight = userScreenHeight % 100;
            if (remainderHeight >= 43)
            {
                windowHeight = userScreenHeight - remainderHeight;
            }
            else
            {
                windowHeight = (userScreenHeight - 100) - remainderHeight;
            }

            int wholeWidth = userScreenWidth / 100;
            if (wholeWidth >= 10)
            {
                objectSize = 100;
            }
            else
            {
                objectSize = 50;
            }
        }

        /***** SetUserInfoLabel *****/
        private void SetUserInfoLabel(bool isVisible)
        {
            userInfoLabel.Text = "For start and restart press 'Enter'\nFor movement use 'a' and 'd' or 'ArrowLeft' and 'ArrowRight'";

            userInfoLabel.Visible = isVisible;

            userInfoLabel.Left = (ClientSize.Width / 2) - (userInfoLabel.Width / 2);
            userInfoLabel.Top = (ClientSize.Height / 2) - (userInfoLabel.Height / 2);
        }

        /***** SetLabelValue *****/
        private void SetLabelValue(int value, Label label)
        {
            label.Text = value.ToString();
        }

        /***** PlayerMovementFunction *****/
        private void PlayerMovementFunction(string key)
        {
            if (key == "a" || key == "left")
            {
                playerObject.Left -= objectSize;
            }
            else if (key == "d" || key == "right")
            {
                playerObject.Left += objectSize;
            }

            BorderVerificationFunction();
            CollisionDetectionFunction();
        }

        /***** BorderVerificationFunction *****/
        private void BorderVerificationFunction()
        {
            if (playerObject.Left >= this.ClientSize.Width)
            {
                playerObject.Left = 0;
            }
            else if (playerObject.Left < 0)
            {
                playerObject.Left = this.ClientSize.Width - playerObject.Width;
            }
        }

        /***** PreventingOverlappingObjects *****/
        private void PreventingOverlappingObjects(PictureBox oneObject)
        {
            foreach (PictureBox onePicture in listOfPictureBoxes)
            {
                if (onePicture.Left == oneObject.Left)
                {
                    return;
                }
            }
        }

        /***** GeneratingRandomObjects *****/
        private void GeneratingRandomObjects()
        {
            int randomObjectXPosition = (rnd.Next(0, maxRandom)) * 100;
            int randomObjectNumber = rnd.Next(1, 6);

            PictureBox randomObjectPictureBox = new PictureBox();

            randomObjectPictureBox.Left = randomObjectXPosition;

            randomObjectPictureBox.Width = objectSize;
            randomObjectPictureBox.Height = objectSize;

            randomObjectPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            PreventingOverlappingObjects(randomObjectPictureBox);

            switch (randomObjectNumber)
            {
                case 1:
                    randomObjectPictureBox.Image = Properties.Resources.ambulanceObjectIcon;
                    break;

                case 2:
                    randomObjectPictureBox.Image = Properties.Resources.holeObjectIcon;
                    break;

                case 3:
                    randomObjectPictureBox.Image = Properties.Resources.policeObjectIcon;
                    break;

                case 4:
                    randomObjectPictureBox.Image = Properties.Resources.waterObjectIcon;
                    break;

                case 5:
                    randomObjectPictureBox.Image = Properties.Resources.treeObjectIcon;
                    break;
            }

            listOfPictureBoxes.Add(randomObjectPictureBox);
            this.Controls.Add(randomObjectPictureBox);
        }

        /***** FallingObjectsMovement *****/
        private void FallingObjectsMovement()
        {
            foreach (PictureBox onePicture in listOfPictureBoxes)
            {
                onePicture.Top += objectSize;
            }

            scoreValue++;
            SetLabelValue(scoreValue, scoreValueLabel);

            CollisionDetectionFunction();
            DeletingObjectsFunction();
        }

        /***** GeneratingObjectLine *****/
        private void GeneratingObjectLine()
        {
            int objectSpawn = rnd.Next(1, maxRandom);

            for (int i = 0; i < objectSpawn; i++)
            {
                GeneratingRandomObjects();
            }
        }

        /***** DeletingAllObjects *****/
        private void DeletingAllObjects()
        {
            foreach (PictureBox onePicture in listOfPictureBoxes)
            {
                this.Controls.Remove(onePicture);
            }

            listOfPictureBoxes.Clear();
        }

        /***** CollisionDetectionFunction *****/
        private void CollisionDetectionFunction()
        {
            foreach (PictureBox onePicture in listOfPictureBoxes)
            {
                if (onePicture.Left == playerObject.Left && onePicture.Top == playerObject.Top)
                {
                    PlayerLoseFunction();
                    break;
                }
            }
        }

        /***** PlayerLoseFunction *****/
        private void PlayerLoseFunction()
        {
            isPlayerObjectDead = true;

            removingAndSpawningObjects.Enabled = false;
            objectsMovement.Enabled = false;

            deathsValue++;
            SetLabelValue(deathsValue, deathsValueLabel);

            if (scoreValue > highScoreValue)
            {
                highScoreValue = scoreValue;
                SetLabelValue(scoreValue, highScoreValueLabel);
            }

            DefaultValuesFunction();

            isGameStarted = false;
        }

        /***** GameStartFunction *****/
        private void GameStartFunction(string key)
        {
            switch (key)
            {
                case "return":
                    SetUserInfoLabel(false);
                    GeneratingObjectLine();
                    removingAndSpawningObjects.Enabled = true;
                    objectsMovement.Enabled = true;
                    isGameStarted = true;
                    break;
            }
        }

        /***** DeletingObjectsFunction *****/
        private void DeletingObjectsFunction()
        {
            for (int i = 0; i <= (listOfPictureBoxes.Count - 1); i++)
            {
                if (listOfPictureBoxes[i].Top >= this.ClientSize.Height)
                {
                    this.Controls.Remove(listOfPictureBoxes[i]);
                    listOfPictureBoxes.RemoveAt(i);
                }
            }
        }

        /***** SetGameDifficulty *****/
        private void SetGameDifficulty()
        {
            switch (gameDifficulty.ToLower())
            {
                case "easy":
                    removingAndSpawningObjects.Interval = 700;
                    objectsMovement.Interval = 200;
                    break;

                case "normal":
                    removingAndSpawningObjects.Interval = 500;
                    objectsMovement.Interval = 150;
                    break;

                case "hard":
                    removingAndSpawningObjects.Interval = 400;
                    objectsMovement.Interval = 125;
                    break;

                case "impossible":
                    removingAndSpawningObjects.Interval = 250;
                    objectsMovement.Interval = 100;
                    break;
            }
        }

        private void gameMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGameStarted == false)
            {
                GameStartFunction(e.KeyCode.ToString().ToLower());
            }

            PlayerMovementFunction(e.KeyCode.ToString().ToLower());
        }

        private void removingAndSpawningObjects_Tick(object sender, EventArgs e)
        {
            GeneratingObjectLine();
        }

        private void objectsMovement_Tick(object sender, EventArgs e)
        {
            if (isPlayerObjectDead == false)
            {
                FallingObjectsMovement();
            }
        }
    }
}



/*
    -> IDEA BY @MichalKonvic
    -> CREATED BY @warezoid
*/ 