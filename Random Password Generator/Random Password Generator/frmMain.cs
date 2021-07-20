
#region Region - Using Statements

using System;
using System.Windows.Forms;

#endregion Region - Using Statements

namespace Random_Password_Generator
{
    public partial class frmMain : Form
    {

        #region Region - Variables & Constants

        private int characterCount = 6;
        private bool useNumbers = true;
        private bool useLowercase = true;
        private bool useUppercase = false;
        private bool useSymbols = false;
        private string password = "";
        private Random random = new Random();
        private int passwordCharacterCount = 0;
        private int complexityCoefficient = 1;

        #endregion Region - Variables & Constants

        #region Region - Functions

        #region Region - Constructor

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion Region - Constructor

        #region Region - Events Functions

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblPassword.Text = "";
            cmoboCharCount.Text = "6";
            for (int i = 6; i < 33; i++)
            {
                cmoboCharCount.Items.Add(i);
            }
            complexityCoefficient = trackComplexity.Value;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Clear current passwords
            lblPassword.Text = "";
            password = "";

            int xCounter = 1;
            bool firstPass = true;
            int rnd02 = random.Next(1, 100);

            do
            {
                // Add a lower case character
                passwordCharacterCount = Convert.ToInt32(cmoboCharCount.Text);
                if (firstPass == true)
                {
                    if (useLowercase == true)
                    {
                        password = password + (char)random.Next(97, 122);
                        xCounter += 1;
                        firstPass = false;
                    }
                }

                // Add a number
                if (firstPass == true)
                {
                    if (useNumbers == true)
                    {
                        password = password + (char)random.Next(48, 57);
                        xCounter += 1;
                        firstPass = false;
                    }
                }

                // Add an upper case character
                if (firstPass == true)
                {
                    if (useUppercase == true)
                    {
                        password = password + (char)random.Next(65, 90);
                        xCounter += 1;
                        firstPass = false;
                    }
                }

                // Add a symbol
                if (firstPass == true)
                {
                    if (useSymbols == true)
                    {
                        int rnd05 = random.Next(1, 4);

                        switch (rnd05)
                        {
                            case 1:
                                // Symbols ! - /
                                password = password + (char)random.Next(33, 47);
                                xCounter += 1;
                                firstPass = false;
                                break;
                            case 2:
                                // Symbols : - @
                                password = password + (char)random.Next(58, 64);
                                xCounter += 1;
                                firstPass = false;
                                break;
                            case 3:
                                // Symbols [ - '
                                password = password + (char)random.Next(91, 96);
                                xCounter += 1;
                                firstPass = false;
                                break;
                            case 4:
                                // Symbols ( - ~
                                password = password + (char)random.Next(123, 126);
                                xCounter += 1;
                                firstPass = false;
                                break;
                            default:
                                // Symbols ! - /
                                password = password + (char)random.Next(33, 47);
                                xCounter += 1;
                                firstPass = false;
                                break;
                        }
                    }
                }

                rnd02 = random.Next(1, 100);

                switch (complexityCoefficient)
                {
                    // Least complex, password weighted 25% numbers, 60% lower, 15% symbols and upper
                    case 1:

                        if (rnd02 > 0 && rnd02 <= 24)
                        {
                            if (useNumbers == true)
                            {
                                password = password + (char)random.Next(48, 57);
                                xCounter += 1;
                            }
                        }
                        else if (rnd02 > 24 && rnd02 <= 84)
                        {
                            if (useLowercase == true)
                            {
                                password = password + (char)random.Next(97, 122);
                                xCounter += 1;
                            }
                        }
                        else if (rnd02 > 84 && rnd02 <= 100)
                        {
                            if (useUppercase == true)
                            {
                                int rnd03 = random.Next(1, 10);
                                if (rnd03 > 8)
                                {
                                    password = password + (char)random.Next(65, 90);
                                    xCounter += 1;
                                }
                            }
                            if (useSymbols == true)
                            {
                                int rnd04 = random.Next(1, 10);
                                if (rnd04 > 8)
                                {
                                    int rnd05 = random.Next(1, 4);
                                    if (rnd05 == 1)
                                    {
                                        password = password + (char)random.Next(33, 47);
                                        xCounter += 1;
                                    }
                                    if (rnd05 == 2)
                                    {
                                        password = password + (char)random.Next(58, 64);
                                        xCounter += 1;
                                    }
                                    if (rnd05 == 3)
                                    {
                                        password = password + (char)random.Next(91, 96);
                                        xCounter += 1;
                                    }
                                    if (rnd05 == 4)
                                    {
                                        password = password + (char)random.Next(123, 126);
                                        xCounter += 1;
                                    }
                                }
                            }
                        }
                        break;

                    case 2: // Slightly complex, password weighted 55% numbers, 25% lower, 20% symbols and upper

                        int rnd06 = random.Next(1, 100);
                        if (rnd06 > 0 && rnd06 < 25)
                        {
                            if (useNumbers == true)
                            {
                                password = password + (char)random.Next(48, 57);
                                xCounter += 1;
                            }
                        }
                        if (rnd06 > 24 && rnd06 < 80)
                        {
                            if (useLowercase == true)
                            {
                                password = password + (char)random.Next(97, 122);
                                xCounter += 1;
                            }
                        }
                        if (rnd06 > 79 && rnd06 < 101)
                        {
                            if (useUppercase == true)
                            {
                                int rnd07 = random.Next(1, 10);
                                if (rnd06 > 8)
                                {
                                    password = password + (char)random.Next(65, 90);
                                    xCounter += 1;
                                }
                            }
                            if (useSymbols == true)
                            {
                                int rnd08 = random.Next(1, 10);

                                if (rnd08 > 8)
                                {
                                    int rnd09 = random.Next(1, 4);

                                    switch (rnd09)
                                    {
                                        case 1:
                                            // Symbols ! - /
                                            password = password + (char)random.Next(33, 47);
                                            xCounter += 1;
                                            break;
                                        case 2:
                                            // Symbols : - @
                                            password = password + (char)random.Next(58, 64);
                                            xCounter += 1;
                                            break;
                                        case 3:
                                            // Symbols [ - '
                                            password = password + (char)random.Next(91, 96);
                                            xCounter += 1;
                                            break;
                                        case 4:
                                            // Symbols ( - ~
                                            password = password + (char)random.Next(123, 126);
                                            xCounter += 1;
                                            break;
                                        default:
                                            // Symbols ! - /
                                            password = password + (char)random.Next(33, 47);
                                            xCounter += 1;
                                            break;
                                    }
                                }
                            }
                        }
                        break;

                    case 3:  // Complex, password weighted 50% lower, 25% numbers, 25% symbols and upper

                        int rnd10 = random.Next(1, 100);
                        if (rnd10 > 0 && rnd10 < 25)
                        {
                            if (useNumbers == true)
                            {
                                password = password + (char)random.Next(48, 57);
                                xCounter += 1;
                            }
                        }
                        if (rnd10 > 24 && rnd10 < 75)
                        {
                            if (useLowercase == true)
                            {
                                password = password + (char)random.Next(97, 122);
                                xCounter += 1;
                            }
                        }
                        if (rnd10 > 74 && rnd10 < 101)
                        {
                            if (useUppercase == true)
                            {
                                int rnd03 = random.Next(1, 10);
                                if (rnd03 > 5)
                                {
                                    password = password + (char)random.Next(65, 90);
                                    xCounter += 1;
                                }
                            }
                            if (useSymbols == true)
                            {
                                int rnd04 = random.Next(1, 10);
                                if (rnd04 > 5)
                                {
                                    int rnd05 = random.Next(1, 4);

                                    switch (rnd05)
                                    {
                                        case 1:
                                            // Symbols ! - /
                                            password = password + (char)random.Next(33, 47);
                                            xCounter += 1;
                                            break;
                                        case 2:
                                            // Symbols : - @
                                            password = password + (char)random.Next(58, 64);
                                            xCounter += 1;
                                            break;
                                        case 3:
                                            // Symbols [ - '
                                            password = password + (char)random.Next(91, 96);
                                            xCounter += 1;
                                            break;
                                        case 4:
                                            // Symbols ( - ~
                                            password = password + (char)random.Next(123, 126);
                                            xCounter += 1;
                                            break;
                                        default:
                                            // Symbols ! - /
                                            password = password + (char)random.Next(33, 47);
                                            xCounter += 1;
                                            break;
                                    }
                                }
                            }
                        }
                        break;

                    case 4:// Very Complex, password weighted 34% lower, 33% numbers, 33% symbols and upper

                        int rnd11 = random.Next(1, 100);
                        if (rnd11 > 0 && rnd11 < 34)
                        {
                            if (useNumbers == true)
                            {
                                password = password + (char)random.Next(48, 57);
                                xCounter += 1;
                            }
                        }
                        if (rnd11 > 34 && rnd11 < 67)
                        {
                            if (useLowercase == true)
                            {
                                password = password + (char)random.Next(97, 122);
                                xCounter += 1;
                            }
                        }
                        if (rnd11 > 67 && rnd11 < 101)
                        {
                            if (useUppercase == true)
                            {
                                int rnd03 = random.Next(1, 10);
                                if (rnd03 > 2)
                                {
                                    password = password + (char)random.Next(65, 90);
                                    xCounter += 1;
                                }
                            }
                            if (useSymbols == true)
                            {
                                int rnd04 = random.Next(1, 10);
                                if (rnd04 > 2)
                                {
                                    switch (rnd04)
                                    {
                                        case 1:
                                            // Symbols ! - /
                                            password = password + (char)random.Next(33, 47);
                                            xCounter += 1;
                                            break;
                                        case 2:
                                            // Symbols : - @
                                            password = password + (char)random.Next(58, 64);
                                            xCounter += 1;
                                            break;
                                        case 3:
                                            // Symbols [ - '
                                            password = password + (char)random.Next(91, 96);
                                            xCounter += 1;
                                            break;
                                        case 4:
                                            // Symbols ( - ~
                                            password = password + (char)random.Next(123, 126);
                                            xCounter += 1;
                                            break;
                                        default:
                                            // Symbols ! - /
                                            password = password + (char)random.Next(33, 47);
                                            xCounter += 1;
                                            break;
                                    }
                                }
                            }
                        }
                        break;
                }
                if (xCounter == 1)
                {
                    xCounter = 100;
                }
            }

            while (xCounter < passwordCharacterCount + 1);

            lblPassword.Text = password;
        }

        private void chkNumbers_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkNumbers.CheckState)
            {
                case CheckState.Checked:
                    useNumbers = true;
                    break;
                case CheckState.Unchecked:
                    useNumbers = false;
                    break;

            }
        }

        private void chkUpper_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkUpper.CheckState)
            {
                case CheckState.Checked:
                    useUppercase = true;
                    break;
                case CheckState.Unchecked:
                    useUppercase = false;
                    break;
            }
        }

        private void chkLower_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkLower.CheckState)
            {
                case CheckState.Checked:
                    useLowercase = true;
                    break;
                case CheckState.Unchecked:
                    useLowercase = false;
                    break;
            }
        }

        private void chkSymbols_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkSymbols.CheckState)
            {
                case CheckState.Checked:
                    useSymbols = true;
                    break;
                case CheckState.Unchecked:
                    useSymbols = false;
                    break;
            }
        }

        private void cmoboCharCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            characterCount = Convert.ToInt32(cmoboCharCount.Text);
        }

        private void trackComplexity_Scroll(object sender, EventArgs e)
        {
            complexityCoefficient = trackComplexity.Value;
        }

        private void btnFiresWhenPressGenerate(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPassword.Text);
        }

        private void lblNumbers_Click(object sender, EventArgs e)
        {
            switch (chkNumbers.CheckState)
            {
                case CheckState.Checked:
                    chkNumbers.CheckState = CheckState.Unchecked;
                    useNumbers = false;
                    break;
                case CheckState.Unchecked:
                    chkNumbers.CheckState = CheckState.Checked;
                    useNumbers = true;
                    break;

            }
        }

        private void lblLower_Click(object sender, EventArgs e)
        {
            switch (chkLower.CheckState)
            {
                case CheckState.Checked:
                    chkLower.CheckState = CheckState.Unchecked;
                    useLowercase = false;
                    break;
                case CheckState.Unchecked:
                    chkLower.CheckState = CheckState.Checked;
                    useLowercase = true;
                    break;

            }
        }

        private void lblUpper_Click(object sender, EventArgs e)
        {
            switch (chkUpper.CheckState)
            {
                case CheckState.Checked:
                    chkUpper.CheckState = CheckState.Unchecked;
                    useUppercase = false;
                    break;
                case CheckState.Unchecked:
                    chkUpper.CheckState = CheckState.Checked;
                    useUppercase = true;
                    break;

            }
        }

        private void lblSymbols_Click(object sender, EventArgs e)
        {
            switch (chkSymbols.CheckState)
            {
                case CheckState.Checked:
                    chkSymbols.CheckState = CheckState.Unchecked;
                    useSymbols = false;
                    break;
                case CheckState.Unchecked:
                    chkSymbols.CheckState = CheckState.Checked;
                    useSymbols = true;
                    break;

            }
        }

        #endregion Region - Events Functions

        #endregion Region - Functions

    }
}
