namespace Productos.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }

        public string Descripción { get; set; }
        public string Precio { get; set; }
        public int Celular { get; set; }
        public string Lugar { get; set; }
        public string Categoria { get; set; }
    }
}