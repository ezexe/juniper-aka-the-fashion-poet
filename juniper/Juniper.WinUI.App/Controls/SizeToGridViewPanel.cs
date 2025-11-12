namespace Juniper.WinUI.App.Controls
{
    using Windows.Foundation;

    /// <summary>
    /// Uniformly positions child items in columns to present in WrapGrid.
    /// Uses largest item's DesiredSize for item size mesasurements.
    /// Expects limited height and unbound width.
    /// </summary>
    public class SizeToGridViewPanel : Panel
    {
        //private double maxWidth;
        //private double maxHeight;

        //protected override Size ArrangeOverride(Size finalSize)
        //{
        //    var x = 0.0;
        //    var y = 0.0;
        //    foreach (var child in Children)
        //    {
        //        if ((maxWidth + x) > finalSize.Width)
        //        {
        //            x = 0;
        //            y += maxHeight;
        //        }
        //        var newpos = new Rect(x, y, maxWidth, maxHeight);
        //        child.Arrange(newpos);
        //        x += maxWidth;
        //    }
        //    return finalSize;
        //}

        //protected override Size MeasureOverride(Size availableSize)
        //{
        //    foreach (var child in Children)
        //    {
        //        child.Measure(availableSize);

        //        var desirtedwidth = child.DesiredSize.Width;
        //        if (desirtedwidth > maxWidth)
        //            maxWidth = desirtedwidth;

        //        var desiredheight = child.DesiredSize.Height;
        //        if (desiredheight > maxHeight)
        //            maxHeight = desiredheight;
        //    }
        //    var itemperrow = Math.Floor(availableSize.Width / maxWidth);
        //    var rows = Math.Ceiling(Children.Count / itemperrow);
        //    return new Size(itemperrow * maxWidth, maxHeight * rows);
        //}

        protected override Size MeasureOverride(Size availableSize)
        {
            return ArrangeInternal(availableSize, callArrange: false);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            return ArrangeInternal(finalSize);
        }
        //private double GetXLocationAfterMiddleChild(int childNUmber)
        //{
        //    double xLocation = 0;
        //    for (int i = 0; i < childNUmber; i++)
        //    {
        //        xLocation += this.Children[i].DesiredSize.Width;
        //    }

        //    return xLocation;
        //}

        //private double GetYLocationAfterMiddleChild(int relativeChildNumber)
        //{
        //    double yLocation = 0;
        //    for (int i = 0; i < relativeChildNumber; i++)
        //    {
        //        yLocation += this.Children[i].DesiredSize.Height;
        //    }

        //    return yLocation;

        //}
        //private int GetTheMiddleChild(int count)
        //{
        //    int middleChild;
        //    if (count % 2 == 0)
        //    {
        //        middleChild = count / 2;
        //    }
        //    else
        //    {
        //        middleChild = (count / 2) + 1;
        //    }

        //    return middleChild;
        //}

        private Size ArrangeInternal(Size size, bool callArrange = true)
        {
            double itemWidth = 0.0, itemHeight = 0.0;
            foreach (var item in Children)
            {
                item.Measure(size);
                itemWidth = Math.Max(itemWidth, item.DesiredSize.Width);
                itemHeight = Math.Max(itemHeight, item.DesiredSize.Height);
            }
            itemHeight = Math.Min(itemHeight, size.Height);
            double totalWidth = itemWidth, totalHeight = itemHeight;
            double x = 0.0, y = 0.0;
            int index = 0;
            foreach (var item in Children)
            {
                if (index != 0)
                {
                    if (itemWidth + x < size.Width - itemWidth)
                    {
                        x += itemWidth + 6;
                        if (totalWidth < x + itemWidth)
                            totalWidth = x + itemWidth;
                    }
                    else
                    {
                        x = 0;
                        y += itemHeight + 6;
                        totalHeight = y + itemHeight;
                    }
                }

                if (callArrange) item.Arrange(new Rect(x, y, itemWidth, itemHeight));
                index++;
            }

            return new Size(totalWidth, totalHeight);
        }
    }
}