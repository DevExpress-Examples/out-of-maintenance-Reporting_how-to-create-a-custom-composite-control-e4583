using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Drawing.Design;
namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            ReportDesignTool tool = new ReportDesignTool(report);
            tool.DesignForm.DesignMdiController.DesignPanelLoaded += new DevExpress.XtraReports.UserDesigner.DesignerLoadedEventHandler(DesignMdiController_DesignPanelLoaded);
            tool.ShowDesignerDialog();
            
        }

        void DesignMdiController_DesignPanelLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e) {
            IToolboxService ts =
    (IToolboxService)e.DesignerHost.GetService(typeof(IToolboxService));
           ts.AddToolboxItem(new ToolboxItem(typeof(CustomControls.MyCompositeControl)), "New Category");

        }
    }
}
