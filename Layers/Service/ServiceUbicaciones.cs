using ComputerStore.Layers.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ComputerStore.Layers.Service
{
     class ServiceUbicaciones
    {
        

        public static async Task<List<ProvinciaJson>> GetProvincias()
        {
            string path = @"https://api.pruebayerror.com/locaciones/v1/provincias";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(path);
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();
                    RootProvincia root = JSONGenericObject<RootProvincia>.JSonToObject(json);
                    return root.data.ToList();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error al obtener las provincias: {ex.Message}");
                return null;
            }
        }



    }
}
