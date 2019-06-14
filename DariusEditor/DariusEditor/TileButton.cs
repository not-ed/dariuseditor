using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariusEditor
{
    public class TileButton : Button
    {
        public Tile typeWhenSelected;



        public TileButton(Tile desired_type_when_selected)
        {
            this.typeWhenSelected = desired_type_when_selected;

            this.Image = typeWhenSelected.icon;
        }



        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            DariusEditor.MainEditorWindow.highlightedTitleToBeDisplayed = typeWhenSelected.tileName;
            DariusEditor.MainEditorWindow.highlightedBodyToBeDisplayed = typeWhenSelected.tileDescription;
        }



        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            DariusEditor.MainEditorWindow.highlightedTitleToBeDisplayed = "";
            DariusEditor.MainEditorWindow.highlightedBodyToBeDisplayed = "";
        }



        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            DariusEditor.MainEditorWindow.currentlySelectedTile = typeWhenSelected;
        }
    }
}
