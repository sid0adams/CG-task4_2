using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib3D;
using System.IO;
namespace App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Camera camera = new Camera();
        Scene scene = new Scene();
        Point start;
        private void Output_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left) && start != null)
            {

                Point dp = new Point(e.X - start.X, e.Y - start.Y);
                float alpha = dp.X * (float)System.Math.PI / 180f;
                float betta = dp.Y * (float)System.Math.PI / 180f;
                camera.View = Matrix4.RotationMatrix(0, -betta) * Matrix4.RotationMatrix(2, -alpha) * camera.View;
                Upd();
            }
            start = e.Location;
        }
        void Upd()
        {
            Bitmap t = scene.Draw(camera, new Lib3D.Screen(Output.Size, new RectangleF(-1, 1, 2, 2)));
            Output.Image = t;
        }
        public void Clear()
        {
            scene = new Scene();
            int L = 60;
            scene.Models.Add(Model.GetOXYZ(L));
            Upd();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //CubBtn.Checked = true;
            ModelChanged(sender, e);
        }

        private void ModelChanged(object sender, EventArgs e)
        {
            Clear();
            if(CubBtn.Checked)
            {
                scene.Models.Add(Model.GetCube((float)GetSize.Value));
            }
            else if(OctahedronBtn.Checked)
            {
                scene.Models.Add(Model.GetOctahedron((float)GetSize.Value));
            }
            else if (TetrahedronBtn.Checked)
            {
                scene.Models.Add(Model.GetTetrahedron((float)GetSize.Value));
            }
            else if(IcosahedronBtn.Checked)
            {
                scene.Models.Add(Model.GetIcosahedron((float)GetSize.Value));
            }
            Upd();
        }
    }
}
