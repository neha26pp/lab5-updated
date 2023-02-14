using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab5_updated
{
    //computes the power of the current value to the user entered input
    class Power : Module
    {
        public Power()
        {
            compute();
        }

        public override void compute()
        {
            
            double currentVal = getCurrentvalue();
            string str = currentVal.ToString();
            //compute the result and update current value
            if (InputBox(currentVal, "Enter a value:", ref str) == DialogResult.OK)
            {

                double input = double.Parse(str);
                double power = Math.Pow(currentVal, input);
                //Debug.WriteLine("Power = " + power);
                setCurrentValue(power);
                
            }
        }


        //Dialog box to accept user input
        public static DialogResult InputBox(double currentVal, string promptText, ref string value)
        {
            Form popupForm = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonSubmit = new Button();
            Button buttonCancel = new Button();

            popupForm.Text = "Current Value: " + currentVal;
            label.Text = promptText;
            textBox.Text = currentVal.ToString();

            buttonSubmit.Text = "Submit";
            buttonCancel.Text = "Cancel";
            buttonSubmit.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonSubmit.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);

            label.AutoSize = true;
            popupForm.ClientSize = new Size(796, 307);
            popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            popupForm.MinimizeBox = false;
            popupForm.MaximizeBox = false;

            popupForm.Controls.AddRange(new Control[] { label, textBox, buttonSubmit, buttonCancel });
            popupForm.AcceptButton = buttonSubmit;
            popupForm.CancelButton = buttonCancel;

            DialogResult dialogResult = popupForm.ShowDialog();

            value = textBox.Text;

            return dialogResult;

        }

    }
}
