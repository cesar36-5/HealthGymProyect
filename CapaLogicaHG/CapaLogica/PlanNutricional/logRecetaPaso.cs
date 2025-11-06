using CapaDatosHG.CapaDatoss;
using CapaEntidadHG.CapaEntidad.PlanNutricional;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;


namespace CapaLogicaHG.PlanNutricional
{
   
    public class logRecetaPaso
    {
        #region Singleton
      
        private static readonly logRecetaPaso _instancia = new logRecetaPaso();

        
        public static logRecetaPaso Instancia
        {
            get { return _instancia; }
        }
        
        #endregion Singleton

        #region Metodos

        /// <summary>
        /// Lista todos los pasos de una receta específica, ordenados por NumeroPaso.
        /// </summary>
        /// <param name="recetaID">El ID de la receta a consultar</param>
        /// <returns>Una lista de objetos entRecetaPaso</returns>
        public List<entRecetaPaso> ListarPasosPorReceta(int recetaID)
        {
            List<entRecetaPaso> pasos = new List<entRecetaPaso>();
            string query = "SELECT PasoID, RecetaID, NumeroPaso, Instruccion FROM Receta_Paso WHERE RecetaID = @RecetaID ORDER BY NumeroPaso";

            // Usamos TU clase de conexión (desde CapaDatosHG.CapaDatoss.Conexion)
            // ¡CORREGIDO! Es Conectar() con una 'n'
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                // --- ¡CORRECCIÓN! ---
                // Tu método Conectar() solo devuelve la conexión, debemos abrirla.
                conn.Open();
                // --- FIN CORRECCIÓN ---

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RecetaID", recetaID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pasos.Add(new entRecetaPaso
                            {
                                PasoID = Convert.ToInt32(reader["PasoID"]),
                                RecetaID = Convert.ToInt32(reader["RecetaID"]),
                                NumeroPaso = Convert.ToInt32(reader["NumeroPaso"]),
                                Instruccion = reader["Instruccion"].ToString()
                            });
                        }
                    }
                }
            } // La conexión se cierra sola aquí (por el 'using')
            return pasos;
        }

        /// <summary>
        /// Inserta un nuevo paso para una receta. 
        /// Automáticamente calcula el siguiente NumeroPaso.
        /// </summary>
        /// <param name="paso">El objeto entRecetaPaso a insertar</param>
        /// <returns>True si fue exitoso</returns>
        public bool InsertarPaso(entRecetaPaso paso)
        {
            // ¡CORREGIDO! Es Conectar() con una 'n'
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                // --- ¡CORRECCIÓN! ---
                conn.Open();
                // --- FIN CORRECCIÓN ---

                // 1. Obtener el siguiente número de paso
                string queryNum = "SELECT ISNULL(MAX(NumeroPaso), 0) + 1 FROM Receta_Paso WHERE RecetaID = @RecetaID";
                int nuevoNumeroPaso;
                using (SqlCommand cmdNum = new SqlCommand(queryNum, conn))
                {
                    cmdNum.Parameters.AddWithValue("@RecetaID", paso.RecetaID);
                    nuevoNumeroPaso = (int)cmdNum.ExecuteScalar();
                }

                // 2. Insertar el nuevo paso
                string queryInsert = "INSERT INTO Receta_Paso (RecetaID, NumeroPaso, Instruccion) VALUES (@RecetaID, @NumeroPaso, @Instruccion)";
                using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@RecetaID", paso.RecetaID);
                    cmdInsert.Parameters.AddWithValue("@NumeroPaso", nuevoNumeroPaso);
                    cmdInsert.Parameters.AddWithValue("@Instruccion", paso.Instruccion);
                    return cmdInsert.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Actualiza solo la instrucción de un paso existente.
        /// </summary>
        /// <param name="pasoID">El ID del paso a modificar</param>
        /// <param name="instruccion">El nuevo texto de la instrucción</param>
        /// <returns>True si fue exitoso</returns>
        public bool ActualizarInstruccionPaso(int pasoID, string instruccion)
        {
            string query = "UPDATE Receta_Paso SET Instruccion = @Instruccion WHERE PasoID = @PasoID";
            // ¡CORREGIDO! Es Conectar() con una 'n'
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                // --- ¡CORRECCIÓN! ---
                conn.Open();
                // --- FIN CORRECCIÓN ---

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Instruccion", instruccion);
                    cmd.Parameters.AddWithValue("@PasoID", pasoID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Elimina un paso de la base de datos.
        /// </summary>
        /// <param name="pasoID">El ID del paso a eliminar</param>
        /// <returns>True si fue exitoso</returns>
        public bool EliminarPaso(int pasoID)
        {
            string query = "DELETE FROM Receta_Paso WHERE PasoID = @PasoID";
            // ¡CORREGIDO! Es Conectar() con una 'n'
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                // --- ¡CORRECCIÓN! ---
                conn.Open();
                // --- FIN CORRECCIÓN ---

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PasoID", pasoID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Re-numera secuencialmente todos los pasos de una receta.
        /// (Se usa después de eliminar un paso).
        /// </summary>
        /// <param name="recetaID">El ID de la receta a reordenar</param>
        public void ReordenarPasos(int recetaID)
        {
            // Esta consulta usa CTEs (Common Table Expressions) para re-numerar
            string query = @"
                WITH PasosOrdenados AS (
                    SELECT PasoID, ROW_NUMBER() OVER (ORDER BY NumeroPaso) AS NuevoNumero
                    FROM Receta_Paso
                    WHERE RecetaID = @RecetaID
                )
                UPDATE Receta_Paso
                SET NumeroPaso = po.NuevoNumero
                FROM Receta_Paso p
                JOIN PasosOrdenados po ON p.PasoID = po.PasoID
                WHERE p.RecetaID = @RecetaID;";

            // ¡CORREGIDO! Es Conectar() con una 'n'
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                // --- ¡CORRECCIÓN! ---
                conn.Open();
                // --- FIN CORRECCIÓN ---

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RecetaID", recetaID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Intercambia los NumeroPaso de dos pasos. (Para Subir/Bajar).
        /// </summary>
        /// <returns>True si fue exitoso</returns>
        public bool IntercambiarPasos(int recetaID, int pasoIDActual, int numeroPasoActual, int numeroPasoDestino)
        {
            // ¡CORREGIDO! Es Conectar() con una 'n'
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                // --- ¡CORRECCIÓN! ---
                conn.Open();
                // --- FIN CORRECCIÓN ---

                // Usamos una transacción para asegurar que ambos updates se hagan
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    // 1. Mover el paso destino (ej. el 3) al número del paso actual (ej. el 4)
                    string query1 = "UPDATE Receta_Paso SET NumeroPaso = @numActual WHERE RecetaID = @recetaID AND NumeroPaso = @numDestino";
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn, tran))
                    {
                        cmd1.Parameters.AddWithValue("@numActual", numeroPasoActual);
                        cmd1.Parameters.AddWithValue("@recetaID", recetaID);
                        cmd1.Parameters.AddWithValue("@numDestino", numeroPasoDestino);
                        cmd1.ExecuteNonQuery();
                    }

                    // 2. Mover el paso actual (ej. el 4) al número destino (ej. el 3)
                    string query2 = "UPDATE Receta_Paso SET NumeroPaso = @numDestino WHERE PasoID = @pasoIDActual";
                    using (SqlCommand cmd2 = new SqlCommand(query2, conn, tran))
                    {
                        cmd2.Parameters.AddWithValue("@numDestino", numeroPasoDestino);
                        cmd2.Parameters.AddWithValue("@pasoIDActual", pasoIDActual);
                        cmd2.ExecuteNonQuery();
                    }

                    tran.Commit(); // Confirmar los cambios
                    return true;
                }
                catch (Exception)
                {
                    tran.Rollback(); // Revertir si algo falló
                    return false;
                }
            }
        }

        #endregion Metodos
    }
}