using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Shiw.Flow.Model.Base
{
    /// <summary>
    /// Internative Spirit, other dynamic object will inherit this class.
    /// </summary>
    public class ISpirit3D : ModelVisual3D
    {

        public double Speed;               // present spirit move speed
        public ISpirit3D(double speed)
        {
            Speed = speed;

            _eventListener = new RenderingEventListener(this.Update);
            RenderingEventManager.AddListener(_eventListener);
        }

        public readonly Stopwatch Watcher = new Stopwatch();
        private readonly RenderingEventListener _eventListener;

        public virtual void Update(object sender, RenderingEventArgs args)
        {
            // 
        }
    }
}
