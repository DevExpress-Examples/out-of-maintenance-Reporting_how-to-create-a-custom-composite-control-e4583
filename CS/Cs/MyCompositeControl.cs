using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using DevExpress.XtraReports;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.Design.Behaviours;

namespace CustomControls {

    [
ToolboxItem(true),
        XRDesigner("CustomControls.MyPanelDesigner"),
    Designer("CustomControls.MyPanelDesigner"),
]
    public class MyCompositeControl : XRPanel {
        public MyCompositeControl()
            : base() {
                this.SizeF = new System.Drawing.SizeF(50, 50);
         ;
        }
    }
    [DesignerBehaviour(typeof(MyPanelDesignerBehaviour))]
    public class MyPanelDesigner : XRPanelDesigner {
        public MyPanelDesigner()
            : base() {
              
        }
        public void InitControls() {
            MyCompositeControl panel = this.XRControl as MyCompositeControl;
            
            XRLabel label1 = new XRLabel();
            label1.DataBindings.Add("Text", null, "CategoryID");
            label1.SizeF = new System.Drawing.SizeF(50, 25);
            panel.Controls.Add(label1);
            XRLabel label2 = new XRLabel();
            panel.Controls.Add(label2);
            label2.SizeF = new System.Drawing.SizeF(50, 25);
            label2.LocationF = new System.Drawing.PointF(0, 25);
            label2.DataBindings.Add("Text", null, "CategoryName");
        }
        public void AddChildControlsToContainer() {
            MyCompositeControl panel = this.XRControl as MyCompositeControl;
            foreach(XRControl childControl in panel.Controls) {
                System.Drawing.PointF loc = childControl.LocationF;
                DesignToolHelper.AddToContainer(fDesignerHost, childControl);
                childControl.LocationF = loc;
            }
        }
        //          override 
    }

    public class MyPanelDesignerBehaviour : DesignerBehaviour {
        public MyPanelDesignerBehaviour(IServiceProvider servProvider)
            : base(servProvider) {
        }
        public override void SetDefaultComponentBounds() {
            base.SetDefaultComponentBounds();
            (Designer as MyPanelDesigner).InitControls();
            (Designer as MyPanelDesigner).AddChildControlsToContainer();
        }
    }
}
