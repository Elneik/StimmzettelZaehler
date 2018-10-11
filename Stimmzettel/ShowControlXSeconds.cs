using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stimmzettel
{
    class ShowControlXSeconds
    {
        public static void ShowLabel(Label label, int seconds)
        {
            var t = new Timer();
            t.Interval = seconds * 1000; //Sekunden in Millisekunden                           
            label.Visible = true;
            t.Tick += (s, _) =>
            {
                label.Visible = false;
                t.Stop();
            };
            t.Start();
        }

        public static void DisableButton(Button button, int seconds, Label label = null)
        {
            var t = new Timer();
            t.Interval = seconds * 1000; //Sekunden in Millisekunden                           
            button.Enabled = false;
            t.Tick += (s, _) =>
            {
                button.Enabled = true;
                if (label != null)
                    ShowLabel(label, 3);
                t.Stop();
            };
            t.Start();

        }

        public static void CloseForm(Form form, int seconds)
        {
            var t = new Timer();
            t.Interval = seconds * 1000; //Sekunden in Millisekunden                                       
            t.Tick += (s, _) =>
            {
                form.Close();
                t.Stop();
            };
            t.Start();
        }
    }
}
