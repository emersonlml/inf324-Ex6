using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection();
        //con.ConnectionString = @"server=EMERSON\SQLEXPRESS;user=inf324;pwd=123456;database=academico";
        con.ConnectionString = @"server=EMERSON\SQLEXPRESS;user=inf324;pwd=123456;database=MIBD_ibanez";
       //gridview 1
        SqlDataAdapter ada = new SqlDataAdapter();
        ada.SelectCommand = new SqlCommand();
        ada.SelectCommand.Connection = con;
        ada.SelectCommand.CommandText = "select * from estudiante";
        ada.SelectCommand.CommandType = CommandType.Text;
        //creamos la pila deonde se guardara
        DataSet ds = new DataSet();
        ada.Fill(ds);
        //GridView1.DataSource = ds;
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();

        //gridview 2
        SqlDataAdapter ada2 = new SqlDataAdapter();
        ada2.SelectCommand = new SqlCommand();
        ada2.SelectCommand.Connection = con;
       // ada2.SelectCommand.CommandText = "select usuario.username, usuario.Rol_idRol from usuario, usuario where estudiante.usuario_id_usuario=usuario.id_usuario ";
       // ada2.SelectCommand.CommandText = "select * from usuario";
        ada2.SelectCommand.CommandText = "SELECT DISTINCT usuario.username,usuario.Rol_idRol FROM usuario INNER JOIN estudiante ON usuario.Rol_idRol=estudiante.usuario_id_usuario";
        ada2.SelectCommand.CommandType = CommandType.Text;
        //creamos la pila deonde se guardara
        DataSet ds2 = new DataSet();
        ada2.Fill(ds2);
        //GridView1.DataSource = ds;
        GridView2.DataSource = ds2.Tables[0];
        GridView2.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"server=EMERSON\SQLEXPRESS;user=inf324;pwd=123456;database=MIBD_ibanez";
       //insercion primero a la tabla usuarios donde estaran esername y passwond
        SqlCommand cmd = new SqlCommand();
        string sql = string.Empty;
        sql = sql + "insert into usuario(username,password,Rol_idRol) values('" + TextBox1.Text + "','" + TextBox2.Text + "' ,'" + TextBox3.Text + "')";
        cmd.CommandText = sql;
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"server=EMERSON\SQLEXPRESS;user=inf324;pwd=123456;database=MIBD_ibanez";
        //insercion primero a la tabla estudiante donde estaran e nombre apellido fec ncimiento y rol
        SqlCommand cmd2 = new SqlCommand();
        string sql2 = string.Empty;
        sql2 = sql2 + "insert into estudiante(nombre,apellido,genero,fech_nac,usuario_id_usuario) values('" + TextBox4.Text + "','" + TextBox5.Text + "' ,'" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')";
        cmd2.CommandText = sql2;
        cmd2.CommandType = CommandType.Text;
        cmd2.Connection = con;
        con.Open();
        cmd2.ExecuteNonQuery();
        con.Close();

    }
}