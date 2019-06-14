using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DariusEditor
{

    public partial class MainEditorWindow : Form
    {
        //How big the grid can be and in turn, the maximum size of a created level.
        private const int MAX_GRID_SIZE_WIDTH = 100;
        private const int MAX_GRID_SIZE_HEIGHT = 100;
        private const int GRID_TILE_SIZE = 32;
        private enum LevelTheme
        {
            GRASS, DESERT, ICE
        }
        private LevelTheme selectedLevelTheme = LevelTheme.GRASS;

        private static List<Tile> levelTiles = new List<Tile>();

        public static string highlightedTitleToBeDisplayed, highlightedBodyToBeDisplayed;

        private static bool dariusTileHasBeenPlaced = false;
        private static int placedExitCount = 0;

        private string finalLevelSeed = "";
        
        //Tile types and descriptions.
        #region 
        private static Tile TILE_EMPTY_SPACE = new Tile("00", "Empty Space", "Empty Space that can be occupied. This should not show up in the editor.", Properties.Resources.tile_empty, false);
        private static Tile TILE_STEEL_WALL = new Tile("01", "Steel Wall", "Blocks all objects. Cannot be destroyed through any means.", Properties.Resources.tile_steel_wall, false);
        private static Tile TILE_STONE_WALL = new Tile("02", "Stone Wall", "Blocks all objects until destroyed. Requires 2 hits from a mine explosion or boulder to destroy. Will launch boulders if destroyed by an explosion.", Properties.Resources.tile_stone_wall, false);
        private static Tile TILE_WOOD_CRATE = new Tile("03", "Wooden Crate", "Block all objects until destroyed. Requires a single hit from a mine explosion or boulder to destroy. Will launch several splinters in random directions if destroyed by an explosion.", Properties.Resources.tile_wood_crate, false);
        private static Tile TILE_MINE_CRATE = new Tile("04", "TNT Crate", "Blocks all objects until destroyed. Can only be destroyed using mines. Will drop and launch several mines with a shorter fuse in random directions when destroyed.", Properties.Resources.tile_mine_crate, false);
        private static Tile TILE_LEVEL_END = new Tile("05", "End Flag", "Ends the level when the player reaches it. Multiple flags can exist in a level.", Properties.Resources.tile_level_finish, false);
                
        private static Tile TILE_DARIUS_UP = new Tile("06", "Darius (Facing up)", "The starting position of the player. Only one instance of Darius can exist in a level.", Properties.Resources.tile_darius_u, true);
        private static Tile TILE_DARIUS_UP_RIGHT = new Tile("07", "Darius (Facing up-right)", "The starting position of the player. Only one instance of Darius can exist in a level.", Properties.Resources.tile_darius_ur, true);
        private static Tile TILE_DARIUS_RIGHT = new Tile("08", "Darius (Facing right)", "The starting position of the player. Only one instance of Darius can exist in a level.", Properties.Resources.tile_darius_r, true);
        private static Tile TILE_DARIUS_RIGHT_DOWN = new Tile("09", "Darius (down-right)", "The starting position of the player. Only one instance of Darius can exist in a level.", Properties.Resources.tile_darius_rd, true);
        private static Tile TILE_DARIUS_DOWN = new Tile("10", "Darius (Facing down)", "The starting position of the player. Only one instance of Darius can exist in a level.", Properties.Resources.tile_darius_d, true);
        private static Tile TILE_DARIUS_DOWN_LEFT = new Tile("11", "Darius (Facing down-left)", "The starting position of the player. Only one instance of Darius can exist in a level.", Properties.Resources.tile_darius_dl, true);
        private static Tile TILE_DARIUS_LEFT = new Tile("12", "Darius (Facing left)", "The starting position of the player. Only one instance of Darius can exist in a level.", Properties.Resources.tile_darius_l, true);
        private static Tile TILE_DARIUS_LEFT_UP = new Tile("13", "Darius (Facing up-left)", "The starting position of the player. Only one instance of Darius can exist in a level.", Properties.Resources.tile_darius_lu, true);
        #endregion 

        public static Tile currentlySelectedTile;

        private const string GRASS_THEME_SEED = "G";
        private const string DESERT_THEME_SEED = "D";
        private const string ICE_THEME_SEED = "I";



        public MainEditorWindow()
        {
            InitializeComponent();
            InitializeTileButtons();
        }


        
        private void MainEditorWindow_Load(object sender, EventArgs e)
        {
            levelGridBackground.Size = new Size(MAX_GRID_SIZE_WIDTH * GRID_TILE_SIZE, MAX_GRID_SIZE_HEIGHT * GRID_TILE_SIZE);
        }



        private void InitializeTileButtons()
        {
            InstantiateTileButton(TILE_STEEL_WALL,new Point(844, 285));
            InstantiateTileButton(TILE_STONE_WALL, new Point(902, 285));
            InstantiateTileButton(TILE_WOOD_CRATE, new Point(960, 285));
            InstantiateTileButton(TILE_MINE_CRATE, new Point(1018, 285));
            InstantiateTileButton(TILE_LEVEL_END, new Point(1076, 285));

            InstantiateTileButton(TILE_DARIUS_UP, new Point(873, 363));
            InstantiateTileButton(TILE_DARIUS_UP_RIGHT, new Point(931, 363));
            InstantiateTileButton(TILE_DARIUS_RIGHT, new Point(989, 363));
            InstantiateTileButton(TILE_DARIUS_RIGHT_DOWN, new Point(1046, 363));
            InstantiateTileButton(TILE_DARIUS_DOWN, new Point(873, 420));
            InstantiateTileButton(TILE_DARIUS_DOWN_LEFT, new Point(931, 420));
            InstantiateTileButton(TILE_DARIUS_LEFT, new Point(989, 420));
            InstantiateTileButton(TILE_DARIUS_LEFT_UP, new Point(1046, 420));
        }



        private void levelGridBackground_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentlySelectedTile != null && e.Button == MouseButtons.Left)
            {
                if (currentlySelectedTile.isDariusTile && dariusTileHasBeenPlaced)
                {
                    MessageBox.Show("An Instance of Darius already exists within the level.", "Unable to place Darius", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PlaceTile(currentlySelectedTile, new Point(e.X - e.X % GRID_TILE_SIZE, e.Y - e.Y % GRID_TILE_SIZE));
                }
            }
        }



        private void PlaceTile(Tile desired_tile_type, Point desired_tile_location)
        {
            Tile placed_tile = new Tile(desired_tile_type);

            levelGridBackground.Controls.Add(placed_tile);

            placed_tile.Location = desired_tile_location;
            placed_tile.Size = new Size(GRID_TILE_SIZE, GRID_TILE_SIZE);
            placed_tile.BringToFront();

            placed_tile.xPosition = desired_tile_location.X;
            placed_tile.yPosition = desired_tile_location.Y;

            levelTiles.Add(placed_tile);

            if (placed_tile.isDariusTile) dariusTileHasBeenPlaced = true;
            if (placed_tile.seedValue == TILE_LEVEL_END.seedValue) placedExitCount += 1;
        }



        private void PlaceTileBasedOnSeedChunk(string seed_chunk, Point desired_location)
        {
            //"Only the C# built-in types (excluding System.Object) may be declared as const. User-defined types, including classes, structs, and arrays, cannot be const."
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constants
            if (seed_chunk == TILE_STEEL_WALL.seedValue) PlaceTile(TILE_STEEL_WALL, desired_location);
            else if (seed_chunk == TILE_STONE_WALL.seedValue) PlaceTile(TILE_STONE_WALL, desired_location);
            else if (seed_chunk == TILE_WOOD_CRATE.seedValue) PlaceTile(TILE_WOOD_CRATE, desired_location);
            else if (seed_chunk == TILE_MINE_CRATE.seedValue) PlaceTile(TILE_MINE_CRATE, desired_location);
            else if (seed_chunk == TILE_LEVEL_END.seedValue) PlaceTile(TILE_LEVEL_END, desired_location);

            else if (!dariusTileHasBeenPlaced && seed_chunk == TILE_DARIUS_UP.seedValue) PlaceTile(TILE_DARIUS_UP, desired_location);
            else if (!dariusTileHasBeenPlaced && seed_chunk == TILE_DARIUS_UP_RIGHT.seedValue) PlaceTile(TILE_DARIUS_UP_RIGHT, desired_location);
            else if (!dariusTileHasBeenPlaced && seed_chunk == TILE_DARIUS_RIGHT.seedValue) PlaceTile(TILE_DARIUS_RIGHT, desired_location);
            else if (!dariusTileHasBeenPlaced && seed_chunk == TILE_DARIUS_RIGHT_DOWN.seedValue) PlaceTile(TILE_DARIUS_RIGHT_DOWN, desired_location);
            else if (!dariusTileHasBeenPlaced && seed_chunk == TILE_DARIUS_DOWN.seedValue) PlaceTile(TILE_DARIUS_DOWN, desired_location);
            else if (!dariusTileHasBeenPlaced && seed_chunk == TILE_DARIUS_DOWN_LEFT.seedValue) PlaceTile(TILE_DARIUS_DOWN_LEFT, desired_location);
            else if (!dariusTileHasBeenPlaced && seed_chunk == TILE_DARIUS_LEFT.seedValue) PlaceTile(TILE_DARIUS_LEFT, desired_location);
            else if (!dariusTileHasBeenPlaced && seed_chunk == TILE_DARIUS_LEFT_UP.seedValue) PlaceTile(TILE_DARIUS_LEFT_UP, desired_location);       
    }



        //This should be used to remove tiles on an individual basis. If an entire level must be wiped, use RemoveAllLevelTiles() instead.
        public static void RemoveTile(Tile tile_to_remove)
        {
            levelTiles.Remove(tile_to_remove);
            tile_to_remove.Dispose();

            if (tile_to_remove.isDariusTile) dariusTileHasBeenPlaced = false;
            if (tile_to_remove.seedValue == TILE_LEVEL_END.seedValue) placedExitCount -= 1;
        }



        private void InstantiateTileButton(Tile desired_tile_type, Point desired_button_location)
        {
            DariusEditor.TileButton created_button = new DariusEditor.TileButton(desired_tile_type);
            Controls.Add(created_button);
            created_button.Location = desired_button_location;
            created_button.Size = new Size(48, 48);

            created_button.FlatStyle = FlatStyle.Standard;
            created_button.TabStop = false;
            created_button.BackColor = SystemColors.ButtonFace;
        }



        private void CompileLevelSeed()
        {
            Cursor.Current = Cursors.WaitCursor;
            finalLevelSeed = "";
            string[,] seed_piece = new string[MAX_GRID_SIZE_WIDTH, MAX_GRID_SIZE_HEIGHT];

            for (int i = 0; i < MAX_GRID_SIZE_WIDTH; i++)
            {
                for (int ii = 0; ii < MAX_GRID_SIZE_HEIGHT; ii++)
                {
                    seed_piece[i, ii] = TILE_EMPTY_SPACE.seedValue;
                }
            }

            foreach (var tile in levelTiles)
            {
                int dividedXPosition = (tile.xPosition / GRID_TILE_SIZE);
                int dividedYPosition = (tile.yPosition / GRID_TILE_SIZE);

                seed_piece[dividedXPosition, dividedYPosition] = tile.seedValue;
            }

            for (int i = 0; i < MAX_GRID_SIZE_WIDTH; i++)
            {
                for (int ii = 0; ii < MAX_GRID_SIZE_HEIGHT; ii++)
                {
                    finalLevelSeed += seed_piece[ii, i];
                }
            }

            switch (selectedLevelTheme)
            {
                case LevelTheme.GRASS:
                    finalLevelSeed += GRASS_THEME_SEED;
                    break;
                case LevelTheme.DESERT:
                    finalLevelSeed += DESERT_THEME_SEED;
                    break;
                case LevelTheme.ICE:
                    finalLevelSeed += ICE_THEME_SEED;
                    break;
                default:
                    finalLevelSeed += GRASS_THEME_SEED;
                    break;
            }

            Cursor.Current = Cursors.Default;
        }



        private void SaveFinalLevelSeedToFile(object sender, CancelEventArgs e)
        {
                System.IO.File.WriteAllText(levelExportDialog.FileName, finalLevelSeed);
        }



        private void updateTimer_Tick(object sender, EventArgs e)
        {
            highlightedDescriptionTitle.Text = highlightedTitleToBeDisplayed;
            highlightedDescriptionBody.Text = highlightedBodyToBeDisplayed;

            if (currentlySelectedTile != null)
            {
                selectedTilePreview.Image = currentlySelectedTile.icon;
                selectedTileNameLabel.Text = currentlySelectedTile.tileName;
            }

            if (dariusTileHasBeenPlaced && placedExitCount > 0)
            {
                copyLevelSeedButton.Enabled = true;
            }
            else copyLevelSeedButton.Enabled = false;

            if (LevelIsBlank()) clearLevelButton.Enabled = false; else clearLevelButton.Enabled = true;
        }



        private void InitializeLoadLevelDialog(object sender, EventArgs e)
        {
            DialogResult initialized_dialog = levelLoadDialog.ShowDialog();
            if (initialized_dialog == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(levelLoadDialog.FileName);
                string seed_to_pass = sr.ReadLine();
                sr.Close();
                LoadLevelSeed(seed_to_pass,null,null);
            }
        }



        private void LoadLevelSeed(string seed, object sender, CancelEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (seed != null)
            {
                if (seed.Length < ((MAX_GRID_SIZE_HEIGHT * MAX_GRID_SIZE_WIDTH) * 2) + 1)
                {
                    RemoveAllLevelTiles();
                    for (int i = 0; i < seed.Length / 2; i++)
                    {
                        PlaceTileBasedOnSeedChunk(seed.Substring(i * 2, 2), new Point(i % MAX_GRID_SIZE_WIDTH * GRID_TILE_SIZE, i / MAX_GRID_SIZE_HEIGHT * GRID_TILE_SIZE));
                        switch (seed.Substring(seed.Length - 1, 1))
                        {
                            case GRASS_THEME_SEED:
                                SetLevelTheme(LevelTheme.GRASS);
                                break;
                            case DESERT_THEME_SEED:
                                SetLevelTheme(LevelTheme.DESERT);
                                break;
                            case ICE_THEME_SEED:
                                SetLevelTheme(LevelTheme.ICE);
                                break;
                            default:
                                SetLevelTheme(LevelTheme.GRASS);
                                break;
                        }
                    }
                    MessageBox.Show("It seems this level has a shorter seed than expected, so some parts might not have loaded correctly.\n\nIt is strongly reccomended that you check your level before saving again to ensure that is how you have left it. It isn't reccomended that you modify level files directly, if you do wish to make changes, you should use the editor.", "Load Level", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    RemoveAllLevelTiles();
                    for (int i = 0; i < MAX_GRID_SIZE_WIDTH * MAX_GRID_SIZE_HEIGHT; i++)
                    {
                        PlaceTileBasedOnSeedChunk(seed.Substring(i * 2, 2), new Point(i % MAX_GRID_SIZE_WIDTH * GRID_TILE_SIZE, i / MAX_GRID_SIZE_HEIGHT * GRID_TILE_SIZE));
                        switch (seed.Substring(seed.Length - 1, 1))
                        {
                            case GRASS_THEME_SEED:
                                SetLevelTheme(LevelTheme.GRASS);
                                break;
                            case DESERT_THEME_SEED:
                                SetLevelTheme(LevelTheme.DESERT);
                                break;
                            case ICE_THEME_SEED:
                                SetLevelTheme(LevelTheme.ICE);
                                break;
                            default:
                                SetLevelTheme(LevelTheme.GRASS);
                                break;
                        }
                    }
                }
            } else MessageBox.Show("No data seems to exist inside this level file, nothing has been changed.", "Load Level", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Cursor.Current = Cursors.Default;
        }



        private void ResetLevel(object sender, EventArgs e)
        {
            if (!LevelIsBlank())
            {
                switch (MessageBox.Show("Are you sure you want to create a new level? Any work not saved will be lost.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        RemoveAllLevelTiles();
                        //SetLevelTheme(LevelTheme.GRASS);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }



        private void SetLevelTheme(LevelTheme theme)
        {
            selectedLevelTheme = theme;
            switch (selectedLevelTheme)
            {
                case LevelTheme.GRASS:
                    levelGridBackground.BackgroundImage = Properties.Resources.editor_background_grass;
                    selectedThemePreview.Image = Properties.Resources.theme_preview_grass;
                    break;
                case LevelTheme.DESERT:
                    levelGridBackground.BackgroundImage = Properties.Resources.editor_background_desert;
                    selectedThemePreview.Image = Properties.Resources.theme_preview_desert;
                    break;
                case LevelTheme.ICE:
                    levelGridBackground.BackgroundImage = Properties.Resources.editor_background_arctic;
                    selectedThemePreview.Image = Properties.Resources.theme_preview_ice;
                    break;
            }
        }



        private bool LevelIsBlank()
        {
            if (levelTiles.Count == 0 && !dariusTileHasBeenPlaced && placedExitCount == 0)
            {
                return true;
            }
            else return false;
        }



        private void themeSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (themeSelectionBox.SelectedItem)
            {
                case "Grasslands":
                    SetLevelTheme(LevelTheme.GRASS);
                    break;
                case "Desert":
                    SetLevelTheme(LevelTheme.DESERT);
                    break;
                case "Arctic":
                    SetLevelTheme(LevelTheme.ICE);
                    break;
                default:
                    break;
            }
        }



        private void saveLevelButton_Click(object sender, EventArgs e)
        {
            CompileLevelSeed();
            levelExportDialog.ShowDialog();
        }



        private void aboutButton_Click(object sender, CancelEventArgs e)
        {
            AboutWindow about_window = new AboutWindow(this);
            about_window.Show();
            this.Enabled = false;
        }



        private void ClearHighlightedTitleAndBody(object sender, EventArgs e)
        {
            highlightedTitleToBeDisplayed = "";
            highlightedBodyToBeDisplayed = "";
        }



        private void saveLevelButton_MouseEnter(object sender, EventArgs e)
        {
            highlightedTitleToBeDisplayed = "Save Level";
            highlightedBodyToBeDisplayed = "Save your current level to a .DARIUS file which can be loaded back into the editor later.";
        }



        private void loadLevelButton_MouseEnter(object sender, EventArgs e)
        {
            highlightedTitleToBeDisplayed = "Load Level";
            highlightedBodyToBeDisplayed = "Load a level back into the editor through a .DARIUS file.";
        }



        private void clearLevelButton_MouseEnter(object sender, EventArgs e)
        {
            highlightedTitleToBeDisplayed = "Clear Level";
            highlightedBodyToBeDisplayed = "Wipes everything on the grid back to a blank level. (ALL UNSAVED WORK WILL BE LOST!)";
        }



        private void copyLevelSeedButton_MouseEnter(object sender, EventArgs e)
        {
            highlightedTitleToBeDisplayed = "Get Level Seed";
            highlightedBodyToBeDisplayed = "Copy the seed of the level to clipboard for pasting into Destruction Darius 3D.";
        }



        private void copyLevelSeedButton_Click(object sender, EventArgs e)
        {
            CompileLevelSeed();
            Clipboard.SetText(finalLevelSeed);
        }



        //This method should NOT be called directly without confirmation from the user first.
        private void RemoveAllLevelTiles()
        {
            foreach (var tile in levelTiles)
            {
                tile.Dispose();
            }
            levelTiles = new List<Tile>();
            dariusTileHasBeenPlaced = false;
            placedExitCount = 0;
        }
    }
            
}