﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Properties;

namespace MaterialSkin
{
    public class MaterialSkinManager
    {
        private Dictionary<string, MaterialTransparentForm> _shadow = new Dictionary<string, MaterialTransparentForm>();
        public Dictionary<string, MaterialTransparentForm> Shadow { get => _shadow; set => _shadow = value; }

        //Singleton instance
        private static MaterialSkinManager _instance;

        //Forms to control
        private readonly List<Form> _formsToManage = new List<Form>();

        //Theme
        private Themes _theme;
        public Themes Theme
        {
            get { return _theme; }
            set
            {
                _theme = value;
                UpdateBackgrounds();
            }
        }

        private ColorScheme _colorScheme;
        public ColorScheme ColorScheme
        {
            get { return _colorScheme; }
            private set
            {
                _colorScheme = value;
                UpdateBackgrounds();
            }
        }

        private ColorType _colorType = ColorType.PRIMARY;
        public ColorType ColorStyle
        {
            get { return _colorType; }
            set
            {
                _colorType = value;
                ColorScheme = ColorScheme.ColorSwatches[_colorType];
            }
        }

        public enum Themes : byte
        {
            LIGHT,
            DARK
        }

        //Constant color values
        private static readonly Color PRIMARY_TEXT_BLACK = Color.FromArgb(255, 5, 5, 5);
        private static readonly Brush PRIMARY_TEXT_BLACK_BRUSH = new SolidBrush(PRIMARY_TEXT_BLACK);
        public static Color SECONDARY_TEXT_BLACK = Color.FromArgb(255, 130, 130, 130);
        public static Brush SECONDARY_TEXT_BLACK_BRUSH = new SolidBrush(SECONDARY_TEXT_BLACK);
        private static readonly Color DISABLED_OR_HINT_TEXT_BLACK = Color.FromArgb(255, 200, 200, 200);
        private static readonly Color HINT_TEXT_BLACK = Color.FromArgb(255, 75, 75, 75);
        private static readonly Brush DISABLED_OR_HINT_TEXT_BLACK_BRUSH = new SolidBrush(DISABLED_OR_HINT_TEXT_BLACK);
        private static readonly Brush HINT_TEXT_BLACK_BRUSH = new SolidBrush(HINT_TEXT_BLACK);
        private static readonly Color DIVIDERS_BLACK = Color.FromArgb(75, 0, 0, 0);
        private static readonly Brush DIVIDERS_BLACK_BRUSH = new SolidBrush(DIVIDERS_BLACK);

        private static readonly Color PRIMARY_TEXT_WHITE = Color.FromArgb(255, 255, 255, 255);
        private static readonly Brush PRIMARY_TEXT_WHITE_BRUSH = new SolidBrush(PRIMARY_TEXT_WHITE);
        public static Color SECONDARY_TEXT_WHITE = Color.FromArgb(255, 175, 175, 175);
        public static Brush SECONDARY_TEXT_WHITE_BRUSH = new SolidBrush(SECONDARY_TEXT_WHITE);
        private static readonly Color DISABLED_OR_HINT_TEXT_WHITE = Color.FromArgb(255, 80, 80, 80);
        private static readonly Brush DISABLED_OR_HINT_TEXT_WHITE_BRUSH = new SolidBrush(DISABLED_OR_HINT_TEXT_WHITE);
        private static readonly Color DIVIDERS_WHITE = Color.FromArgb(31, 255, 255, 255);
        private static readonly Brush DIVIDERS_WHITE_BRUSH = new SolidBrush(DIVIDERS_WHITE);

        // Checkbox colors
        private static readonly Color CHECKBOX_OFF_LIGHT = Color.FromArgb(138, 0, 0, 0);
        private static readonly Brush CHECKBOX_OFF_LIGHT_BRUSH = new SolidBrush(CHECKBOX_OFF_LIGHT);
        private static readonly Color CHECKBOX_OFF_DISABLED_LIGHT = Color.FromArgb(66, 0, 0, 0);
        private static readonly Brush CHECKBOX_OFF_DISABLED_LIGHT_BRUSH = new SolidBrush(CHECKBOX_OFF_DISABLED_LIGHT);

        private static readonly Color CHECKBOX_OFF_DARK = Color.FromArgb(179, 255, 255, 255);
        private static readonly Brush CHECKBOX_OFF_DARK_BRUSH = new SolidBrush(CHECKBOX_OFF_DARK);
        private static readonly Color CHECKBOX_OFF_DISABLED_DARK = Color.FromArgb(77, 255, 255, 255);
        private static readonly Brush CHECKBOX_OFF_DISABLED_DARK_BRUSH = new SolidBrush(CHECKBOX_OFF_DISABLED_DARK);

        //Raised button
        private static readonly Color RAISED_BUTTON_BACKGROUND = Color.FromArgb(255, 255, 255, 255);
        private static readonly Brush RAISED_BUTTON_BACKGROUND_BRUSH = new SolidBrush(RAISED_BUTTON_BACKGROUND);
        private static readonly Color RAISED_BUTTON_TEXT_LIGHT = PRIMARY_TEXT_WHITE;
        private static readonly Brush RAISED_BUTTON_TEXT_LIGHT_BRUSH = new SolidBrush(RAISED_BUTTON_TEXT_LIGHT);
        private static readonly Color RAISED_BUTTON_TEXT_DARK = PRIMARY_TEXT_BLACK;
        private static readonly Brush RAISED_BUTTON_TEXT_DARK_BRUSH = new SolidBrush(RAISED_BUTTON_TEXT_DARK);

        //Flat button
        private static readonly Color FLAT_BUTTON_BACKGROUND_HOVER_LIGHT = Color.FromArgb(20.PercentageToColorComponent(), 0x999999.ToColor());
        private static readonly Brush FLAT_BUTTON_BACKGROUND_HOVER_LIGHT_BRUSH = new SolidBrush(FLAT_BUTTON_BACKGROUND_HOVER_LIGHT);
        private static readonly Color FLAT_BUTTON_BACKGROUND_PRESSED_LIGHT = Color.FromArgb(40.PercentageToColorComponent(), 0x999999.ToColor());
        private static readonly Brush FLAT_BUTTON_BACKGROUND_PRESSED_LIGHT_BRUSH = new SolidBrush(FLAT_BUTTON_BACKGROUND_PRESSED_LIGHT);
        private static readonly Color FLAT_BUTTON_DISABLEDTEXT_LIGHT = Color.FromArgb(26.PercentageToColorComponent(), 0x000000.ToColor());
        private static readonly Brush FLAT_BUTTON_DISABLEDTEXT_LIGHT_BRUSH = new SolidBrush(FLAT_BUTTON_DISABLEDTEXT_LIGHT);

        private static readonly Color FLAT_BUTTON_BACKGROUND_HOVER_DARK = Color.FromArgb(15.PercentageToColorComponent(), 0xCCCCCC.ToColor());
        private static readonly Brush FLAT_BUTTON_BACKGROUND_HOVER_DARK_BRUSH = new SolidBrush(FLAT_BUTTON_BACKGROUND_HOVER_DARK);
        private static readonly Color FLAT_BUTTON_BACKGROUND_PRESSED_DARK = Color.FromArgb(25.PercentageToColorComponent(), 0xCCCCCC.ToColor());
        private static readonly Brush FLAT_BUTTON_BACKGROUND_PRESSED_DARK_BRUSH = new SolidBrush(FLAT_BUTTON_BACKGROUND_PRESSED_DARK);
        private static readonly Color FLAT_BUTTON_DISABLEDTEXT_DARK = Color.FromArgb(30.PercentageToColorComponent(), 0xFFFFFF.ToColor());
        private static readonly Brush FLAT_BUTTON_DISABLEDTEXT_DARK_BRUSH = new SolidBrush(FLAT_BUTTON_DISABLEDTEXT_DARK);

        //ContextMenuStrip
        private static readonly Color CMS_BACKGROUND_LIGHT_HOVER = Color.FromArgb(255, 238, 238, 238);
        private static readonly Brush CMS_BACKGROUND_HOVER_LIGHT_BRUSH = new SolidBrush(CMS_BACKGROUND_LIGHT_HOVER);

        private static readonly Color CMS_BACKGROUND_DARK_HOVER = Color.FromArgb(38, 204, 204, 204);
        private static readonly Brush CMS_BACKGROUND_HOVER_DARK_BRUSH = new SolidBrush(CMS_BACKGROUND_DARK_HOVER);

        //Application background
        private static readonly Color BACKGROUND_LIGHT = Color.FromArgb(255, 255, 255, 255);
        private static Brush BACKGROUND_LIGHT_BRUSH = new SolidBrush(BACKGROUND_LIGHT);

        private static readonly Color BACKGROUND_DARK = Color.FromArgb(255, 51, 51, 51);
        private static Brush BACKGROUND_DARK_BRUSH = new SolidBrush(BACKGROUND_DARK);

        //Application action bar
        public readonly Color ACTION_BAR_TEXT = Color.FromArgb(255, 255, 255, 255);
        public readonly Brush ACTION_BAR_TEXT_BRUSH = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
        public readonly Color ACTION_BAR_TEXT_SECONDARY = Color.FromArgb(153, 255, 255, 255);
        public readonly Brush ACTION_BAR_TEXT_SECONDARY_BRUSH = new SolidBrush(Color.FromArgb(153, 255, 255, 255));

        public Color GetPrimaryTextColor()
        {
            return Theme == Themes.LIGHT ? PRIMARY_TEXT_BLACK : PRIMARY_TEXT_WHITE;
        }

        public Brush GetPrimaryTextBrush()
        {
            return Theme == Themes.LIGHT ? PRIMARY_TEXT_BLACK_BRUSH : PRIMARY_TEXT_WHITE_BRUSH;
        }

        public Color GetSecondaryTextColor()
        {
            return Theme == Themes.LIGHT ? SECONDARY_TEXT_BLACK : SECONDARY_TEXT_WHITE;
        }

        public Brush GetSecondaryTextBrush()
        {
            return Theme == Themes.LIGHT ? SECONDARY_TEXT_BLACK_BRUSH : SECONDARY_TEXT_WHITE_BRUSH;
        }

        public Color GetDisabledOrHintColor()
        {
            return Theme == Themes.LIGHT ? DISABLED_OR_HINT_TEXT_BLACK : DISABLED_OR_HINT_TEXT_WHITE;
        }

        public Color GetHintColor()
        {
            return Theme == Themes.LIGHT ? HINT_TEXT_BLACK : DISABLED_OR_HINT_TEXT_WHITE ;
        }

        public Brush GetDisabledOrHintBrush()
        {
            return Theme == Themes.LIGHT ? DISABLED_OR_HINT_TEXT_BLACK_BRUSH : DISABLED_OR_HINT_TEXT_WHITE_BRUSH;
        }

        public Brush GetHintBrush()
        {
            return Theme == Themes.LIGHT ? HINT_TEXT_BLACK_BRUSH : DISABLED_OR_HINT_TEXT_WHITE_BRUSH;
        }

        public Color GetDividersColor()
        {
            return Theme == Themes.LIGHT ? DIVIDERS_BLACK : DIVIDERS_WHITE;
        }

        public Brush GetDividersBrush()
        {
            return Theme == Themes.LIGHT ? DIVIDERS_BLACK_BRUSH : DIVIDERS_WHITE_BRUSH;
        }

        public Color GetCheckboxOffColor()
        {
            return Theme == Themes.LIGHT ? CHECKBOX_OFF_LIGHT : CHECKBOX_OFF_DARK;
        }

        public Brush GetCheckboxOffBrush()
        {
            return Theme == Themes.LIGHT ? CHECKBOX_OFF_LIGHT_BRUSH : CHECKBOX_OFF_DARK_BRUSH;
        }

        public Color GetCheckBoxOffDisabledColor()
        {
            return Theme == Themes.LIGHT ? CHECKBOX_OFF_DISABLED_LIGHT : CHECKBOX_OFF_DISABLED_DARK;
        }

        public Brush GetCheckBoxOffDisabledBrush()
        {
            return Theme == Themes.LIGHT ? CHECKBOX_OFF_DISABLED_LIGHT_BRUSH : CHECKBOX_OFF_DISABLED_DARK_BRUSH;
        }

        public Brush GetRaisedButtonBackgroundBrush()
        {
            return RAISED_BUTTON_BACKGROUND_BRUSH;
        }

        public Color GetRaisedButtonTextColor(bool primary)
        {
            return primary ? RAISED_BUTTON_TEXT_LIGHT : RAISED_BUTTON_TEXT_DARK;
        }

        public Brush GetRaisedButtonTextBrush(bool primary)
        {
            return primary ? RAISED_BUTTON_TEXT_LIGHT_BRUSH : RAISED_BUTTON_TEXT_DARK_BRUSH;
        }

        public Color GetFlatButtonHoverBackgroundColor()
        {
            return Theme == Themes.LIGHT ? FLAT_BUTTON_BACKGROUND_HOVER_LIGHT : FLAT_BUTTON_BACKGROUND_HOVER_DARK;
        }

        public Brush GetFlatButtonHoverBackgroundBrush()
        {
            return Theme == Themes.LIGHT ? FLAT_BUTTON_BACKGROUND_HOVER_LIGHT_BRUSH : FLAT_BUTTON_BACKGROUND_HOVER_DARK_BRUSH;
        }

        public Color GetFlatButtonPressedBackgroundColor()
        {
            return Theme == Themes.LIGHT ? FLAT_BUTTON_BACKGROUND_PRESSED_LIGHT : FLAT_BUTTON_BACKGROUND_PRESSED_DARK;
        }

        public Brush GetFlatButtonPressedBackgroundBrush()
        {
            return Theme == Themes.LIGHT ? FLAT_BUTTON_BACKGROUND_PRESSED_LIGHT_BRUSH : FLAT_BUTTON_BACKGROUND_PRESSED_DARK_BRUSH;
        }

        public Brush GetFlatButtonDisabledTextBrush()
        {
            return Theme == Themes.LIGHT ? FLAT_BUTTON_DISABLEDTEXT_LIGHT_BRUSH : FLAT_BUTTON_DISABLEDTEXT_DARK_BRUSH;
        }

        public Brush GetCmsSelectedItemBrush()
        {
            return Theme == Themes.LIGHT ? CMS_BACKGROUND_HOVER_LIGHT_BRUSH : CMS_BACKGROUND_HOVER_DARK_BRUSH;
        }

        public Color GetApplicationBackgroundColor()
        {
            return Theme == Themes.LIGHT ? BACKGROUND_LIGHT : BACKGROUND_DARK;
        }

        //Roboto font
        public Font ROBOTO_REGULAR_11;

        public Font ROBOTO_MEDIUM_18;
        public Font ROBOTO_MEDIUM_16;
        public Font ROBOTO_MEDIUM_14;
        public Font ROBOTO_MEDIUM_12;
        public Font ROBOTO_MEDIUM_11;
        public Font ROBOTO_MEDIUM_10;
        public Font ROBOTO_MEDIUM_8;

        public Font ROBOTO_BOLD_10;

        //Other constants
        public int FORM_PADDING = 16;

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pvd, [In] ref uint pcFonts);

        private MaterialSkinManager()
        {
            ROBOTO_REGULAR_11 = new Font(LoadFont(Resources.Roboto_Regular), 11f);

            ROBOTO_MEDIUM_18 = new Font(LoadFont(Resources.Roboto_Medium), 18f);
            ROBOTO_MEDIUM_16 = new Font(LoadFont(Resources.Roboto_Medium), 16f);
            ROBOTO_MEDIUM_14 = new Font(LoadFont(Resources.Roboto_Medium), 14f);
            ROBOTO_MEDIUM_12 = new Font(LoadFont(Resources.Roboto_Medium), 12f);
            ROBOTO_MEDIUM_11 = new Font(LoadFont(Resources.Roboto_Medium), 11f);
            ROBOTO_MEDIUM_10 = new Font(LoadFont(Resources.Roboto_Medium), 10f);
            ROBOTO_MEDIUM_8 = new Font(LoadFont(Resources.Roboto_Medium), 8f);

            ROBOTO_BOLD_10 = new Font(LoadFont(Resources.Roboto_Regular), 10f, FontStyle.Bold);
            Theme = Themes.LIGHT;
            ColorScheme = ColorScheme.ColorSwatches[ColorType.DEFAULT];
            _shadow = new Dictionary<string, MaterialTransparentForm>();
        }

        public static MaterialSkinManager Instance => _instance ?? (_instance = new MaterialSkinManager());

        

        public void AddFormToManage(Form materialForm)
        {
            _formsToManage.Add(materialForm);
            UpdateBackgrounds();
        }

        public void RemoveFormToManage(MaterialForm materialForm)
        {
            _formsToManage.Remove(materialForm);
        }

        private readonly PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        private FontFamily LoadFont(byte[] fontResource)
        {
            int dataLength = fontResource.Length;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontResource, 0, fontPtr, dataLength);

            uint cFonts = 0;
            AddFontMemResourceEx(fontPtr, (uint)fontResource.Length, IntPtr.Zero, ref cFonts);
            privateFontCollection.AddMemoryFont(fontPtr, dataLength);

            return privateFontCollection.Families.Last();
        }

        private void UpdateBackgrounds()
        {
            var newBackColor = GetApplicationBackgroundColor();
            foreach (var materialForm in _formsToManage)
            {
                materialForm.BackColor = newBackColor;
                UpdateControl(materialForm, newBackColor);
            }
        }

        private void UpdateToolStrip(ToolStrip toolStrip, Color newBackColor)
        {
            if (toolStrip == null) return;

            toolStrip.BackColor = newBackColor;
            foreach (ToolStripItem control in toolStrip.Items)
            {
                control.BackColor = newBackColor;
                if (control is MaterialToolStripMenuItem && (control as MaterialToolStripMenuItem).HasDropDown)
                {

                    //recursive call
                    UpdateToolStrip((control as MaterialToolStripMenuItem).DropDown, newBackColor);
                }
            }
        }

        private void UpdateControl(Control controlToUpdate, Color newBackColor)
        {
            if (controlToUpdate == null) return;

            if (controlToUpdate.ContextMenuStrip != null)
            {
                UpdateToolStrip(controlToUpdate.ContextMenuStrip, newBackColor);
            }
            var tabControl = controlToUpdate as MaterialTabControl;
            if (tabControl != null)
            {
                foreach (TabPage tabPage in tabControl.TabPages)
                {
                    tabPage.BackColor = newBackColor;
                }
            }

            if (controlToUpdate is MaterialDivider)
            {
                controlToUpdate.BackColor = GetDividersColor();
            }

            if (controlToUpdate is MaterialListView)
            {
                controlToUpdate.BackColor = newBackColor;
            }

            if (controlToUpdate is MaterialRichText)
            {
                controlToUpdate.BackColor = newBackColor;
            }

            if (controlToUpdate is MaterialPanel)
            {
                controlToUpdate.BackColor = newBackColor;
            }

            if (controlToUpdate is MaterialGridView)
            {
                controlToUpdate.BackColor = newBackColor;
                ((MaterialGridView)controlToUpdate).SetGridColors();
            }

            //recursive call
            foreach (Control control in controlToUpdate.Controls)
            {
                UpdateControl(control, newBackColor);
            }

            controlToUpdate.Invalidate();
        }
    }
}
