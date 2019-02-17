using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;

namespace MaterialSkin.Controls
{
    public sealed class MaterialDataGridViewButtonColumn : DataGridViewColumn
    {
        private int _iconSize = 24;
        private IconType _iconType = IconType.NONE;
        public IconType IconType
        {
            get { return _iconType; }
            set { _iconType = value; }
        }

        public MaterialDataGridViewButtonColumn()
        {
            CellTemplate = new MaterialDataGridViewButtonCell();
            ReadOnly = true;
        }
    }

    public class MaterialDataGridViewButtonCell : DataGridViewCell, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        private ColorType _colorStyle = ColorType.DEFAULT;
        public ColorType ColorStyle { get => _colorStyle; set => _colorStyle = value; }

        private readonly AnimationManager _animationManager;
        private readonly AnimationManager _hoverAnimationManager;

        private int _iconSize = 24;
        private IconType _iconType = IconType.NONE;
        public IconType IconType
        {
            get { return _iconType; }
            set { _iconType = value; }
        }

        public MaterialDataGridViewButtonCell()
        {
            _animationManager = new AnimationManager(false)
            {
                Increment = 0.03,
                AnimationType = AnimationType.EaseOut
            };
            _hoverAnimationManager = new AnimationManager
            {
                Increment = 0.07,
                AnimationType = AnimationType.Linear
            };
            this.Value = "TEST";
            this.ValueType = typeof(string);
            //_hoverAnimationManager.OnAnimationProgress += sender => Invalidate();
            //_animationManager.OnAnimationProgress += sender => Invalidate();
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            var backBrush = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.PrimaryBrush : ColorScheme.ColorSwatches[_colorStyle].PrimaryBrush;
            var lineColor = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.DarkPrimaryColor : ColorScheme.ColorSwatches[_colorStyle].DarkPrimaryColor;
            var frontBrush = _colorStyle == ColorType.DEFAULT ? SkinManager.GetPrimaryTextBrush() : ColorScheme.ColorSwatches[_colorStyle].PrimaryBrush;
            var backColor = backBrush.GetColor();
            var frontColor = frontBrush.GetColor();
            var g = graphics;
            //g.Clear(this.DataGridView.BackgroundColor);
            var backgroundColor = this.DataGridView.BackgroundColor;
            
            //backgroundColor = Selected ? DataGridView.DefaultCellStyle.SelectionBackColor : DataGridView.BackgroundColor;
            g.FillRectangle(new SolidBrush(backgroundColor), cellBounds);


            //using (var backgroundPath = DrawHelper.CreateRoundRect(cellBounds.X, cellBounds.Y, cellBounds.Width, cellBounds.Height, 0.1f))
            //{
            //    g.FillPath(new SolidBrush(lineColor), backgroundPath);
            //}

            int pad = 3;
            using (var backgroundPath = DrawHelper.CreateRoundRect(cellBounds.X+pad, cellBounds.Y+pad, cellBounds.Width - (pad * 2), cellBounds.Height - (pad * 2), 0.1f))
            {
                g.FillPath(backBrush, backgroundPath);
            }

            //g.TextRenderingHint = TextRenderingHint.AntiAlias;

            //string txt = "test";

            //g.DrawString(
            //    txt.ToUpper(),
            //    SkinManager.ROBOTO_MEDIUM_10,
            //    frontBrush,
            //    cellBounds,
            //    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
            //    );

            //var cellValue = (string)value;
            //const int vertoffset = 0;
            //const int horizontaloffset = 0;
            //var newRect = new Rectangle(
            //   cellBounds.X + horizontaloffset,
            //   cellBounds.Y + cellBounds.Height - 10,
            //   cellBounds.Width,
            //   8);
            //graphics.FillRectangle(new SolidBrush(frontColor), newRect);
        }


    }
}
