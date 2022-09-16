using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PasswordControl.Properties;
using System.ComponentModel.Design;


namespace PasswordControl
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class UserControl1 : UserControl
    {
        /// <summary>
        /// Property CapitalCharacters indicates a number of capital letters in a password. Change the default value = 2 by setter.
        /// </summary>
        public uint CapitalCharacters { get; set; } = 2;

        /// <summary>
        /// Property Length indicates a length of a password. Change the default value = 10 by setter.
        /// </summary>
        public uint Length { get; set; } = 10;

        /// <summary>
        /// Property  SpecialCharacters indicates a number of special characters <code>[~!@#$%^&amp; *()_+{}:"&lt;&gt;?]</code> in a password. Change the default value = 2 by setter.
        /// </summary>
        public uint SpecialCharacters { get; set; } = 2;

        /// <summary>
        /// Property Digits indicates a number of digits in a password. Change the default value = 2 by setter.
        /// </summary>
        public uint Digits { get; set; } = 2;

        public Image UncheckedIcon { get; set; } = Resources.uncheckedIcon;
        public Image CheckedIcon { get; set; } = Resources.checkedIcon;
        public Image PadlockIcon { get; set; } = Resources.padlockIcon;


        private bool _lengthBool;
        private bool _specialCharactersBool;
        private bool _digitBool;
        private bool _capitalBool;
        private bool _authenticated;

        public string Password { get; private set; }

        public Button ConfirmButton;


        public UserControl1()
        {
            InitializeComponent();
            ConfirmButton = confirm_button;

            capital_char_label.Text = CapitalCharacters == 1
                ? "at least 1 capital letter"
                : "at least" + CapitalCharacters + " capital letters";

            digit_label.Text = Digits == 1
                ? "at least 1 digit"
                : "at least" + Digits + " digits";

            characters_label.Text = Length == 1
                ? "at least 1 letter"
                : "at least" + Length + " letters";

            special_char_label.Text = Length == 1
                ? "at least 1 special character"
                : "at least" + SpecialCharacters + " special characters";

            capital_char_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            capital_char_pictureBox.Image = UncheckedIcon;

            characters_pictureBox.Image = UncheckedIcon;
            characters_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            digit_pictureBox.Image = UncheckedIcon;
            digit_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            special_char_pictureBox.Image = UncheckedIcon;
            special_char_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            Password = password_textBox.Text;

            //check the number of digits in password
            if (Password.ToCharArray().Count(char.IsDigit) >= Digits)
            {
                digit_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                digit_pictureBox.Image = CheckedIcon;
                _digitBool = true;
            }
            else
            {
                digit_pictureBox.Image = UncheckedIcon;
                _digitBool = false;
            }

            //check the number of the upper letter in password 
            if (Password.ToCharArray().Count(char.IsUpper) >= CapitalCharacters)
            {
                capital_char_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                capital_char_pictureBox.Image = CheckedIcon;
                _capitalBool = true;
            }
            else
            {
                capital_char_pictureBox.Image = UncheckedIcon;
                capital_char_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                _capitalBool = false;
            }

            //check the number of the special characters in password 
            if (Regex.Matches(Password, "[~!@#$%^& *()_+{}:\"<>?]").Count >= CapitalCharacters)
            {
                special_char_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                special_char_pictureBox.Image = CheckedIcon;
                _specialCharactersBool = true;
            }
            else
            {
                special_char_pictureBox.Image = UncheckedIcon;
                special_char_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                _specialCharactersBool = false;
            }

            //check the length of the password 
            if (Password.Length >= Length)
            {
                characters_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                characters_pictureBox.Image = CheckedIcon;
                _lengthBool = true;
            }
            else
            {
                characters_pictureBox.Image = UncheckedIcon;
                _lengthBool = false;
            }

            _authenticated = _capitalBool && _digitBool && _lengthBool && _specialCharactersBool;
            if (_authenticated) confirm_button.Enabled = true;
            else
            {
                _authenticated = false;
                confirm_button.Enabled = false;
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            Password = password_textBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}