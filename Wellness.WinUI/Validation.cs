using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wellness.WinUI
{
    class Validation
    {


        public bool Required(object sender, CancelEventArgs e, ErrorProvider ep)
        {
            var text = "Obavezno polje !";

            if (sender is TextBox)
            {
                var ele = ((TextBox)sender);
                if (string.IsNullOrEmpty(ele.Text))
                {
                    ele.Focus();
                    e.Cancel = true;
                    ep.SetError(ele, text);
                    return false;
                }
                else
                {
                    e.Cancel = false;
                    ep.SetError(ele, null);
                    return true;
                }
            }
            return false;//implement
        }
        public bool MinMaxValue(object sender, CancelEventArgs e, ErrorProvider ep, int minValue, int maxValue)
        {
            var text = "Vrijednost mora biti izmedju " + minValue + " i " + maxValue;

            if (sender is TextBox)
            {
                var ele = ((TextBox)sender);
                if (!string.IsNullOrWhiteSpace(ele.Text))
                {
                    if (Convert.ToInt32(ele.Text) < minValue || Convert.ToInt32(ele.Text) > maxValue)
                    {
                        ele.Focus();
                        e.Cancel = true;
                        ep.SetError(ele, text);
                        return false;
                    }
                    else
                    {
                        e.Cancel = false;
                        ep.SetError(ele, null);
                        return true;
                    }
                }

            }


            return false;//implement
        }

        public bool IsNumberOnly(object sender, CancelEventArgs e, ErrorProvider ep)
        {
            Regex reg = new Regex("[^0-9]");
            var text = "Dozvoljeni samo brojevi";

            if (sender is TextBox)
            {
                var ele = ((TextBox)sender);
                var match = reg.IsMatch(ele.Text);
                if (match == true)
                {
                    e.Cancel = true;
                    ele.Focus();
                    ep.SetError(ele, text);
                    return false;
                }
                else
                {

                    e.Cancel = false;
                    ep.SetError(ele, null);
                    return true;
                }
            }

            return false;//implement
        }

        public bool IsLetterOnly(object sender, CancelEventArgs e, ErrorProvider ep)
        {
            Regex reg = new Regex("[^A-Za-z]");
            var text = "Dozvoljeni samo slova";

            if (sender is TextBox)
            {
                var ele = ((TextBox)sender);
                var match = reg.IsMatch(ele.Text);
                if (match == true)
                {
                    e.Cancel = true;
                    ele.Focus();
                    ep.SetError(ele, text);
                    return false;
                }
                else
                {

                    e.Cancel = false;
                    ep.SetError(ele, null);
                    return true;
                }
            }

            return false;//implement
        }


        public bool MinMaxLength(object sender, CancelEventArgs e, ErrorProvider ep, int minLength, int maxLength)
        {
            var text = "Vrijednost mora biti izmedju " + minLength + " i " + maxLength;
            if (minLength == maxLength) { text = "Obavezno " + minLength + " karaktera"; }
            if (sender is TextBox)
            {
                var ele = ((TextBox)sender);
                if (!string.IsNullOrWhiteSpace(ele.Text))
                {
                    if (ele.Text.Length < minLength || ele.Text.Length > maxLength)
                    {
                        ele.Focus();
                        e.Cancel = true;
                        ep.SetError(ele, text);
                        return false;
                    }
                    else
                    {
                        e.Cancel = false;
                        ep.SetError(ele, null);
                        return true;
                    }
                }
                

            }

            return false;
        }
    }
}
