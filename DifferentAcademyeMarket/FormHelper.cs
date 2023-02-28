using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentAcademyeMarket {
    public class FormHelper {
        public static void SelectNextControlOnEnter(Form sourceForm, object sender, KeyEventArgs e) {
            var currentControl = (Control)sender;
            if (currentControl is TextBox) {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down) {
                    sourceForm.SelectNextControl(currentControl, true, true, true, true);
                } else if (e.KeyCode == Keys.Up) {
                    sourceForm.SelectNextControl(currentControl, false, true, true, true);
                } else {
                    return;
                }
            } else {
                if (e.KeyCode == Keys.Enter) {
                    sourceForm.SelectNextControl(currentControl, true, true, true, true);
                } else if (e.KeyCode == Keys.Up && e.Control) {
                    sourceForm.SelectNextControl(currentControl, false, true, true, true);
                } else {
                    return;
                }
            }
        }
    }
}
