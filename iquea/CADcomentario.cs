
using System;
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
            String orden = "Insert Into iquea.comentario (id, comentario, valoracion) VALUES ('" + comentario.idP + "' , '" + comentario.comentarioP + "' , '" + comentario.valoracionP + ")";
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
            SqlCommand comando = new SqlCommand("Select * from iquea.comentario where id = '" + comentario.idP + "'", a);
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

    public bool readComentario_datos(ENcomentario comentario)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);

        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("Select * from iquea.comentario where comentario = '" + comentario.comentarioP + "' and valoracion="+comentario.valoracionP, a);
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
            SqlCommand comando = new SqlCommand("DELETE FROM iquea.comentario WHERE id = '" + comentario.idP + "'", a);
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
            SqlCommand comando = new SqlCommand("UPDATE iquea.comentario SET comentario = '" + comentario.comentarioP + "' , valoracion = '" + comentario.valoracionP + "' WHERE id = '" + comentario.idP + "'", a);
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

    public bool readFirstComentario(ENcomentario comentario,int id)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);

        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("Select * from iquea.comentario where comentario.id=articulo.id and articulo.id="+id, a);
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
            SqlCommand comando = new SqlCommand("Select * from iquea.comentario where comentario.id=articulo.id and articulo.id=" + id, a);
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
            SqlCommand comando = new SqlCommand("Select * from iquea.comentario where comentario.id=articulo.id and articulo.id=" + id, a);
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