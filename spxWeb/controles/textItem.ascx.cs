using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class controles_textItem : System.Web.UI.UserControl
{
    [Serializable]
    public class itemEspecial 
    {
        public itemEspecial(){ }

        public string Text { set; get; }

        public string Value { set; get; }
    }

    /// <summary>
    /// Lista de Los valores Seleccionados
    /// </summary>
    public List<itemEspecial> ListaItems{get{return listaItems;}} 

    private List<itemEspecial> listaItems = new List<itemEspecial>();

    private bool mostrarBoton=true;
    public bool MostrarBoton { set { mostrarBoton = value;  } get { return mostrarBoton; } }


    protected void Page_Load(object sender, EventArgs e)
    {
        //ViewState[""
        //if (!IsPostBack)
        //{
            generarItems();
        //}
    }

    public void agregar(ListItem item) 
    {
        controles_controlTxtItem i = (controles_controlTxtItem)LoadControl("controlTxtItem.ascx");
        i.ID = listaItems.Count + "controltext";
        i.mostrarBoton = mostrarBoton;
        i.despuesDeQuitar += new EventHandler(i_despuesDeQuitar);
        i.Text = item.Text;
        i.Value = item.Value;
        bool contiene = false;
        for (int k = 0; k < listaItems.Count; k++)
        {
            if (listaItems[k].Value == item.Value)
            {
                contiene = true;
            }
        }
        if (!contiene)
        {
            itemEspecial x = new itemEspecial();
            x.Text = item.Text;
            x.Value = item.Value;
            
            listaItems.Add(x);
            
        }
        generarItems();
    }

    public void agregarSingleton(ListItem item)
    {
        controles_controlTxtItem i = (controles_controlTxtItem)LoadControl("controlTxtItem.ascx");
        i.ID = listaItems.Count + "controltext";
        i.mostrarBoton = mostrarBoton;
        i.despuesDeQuitar += new EventHandler(i_despuesDeQuitar);
        i.Text = item.Text;
        i.Value = item.Value;
        i.mostrarBoton = this.MostrarBoton;
        listaItems.Clear();
            itemEspecial x = new itemEspecial();
            x.Text = item.Text;
            x.Value = item.Value;
            listaItems.Add(x);
        
        generarItems();
    }

    void i_despuesDeQuitar(object sender, EventArgs e)
    {
        //quitamos el objeto de la lista
        controles_controlTxtItem i = (controles_controlTxtItem)sender;
        for (int k = 0; k < listaItems.Count; k++)
        {
            if (listaItems[k].Value == i.Value)
            {
                listaItems.RemoveAt(k);
                SaveViewState();
                break;
            }
        }
    }

    public void generarItems() 
    {
        tblItems.Rows.Clear();
        TableRow tr = new TableRow();
        TableCell celda = new TableCell();
        for (int k = 0; k < listaItems.Count; k++)
        {
            controles_controlTxtItem ct = (controles_controlTxtItem)LoadControl("controlTxtItem.ascx");
            ct.despuesDeQuitar += new EventHandler(i_despuesDeQuitar);
            ct.ID = "ctrl" + listaItems[k].Value;
            ct.Text = listaItems[k].Text;
            ct.Value = listaItems[k].Value;
            ct.mostrarBoton = this.MostrarBoton;
            ////deberiamos configurar para metros como si permite mostrar el botoon de eliminar o no
            celda.Controls.Add(ct);    
        }
        tr.Cells.Add(celda);
        tblItems.Rows.Add(tr);
    }

    protected override object SaveViewState()
    {
        object[] state = new object[this.listaItems.Count + 1];
        object basestate = base.SaveViewState();


        state[0] = basestate;
        for (int i = 0; i < this.listaItems.Count; i++)
        {
            state[i + 1] = this.listaItems[i];
        }

      

        return state;
    }

    protected override void LoadViewState(object savedState)
    {
        if (savedState == null) return;


        if (savedState is object[])
        {
            object[] state = (object[])savedState;
            base.LoadViewState(state[0]);
            for (int i = 1; i < state.Length; i++)
            {
                listaItems.Add((itemEspecial)state[i]);
            }
        }
        else
            base.LoadViewState(savedState);

    }


}
