<<<<<<< HEAD

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
=======
﻿
using System;
>>>>>>> develop
using System.Configuration;
using System.Data.SqlClient;

public class CADcomentario
{
    private string constring;

    public CADcomentario()
    {
        constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
    }

    public bool createComentario(ENcomentario comentario)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);
        try
        {
            a.Open();
<<<<<<< HEAD
            String orden = "Insert Into dbo.comentario (id, comentario, valoracion) VALUES ('" + comentario.idP + "' , '" + comentario.comentarioP + "' , '" + comentario.valoracionP + ")";
=======
            String orden = "Insert Into dbo.comentario (id, comentario, valoracion,Articulo_id,Usuario_correo) VALUES (" + comentario.idP + " , '" + comentario.comentarioP + "' , " + comentario.valoracionP +" , "+ comentario.Articulo_idP +" ,'"+comentario.Usuario_correoP+ "')";
>>>>>>> develop
            SqlCommand comando = new SqlCommand(orden, a);
            comando.ExecuteNonQuery();

            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }

    public bool readComentario(ENcomentario comentario)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);

        try
        {
            a.Open();
<<<<<<< HEAD
            SqlCommand comando = new SqlCommand("Select * from dbo.comentario where id = '" + comentario.idP + "'", a);
=======
            SqlCommand comando = new SqlCommand("Select * from dbo.comentario where id = " + comentario.idP , a);
>>>>>>> develop
            SqlDataReader dr = comando.ExecuteReader();

            dr.Read();
            comentario.comentarioP = dr["comentario"].ToString();
            comentario.valoracionP = Convert.ToInt32(dr["valoracion"]);
            comentario.Articulo_idP = Convert.ToInt32(dr["Articulo_id"]);
            comentario.Usuario_correoP = dr["Usuario_correo"].ToString();

            dr.Close();
            a.Close();
            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }

    public bool readComentario_datos(ENcomentario comentario)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);

        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("Select * from dbo.comentario where comentario = '" + comentario.comentarioP + "' and valoracion="+comentario.valoracionP, a);
            SqlDataReader dr = comando.ExecuteReader();

            dr.Read();
            comentario.idP = Convert.ToInt32(dr["id"]);

            dr.Close();
            a.Close();
            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }

    public bool deleteComentario(ENcomentario comentario)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);
        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("DELETE FROM dbo.comentario WHERE id = '" + comentario.idP + "'", a);
            comando.ExecuteNonQuery();

            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }

    public bool updateComentario(ENcomentario comentario)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);
        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("UPDATE dbo.comentario SET comentario = '" + comentario.comentarioP + "' , valoracion = '" + comentario.valoracionP + "' WHERE id = '" + comentario.idP + "'", a);
            comando.ExecuteNonQuery();

            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }

<<<<<<< HEAD
}

}

=======
    public bool readFirstComentario(ENcomentario comentario,int id)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);

        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("Select * from dbo.comentario where comentario.Articulo_id=" + id, a);
            SqlDataReader dr = comando.ExecuteReader();

            dr.Read();
            comentario.comentarioP = dr["comentario"].ToString();
            comentario.valoracionP = Convert.ToInt32(dr["valoracion"]);

            dr.Close();
            a.Close();
            respuesta = true;

        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }

    public bool readNextComentario(ENcomentario comentario, int id)
    {
        bool respuesta = false;
        bool unavez = false;
        ENcomentario aux = new ENcomentario();
        SqlConnection a = new SqlConnection(constring);

        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("Select * from dbo.comentario where comentario.Articulo_id=" + id, a);
            SqlDataReader dr = comando.ExecuteReader();

            aux.idP = 0;
            while (dr.Read())
            {
                if (comentario.idP == aux.idP)
                {
                    if (unavez == false)
                    { 
                        comentario.idP= Convert.ToInt32(dr["id"]);
                        comentario.comentarioP = dr["comentario"].ToString();
                        comentario.valoracionP = Convert.ToInt32(dr["valoracion"]);
                        unavez = true;
                    }
                }
                aux.idP = Convert.ToInt32(dr["id"]);
                aux.comentarioP = dr["comentario"].ToString();
                aux.valoracionP = Convert.ToInt32(dr["valoracion"]);

            }

            dr.Close();
            a.Close();
            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }

    public bool readPrevComentario(ENcomentario comentario, int id)
    {
        bool respuesta = false;
        bool unavez = false;
        ENcomentario aux = new ENcomentario();
        SqlConnection a = new SqlConnection(constring);

        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("Select * from dbo.comentario where comentario.Articulo_id=" + id, a);
            SqlDataReader dr = comando.ExecuteReader();

            aux.idP = 0;
            while (dr.Read())
            {
                if (comentario.idP == Convert.ToInt32(dr["id"]))
                {
                    if (unavez == false)
                    {
                        comentario.idP = Convert.ToInt32(dr["id"]);
                        comentario.comentarioP = dr["comentario"].ToString();
                        comentario.valoracionP = Convert.ToInt32(dr["valoracion"]);
                        unavez = true;
                    }
                }
                aux.idP = Convert.ToInt32(dr["id"]);
                aux.comentarioP = dr["comentario"].ToString();
                aux.valoracionP = Convert.ToInt32(dr["valoracion"]);


            }

            dr.Close();
            a.Close();
            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }
}
>>>>>>> develop
