using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalindromeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                // Створення екземпляра PalindromeChecker
                PalindromeChecker checker = new PalindromeChecker();
                // Отримання введеного користувачем тексту
                string input = txtInput.Text;
                // Виклик методу IsPalindrome для перевірки введеного тексту
                bool isPalindrome = checker.IsPalindrome(input);
                // Відображення результату перевірки на паліндромність
                if (isPalindrome)
                {
                    lblResult.Text = "The word is a palindrome.";
                }
                else
                {
                    lblResult.Text = "The word is not a palindrome.";
                }
            }
            catch (Exception ex)
            {
                // Відображення повідомлення про помилку, якщо виникла виняткова ситуація
                MessageBox.Show(ex.Message, "Erratum.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
