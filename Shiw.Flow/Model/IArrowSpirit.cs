using HelixToolkit.Wpf;
using Shiw.Flow.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Shiw.Flow.Model
{
    public class IArrowSpirit : ISpirit3D
    {
        public static readonly DependencyProperty Point0Property =
            DependencyPropertyEx.Register<Point3D, IArrowSpirit>("Point0", Point3D.Parse("0,0,0"), (s, e) => s.AppearanceChanged());
        public static readonly DependencyProperty Point1Property =
            DependencyPropertyEx.Register<Point3D, IArrowSpirit>("Point1", Point3D.Parse("0,10,0"), (s, e) => s.AppearanceChanged());
        public static readonly DependencyProperty Point2Property =
            DependencyPropertyEx.Register<Point3D, IArrowSpirit>("Point2", Point3D.Parse("0,20,0"), (s, e) => s.AppearanceChanged());
        public static readonly DependencyProperty Point3Property =
            DependencyPropertyEx.Register<Point3D, IArrowSpirit>("Point3", Point3D.Parse("0,30,0"), (s, e) => s.AppearanceChanged());
        public static readonly DependencyProperty ColorProperty =
            DependencyPropertyEx.Register<Color, IArrowSpirit>("Color", Colors.Blue, (s, e) => s.AppearanceChanged());


        public Point3D Point0
        {
            get { return (Point3D)this.GetValue(Point0Property); }
            set { this.SetValue(Point0Property, value); }
        }

        public Point3D Point1
        {
            get { return (Point3D)this.GetValue(Point1Property); }
            set { this.SetValue(Point1Property, value); }
        }

        public Point3D Point2
        {
            get { return (Point3D)this.GetValue(Point2Property); }
            set { this.SetValue(Point2Property, value); }
        }

        public Point3D Point3
        {
            get { return (Point3D)this.GetValue(Point3Property); }
            set { this.SetValue(Point3Property, value); }
        }

        public Color Color
        {
            get { return (Color)this.GetValue(ColorProperty); }
            set { this.SetValue(ColorProperty, value); }
        }

        public override void Update(object sender, System.Windows.Media.RenderingEventArgs args)
        {
            base.Update(sender, args);

            double delta = Watcher.ElapsedMilliseconds * Speed;

            Vector3D headDirection = Point3 - Point2;
            

            Watcher.Restart();
        }

        private void AppearanceChanged()
        {

        }
    }
}
