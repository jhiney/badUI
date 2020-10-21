using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace badUI
{
	public partial class Form1 : Form
	{
		double phoneNumber = 0;
		int calcNumbers;
		List<Button> numButtons;
		List<Button> oppButtons;
		string[] operators;

		string Operation;
		
		//This begins the form
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			phoneNumberBox.Text = phoneNumber.ToString();
			numButtons = new List<Button> { button1, button2, button3, button5, button6, button7, button9, button10, button11,button13, button14};
			oppButtons = new List<Button> { button4, button8, button12, button16};
			operators = new string[] { "+", "-", "/",  "*" };
		}

		private void NumberButton_Click(object sender, EventArgs eventArgs)
		{
			Random random = new Random();
			calcNumbers = int.Parse(((Button)sender).Text);

			switch (calcNumbers)
			{
				case 0:
					if (phoneNumberBox.Text == "0" && phoneNumberBox.Text != null)
					{
						phoneNumberBox.Text = "0";
					}
					else
					{
						phoneNumberBox.Text = phoneNumberBox.Text + "0";
					}
					break;
				case 1:
					if (phoneNumberBox.Text == "0" && phoneNumberBox.Text != null)
					{
						phoneNumberBox.Text = "1";
					}
					else
					{
						phoneNumberBox.Text = phoneNumberBox.Text + "1";
					}
					break;
				case 2:
					if (phoneNumberBox.Text == "0" && phoneNumberBox.Text != null)
					{
						phoneNumberBox.Text = "2";
					}
					else
					{
						phoneNumberBox.Text = phoneNumberBox.Text + "2";
					}
					break;
				case 3:
					if (phoneNumberBox.Text == "0" && phoneNumberBox.Text != null)
					{
						phoneNumberBox.Text = "3";
					}
					else
					{
						phoneNumberBox.Text = phoneNumberBox.Text + "3";
					}
					break;
				case 4:
					if (phoneNumberBox.Text == "0" && phoneNumberBox.Text != null)
					{
						phoneNumberBox.Text = "4";
					}
					else
					{
						phoneNumberBox.Text = phoneNumberBox.Text + "4";
					}
					break;
				case 5:
					if (phoneNumberBox.Text == "0" && phoneNumberBox.Text != null)
					{
						phoneNumberBox.Text = "5";
					}
					else
					{
						phoneNumberBox.Text = phoneNumberBox.Text + "5";
					}
					break;
				case 6:
					if (phoneNumberBox.Text == "0" && phoneNumberBox.Text != null)
					{
						phoneNumberBox.Text = "6";
					}
					else
					{
						phoneNumberBox.Text = phoneNumberBox.Text + "6";
					}
					break;
				case 7:
					if (phoneNumberBox.Text == "0" && phoneNumberBox.Text != null)
					{
						phoneNumberBox.Text = "7";
					}
					else
					{
						phoneNumberBox.Text = phoneNumberBox.Text + "7";
					}
					break;
				case 8:
					if (phoneNumberBox.Text == "0" && phoneNumberBox.Text != null)
					{
						phoneNumberBox.Text = "8";
					}
					else
					{
						phoneNumberBox.Text = phoneNumberBox.Text + "8";
					}
					break;
				case 9:
					if (phoneNumberBox.Text == "0" && phoneNumberBox.Text != null)
					{
						phoneNumberBox.Text = "9";
					}
					else
					{
						phoneNumberBox.Text = phoneNumberBox.Text + "9";
					}
					break;
				default:
					label2.Text = "break";
					break;
			}

			foreach (Button button in numButtons)
			{
				button.Text = random.Next(0, 9).ToString();
			}
		}

	
		private void OperatorButton_Click(object sender, EventArgs eventArgs)
		{
			

			
			switch (((Button)sender).Text)
			{
				case "+":
					phoneNumber = Convert.ToDouble(phoneNumberBox.Text);
					phoneNumberBox.Text = "0";
					Operation = "+";
					label2.Text = phoneNumber.ToString();
					break;
				case "-":
					phoneNumber = Convert.ToDouble(phoneNumberBox.Text);
					phoneNumberBox.Text = "0";
					Operation = "-";
					label2.Text = phoneNumber.ToString();
					break;
				case "*":
					phoneNumber = Convert.ToDouble(phoneNumberBox.Text);
					phoneNumberBox.Text = "0";
					Operation = "*";
					label2.Text = phoneNumber.ToString();
					break;
				case "/":
					phoneNumber = Convert.ToDouble(phoneNumberBox.Text);
					phoneNumberBox.Text = "0";
					Operation = "/";
					label2.Text = phoneNumber.ToString();
					break;
				case "=":
					double SecondNumber;
					double Result;

						SecondNumber = Convert.ToDouble(phoneNumberBox.Text);

						if (Operation == "+")
						{
							Result = (phoneNumber + SecondNumber);
							phoneNumberBox.Text = Convert.ToString(Result);
							phoneNumber = Result;
						}
						if (Operation == "-")
						{
							Result = (phoneNumber - SecondNumber);
							phoneNumberBox.Text = Convert.ToString(Result);
							phoneNumber = Result;
						}
						if (Operation == "*")
						{
							Result = (phoneNumber * SecondNumber);
							phoneNumberBox.Text = Convert.ToString(Result);
							phoneNumber = Result;
						}
						if (Operation == "/")
						{
						if (SecondNumber == 0)
						{
							phoneNumberBox.Text = "Cannot divide by zero";

						}
						else
						{
							Result = (phoneNumber / SecondNumber);
							phoneNumberBox.Text = Convert.ToString(Result);
							phoneNumber = Result;
						}

						}
					break;
			}

			foreach (Button button in oppButtons)
			{
				button.Text = operators[new Random().Next(0, operators.Length)];
			}
		}

	}
}

