using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class Shelter
    {
        private Size rowSize;
        private const int InitRowOffsetTop = 20;
        private const int rowOffsetY = 30;
        public bool IsSubmitted;
        public delegate void OnShelterSubmit(Object sender, EventArgs e);
        public OnShelterSubmit OnSubmit;

        public Dictionary<string, string> Content; 
 
        private Panel self;

        public Panel Self
        {
            get { return self; }
            set { self = value; }
        }

        public Shelter(Point location, Size size, BorderStyle borderStyle)
        {   
            rowSize = new Size(100, 30);
            CreateSingleBlock(location, size, borderStyle);

            IsSubmitted = false;
            Content = new Dictionary<string, string>();
        }

        private void CreateSingleBlock(Point location, Size size, BorderStyle borderStyle)
        {
            self = new Panel { Location = location, BorderStyle = borderStyle, Size = size, AutoScroll = true};
        }

        private void CreateSingleRow(IList<string> property, Point location)
        {
            var label = new Label { Text = property[0], Location = location, Size = rowSize };

            var textbox = new TextBox
            {
                Text = property[1],
                Location = new Point(label.Size.Width + label.Location.X, location.Y),
                Size = rowSize
            };
            if (property[0] == "ID")
            {
                label.Visible = false;
                textbox.Visible = false;
            }
            self.Controls.Add(label);
            self.Controls.Add(textbox);
        }

        private void AddCreateButton(Point location)
        {
            var button = new Button();
            button.Size = new Size(100, 20);
            button.Location = new Point(location.X - button.Size.Width/2, location.Y);
            button.Text = "Create";
            button.Name = "CreateFishBtn";

            OnSubmit = OnSubmitBtnClk;
            button.Click += new System.EventHandler(OnSubmit);
            self.Controls.Add(button);
        }

        private void OnSubmitBtnClk(Object sender, EventArgs e)
        {
            Content.Clear();
            
            var key = self.Controls.OfType<Label>().Select(control => control.Text).ToArray();
            var value = self.Controls.OfType<TextBox>().Select(control => control.Text).ToArray();

            for (var i = 0; i < key.Length; i++)
            {
                Content.Add(key[i], value[i]);
            }

            IsSubmitted = true;
        }

        public void AddProperties(Dictionary<string, string> dictionary, bool isSubmitBtnRequired)
        {
            var offsetY = InitRowOffsetTop;
            foreach (var property in dictionary)
            {
                var propertyArr = new string[2];
                propertyArr[0] = property.Key;
                propertyArr[1] = property.Value;
                CreateSingleRow(propertyArr, new Point(10, offsetY));
                offsetY += rowOffsetY;
            }

            if (isSubmitBtnRequired)
                AddCreateButton(new Point(self.Width / 2, offsetY));
        }

        public void fillWith(Fish fish)
        {
            
        }
    }
}
