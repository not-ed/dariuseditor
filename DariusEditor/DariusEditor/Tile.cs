using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DariusEditor
{
    public class Tile : PictureBox
    {
        public string seedValue { get; }
        public Image icon { get; }
        public string tileName { get; }
        public string tileDescription { get; }
        public int xPosition = 0;
        public int yPosition = 0;
        public bool isDariusTile;



        public Tile(string seed_value, string name, string description, Image editor_icon, bool represents_darius)
        {
            seedValue = seed_value;
            icon = editor_icon;
            tileName = name;
            tileDescription = description;
            isDariusTile = represents_darius;

            this.Image = icon;
            this.BackColor = Color.Transparent;
        }



        public Tile(Tile tilevar)
        {
            seedValue = tilevar.seedValue;
            icon = tilevar.icon;
            tileName = tilevar.tileName;
            tileDescription = tilevar.tileDescription;
            isDariusTile = tilevar.isDariusTile;

            this.Image = icon;
            this.BackColor = Color.Transparent;
        }



        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DariusEditor.MainEditorWindow.RemoveTile(this);
            }
        }
    }
}
