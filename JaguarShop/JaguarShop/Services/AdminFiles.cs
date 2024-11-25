using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarShop.Services
{
    public class AdminFiles
    {
        private readonly string _filePath;

        public AdminFiles(string filePath)
        {
            _filePath = filePath;
        }

        /// Verifica si un correo ya está registrado en el archivo.
        public bool IsEmailRegistered(string email)
        {
            if (!File.Exists(_filePath))
                return false;

            return File.ReadAllLines(_filePath).Any(line => line.Contains("Correo: " + email.Trim()));
        }

        /// Registra un usuario en el archivo.
        public void RegisterAdmin(string FullName, string email, string Cif, string password)
        {
            // Generar ID único
            string adminId = GenerateUniqueUserId();

            // Encriptar contraseña
            string encryptedPassword = EncryptPassword(password);

            // Guardar datos
            SaveAdmin(adminId, FullName, email, Cif, encryptedPassword);
        }

        /// Genera un ID único para el usuario.
        private string GenerateUniqueUserId()
        {
            Random random = new Random();
            string userId;
            do
            {
                userId = "ADM" + random.Next(10000, 99999);
            } while (File.Exists(_filePath) && File.ReadAllLines(_filePath).Any(line => line.Contains("ID: " + adminId)));

            return userId;
        }

        /// Encripta una contraseña usando Base64.
        private string EncryptPassword(string password)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }

        /// Guarda los datos del usuario en el archivo.
        private void SaveAdmin(string adminId, string FullName, string email, string Cif, string encryptedPassword)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine("-------------------------------");
                writer.WriteLine("ID: " + adminId); // Guardar el ID único
                writer.WriteLine("Nombre Completo: " + FullName.Trim());
                writer.WriteLine("Correo: " + email.Trim());
                writer.WriteLine("Cif: " + Cif);
                writer.WriteLine("Contraseña: " + encryptedPassword); // Contraseña encriptada
                writer.WriteLine("-------------------------------");
            }
        }
    }
}
