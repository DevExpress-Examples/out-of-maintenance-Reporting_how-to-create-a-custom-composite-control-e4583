using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using DevExpress.XtraReports;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.Design.Behaviours;
using System.ComponentModel.Design;

namespace CustomControls {

    [
ToolboxItem(true),
        XRDesigner("CustomControls.MyPanelDesigner"),
    Designer("CustomControls.MyPanelDesigner"),
]
    public class MyCompositeControl : XRPanel {
        public MyCompositeControl()
            : base() {
                this.SizeF = new System.Drawing.SizeF(200, 50);
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
            label1.ExpressionBindings.Add(new ExpressionBinding("Text","[ProductID]"));            
            label1.SizeF = new System.Drawing.SizeF(200, 25);
            panel.Controls.Add(label1);
            XRLabel label2 = new XRLabel();
            panel.Controls.Add(label2);
            label2.SizeF = new System.Drawing.SizeF(200, 25);
            label2.LocationF = new System.Drawing.PointF(0, 25);            
            label2.ExpressionBindings.Add(new ExpressionBinding("Text", "[ProductName]"));
        }
        public void AddChildControlsToContainer() {
            MyCompositeControl panel = this.XRControl as MyCompositeControl;
            foreach(XRControl childControl in panel.Controls) {
                System.Drawing.PointF loc = childControl.LocationF;
                IDesignerHost designerHost = (IDesignerHost)GetService(typeof(IDesignerHost));
                DesignToolHelper.AddToContainer(designerHost, childControl);                
                childControl.LocationF = loc;
            }
        }
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
