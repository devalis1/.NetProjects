using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class frmArboles : Form
    {

        Nodo Raiz = new Nodo("A", new Nodo("B", new Nodo("D", null, null), new Nodo("E", null, null)), new Nodo("C", new Nodo("F", null, null), new Nodo("G", null, null)));
        ArbolBinario arbol = new ArbolBinario();

        public frmArboles()
        {
            InitializeComponent();
        }

        private void RecorridoPreOrden(Nodo pNodo)
        {
            if (pNodo != null) //Punto de corte...
            {
                this.txtPreOrden.Text += pNodo.Nombre + " - ";//Visitar
                this.RecorridoPreOrden(pNodo.Izq);
                this.RecorridoPreOrden(pNodo.Der);
            }
        }

        private void RecorridoPosOrden(Nodo pNodo)
        {
            if (pNodo != null) //Punto de corte...
            {
                this.RecorridoPosOrden(pNodo.Izq);
                this.RecorridoPosOrden(pNodo.Der);
                this.txtPreOrden.Text += pNodo.Nombre + " - ";
            }
        }

        //MIRAR ÚLTIMO!!!
        private void RecorridoAmplitud(List<Nodo> pNodo, int nivel)
        {
            if (pNodo.Count > 0)
            {
                List<Nodo> Lista = new List<Nodo>();
                this.txtAmplitud.Text += "Nivel " + nivel.ToString() + ":";

                foreach (Nodo N in pNodo)
                {
                    this.txtAmplitud.Text += N.Nombre + "-";
                    if (N.Izq != null || N.Der != null)
                    {
                        Lista.Add(N.Izq);
                        Lista.Add(N.Der);
                    };
                }
                nivel++;
                this.RecorridoAmplitud(Lista, nivel);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //OBJETIVO
            //txtPreOrden.Text = arbolBinario.RecorridoPreOrden();

            this.txtPreOrden.Clear();
            this.RecorridoPreOrden(this.Raiz);

            this.txtPreOrden.Text = this.txtPreOrden.Text.Substring(0, this.txtPreOrden.TextLength - 2);
            this.TreeView3.Nodes.Clear();
            this.MostrarTreeView(this.Raiz, null, this.TreeView3);
            this.TreeView3.ExpandAll();
        }

        private void MostrarTreeView(Nodo pNodo, TreeNode pTreeNode, TreeView pTreeView)
        {
            //ANALIZAR LA RECURSIVIDAD VISUAL!!!
            if (pNodo != null)
            {
                TreeNode NodoTemp = new TreeNode(pNodo.Nombre);
                if (pTreeNode == null)
                {
                    pTreeView.Nodes.Add(NodoTemp);
                }
                else
                {
                    pTreeNode.Nodes.Add(NodoTemp);
                }
                this.MostrarTreeView(pNodo.Der, NodoTemp, pTreeView);
                this.MostrarTreeView(pNodo.Izq, NodoTemp, pTreeView);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.trvNro1.Nodes.Clear();
            TreeNode AA = new TreeNode("A");
            TreeNode BB = new TreeNode("B");
            TreeNode CC = new TreeNode("C");
            TreeNode DD = new TreeNode("D");
            TreeNode EE = new TreeNode("E");
            TreeNode FF = new TreeNode("F");
            TreeNode GG = new TreeNode("G");
            TreeNode HH = new TreeNode("H");

            if (AA.Nodes.Count < 3)
            {
                AA.Nodes.Add(CC);
                AA.Nodes.Add(BB);
            }

            BB.Nodes.Add(EE);
            BB.Nodes.Add(DD);

            CC.Nodes.Add(GG);
            CC.Nodes.Add(FF);

            if (this.trvNro1.Nodes.Count == 0)
                this.trvNro1.Nodes.Add(AA);

            AA.ExpandAll();
        }

        private void TodosElementos(TreeNodeCollection nodo)
        {
            foreach (var item in nodo)
            {
                if ((item as TreeNode).Nodes.Count > 0)
                {
                    //Recursiva... 
                    TodosElementos((item as TreeNode).Nodes);
                }

                MessageBox.Show(((item as TreeNode).Text));
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del nodo a agregar
            string nombreNodo = Interaction.InputBox("Ingrese Nombre", "Agregar Nodo", "Nombre");
            if (!string.IsNullOrWhiteSpace(nombreNodo))
            {
                // Agregar el nodo
                arbol.Agregar(nombreNodo); 

                TreeNode nuevoNodo = new TreeNode(nombreNodo);
                if (TreeView2.Nodes.Count == 0)
                {
                    TreeView2.Nodes.Add(nuevoNodo);
                }
                else
                {
                    TreeNode selectedNode = TreeView2.SelectedNode;
                    if (selectedNode != null)
                    {
                        if (selectedNode.Nodes.Count < 2)
                        {
                            selectedNode.Nodes.Add(nuevoNodo);
                            selectedNode.Expand();
                        }
                        else
                        {
                            MessageBox.Show("No se pueden agregar más de dos a un nodo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Si no hay nodo seleccionado, agregar el nodo a la raíz del TreeView
                        TreeView2.Nodes[0].Nodes.Add(nuevoNodo);
                        TreeView2.Nodes[0].Expand();
                    }
                }
            }
            else
            {
                MessageBox.Show("El nombre del nodo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if ((this.TreeView2.SelectedNode != null))
            {
                this.TreeView2.SelectedNode.Remove();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.txtAmplitud.Clear();
            this.RecorridoAmplitud(new List<Nodo>() { this.Raiz }, 1);
            this.txtAmplitud.Text = this.txtAmplitud.Text.Substring(0, this.txtAmplitud.TextLength - 2);
            this.TreeView6.Nodes.Clear();
            this.MostrarTreeView(this.Raiz, null, this.TreeView6);
            this.TreeView6.ExpandAll();
        }

        private void frmArboles_Load(object sender, EventArgs e)
        {
            //DEMO CREACIÓN DEL ÁRBOL...
            //Alumno alumno = new Alumno();
            //alumno.Nombre = "Cesar";
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

     
      
    }
}

