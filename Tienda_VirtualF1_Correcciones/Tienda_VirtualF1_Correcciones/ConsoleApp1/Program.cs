var lista_Usuarios = new List<Usuarios>();
lista_Usuarios.Add(new Usuarios() 
{ 
    Id = 1, 
    Codigo = "1000086252", 
    NombreCompleto = "Mariana Vargas", 
    Correo = "m056@gmail.com",
    Direccion = "Cra 12 #25-44a",
    Rol = "Admin",
    Telefono = "3110564654" 
});
lista_Usuarios.Add(new Usuarios() 
{ 
    Id = 2,
    Codigo = "1193036444", 
    NombreCompleto = "Elvis Montoya", 
    Correo = "eaas5@gmail.com",
    Direccion = "CLL 56 #13-05",
    Rol = "Cliente",
    Telefono = "3204564865"  
});
lista_Usuarios.Add(new Usuarios() 
{ 
    Id = 3, 
    Codigo = "7527726", 
    NombreCompleto = "Andres Mejia", 
    Correo = "and85@gmail.com",
    Direccion = "CLL 38 #85-05",
    Rol = "Cliente",
    Telefono = "3502456654" 
});
lista_Usuarios.Add(new Usuarios() 
{ 
    Id = 4, 
    Codigo = "6285464", 
    NombreCompleto = "Juanita Salazar", 
    Correo = "js95@gmail.com",
    Direccion = "Cra 102 #113-05a",
    Rol = "Cliente",
    Telefono = "3002565489"  
});
lista_Usuarios.Add(new Usuarios()
{ 
    Id = 5, 
    Codigo = "324156456", 
    NombreCompleto = "Diana Valderrama", 
    Correo = "dianaval@gmail.com",
    Direccion = "Cra 58 #65-64",
    Rol = "Cliente",
    Telefono = "3105454651" 
});
lista_Usuarios.Add(new Usuarios() 
{ 
    Id = 6, 
    Codigo = "4845634", 
    NombreCompleto = "Sebastian mejia", 
    Correo = "sebasm@gmail.com",
    Direccion = "Cll 78 #85-35",
    Rol = "Cliente",
    Telefono = "3158648945" 
});

var lista_Metodos_De_Pagos = new List<Metodos_De_Pagos>();
lista_Metodos_De_Pagos.Add(new Metodos_De_Pagos()
{ 
    Id = 1, 
    TipoPago = "Efectivo",
    Descripcion = "Al recibir el pedido"
});
lista_Metodos_De_Pagos.Add(new Metodos_De_Pagos()
{
    Id = 2,
    TipoPago = "Tarjeta",
    Descripcion = "Visa, Mastercard..."
});
lista_Metodos_De_Pagos.Add(new Metodos_De_Pagos()
{
    Id = 3,
    TipoPago = "Transferencia",
    Descripcion = "PSE"
});

var lista_Pedidos = new List<Pedidos>();
lista_Pedidos.Add(new Pedidos()
{
    Id = 1,
    Codigo = "P-101",
    FechaCompra = new DateTime(2025, 2, 23),
    Direccion = "CLL 56 #13-05"
});
lista_Pedidos.Add(new Pedidos()
{
    Id = 2,
    Codigo = "P-102",
    FechaCompra = new DateTime(2025, 2, 24),
    Direccion = "CLL 38 #85-05"
});
lista_Pedidos.Add(new Pedidos()
{
    Id = 3,
    Codigo = "P-103",
    FechaCompra = new DateTime(2025, 2, 24),
    Direccion = "Cra 102 #113-05a"
});
lista_Pedidos.Add(new Pedidos()
{
    Id = 4,
    Codigo = "P-104",
    FechaCompra = new DateTime(2025, 2, 27),
    Direccion = "Cra 58 #65-64"
});
lista_Pedidos.Add(new Pedidos()
{
    Id = 5,
    Codigo = "P-105",
    FechaCompra = new DateTime(2025, 3, 01),
    Direccion = "Cll 78 #85-35"
});

var lista_Envios = new List<Envios>();
lista_Envios.Add(new Envios()
{
    Id = 1,
    Codigo = "EN-101",
    _Pedido = lista_Pedidos[0],/*Relacion con la lista pedidos en la posicion que esta*/
    Tipo = "Express",
    Estado = "Entregado",
    FechaEntrega = new DateTime(2025, 2, 24)
});
lista_Envios.Add(new Envios()
{
    Id = 2,
    Codigo = "EN-102",
    _Pedido = lista_Pedidos[1],
    Tipo = "Normal",
    Estado = "Entregado",
    FechaEntrega = new DateTime(2025, 2, 28)
});
lista_Envios.Add(new Envios()
{
    Id = 3,
    Codigo = "EN-103",
    _Pedido = lista_Pedidos[2],
    Tipo = "Normal",
    Estado = "Entregado",
    FechaEntrega = new DateTime(2025, 2, 28)
});
lista_Envios.Add(new Envios()
{
    Id = 4,
    Codigo = "EN-104",
    _Pedido = lista_Pedidos[3],
    Tipo = "Normal",
    Estado = "Entregado",
    FechaEntrega = new DateTime(2025, 3, 1)
});
lista_Envios.Add(new Envios()
{
    Id = 5,
    Codigo = "EN-105",
    _Pedido = lista_Pedidos[4],
    Tipo = "Normal",
    Estado = "Enviado",
    FechaEntrega = new DateTime(2025, 3, 8)
});

var lista_Categorias = new List<Categorias>();
lista_Categorias.Add(new Categorias()
{
    Id = 1,
    Nombre = "Prendas",
    Descripcion = "Camiseta"
});
lista_Categorias.Add(new Categorias()
{
    Id = 2,
    Nombre = "Accesorios",
    Descripcion = "Gorra"
});
lista_Categorias.Add(new Categorias()
{
    Id = 3,
    Nombre = "juguetes",
    Descripcion = "Carro lego"
});
lista_Categorias.Add(new Categorias()
{
    Id = 4,
    Nombre = "Prendas",
    Descripcion = "Chaqueta"
});
lista_Categorias.Add(new Categorias()
{
    Id = 5,
    Nombre = "Accesorios",
    Descripcion = "Llavero"
});
lista_Categorias.Add(new Categorias()
{
    Id = 6,
    Nombre = "Accesorios",
    Descripcion = "Termo personalizado" 
});
lista_Categorias.Add(new Categorias()
{
    Id = 7,
    Nombre = "Accesorios",
    Descripcion = "Cuadro personalizado"
});

var lista_Productos = new List<Productos>();
lista_Productos.Add(new Productos()
{
    Id = 1,
    Nombre = "Camiseta",
    Precio = 300000,
    Talla = "L",
    _Categoria = lista_Categorias[0],
    Material = "Algodon"
});
lista_Productos.Add(new Productos()
{
    Id = 2,
    Nombre = "Gorra",
    Precio = 250000,
    Talla = "L",
    _Categoria = lista_Categorias[1],
    Material = "Algodon"
});
lista_Productos.Add(new Productos()
{
    Id = 3,
    Nombre = "Carro lego",
    Precio = 500000,
    Talla = null,
    _Categoria = lista_Categorias[2],
    Material = "Plastico"
});
lista_Productos.Add(new Productos()
{
    Id = 4,
    Nombre = "Chaqueta",
    Precio = 800000,
    Talla = "XL",
    _Categoria = lista_Categorias[3],
    Material = "Cuero"
});
lista_Productos.Add(new Productos()
{
    Id = 5,
    Nombre = "Llavero",
    Precio = 50000,
    Talla = null,
    _Categoria = lista_Categorias[4],
    Material = "Metal"
});
lista_Productos.Add(new Productos()
{
    Id = 6,
    Nombre = "Termo personalizado",
    Precio = 50000,
    Talla = "500ml",
    _Categoria = lista_Categorias[5],
    Material = "Acero"
});
lista_Productos.Add(new Productos()
{
    Id = 7,
    Nombre = "Cuadro personalizado",
    Precio = 80000,
    Talla = null,
    _Categoria = lista_Categorias[6],
    Material = "Madera/Vidrio"
});

var lista_Facturas = new List<Facturas>();
lista_Facturas.Add(new Facturas()
{
    Id = 1,
    Codigo = "F-101",
    FechaCompra = new DateTime(2025, 2, 23),
    _Pedido = lista_Pedidos[0],
    _Usuario = lista_Usuarios[1],
    _Metodos_De_Pago = lista_Metodos_De_Pagos[1],
    Estado = "Pagado",
    Total = 850000
});
lista_Facturas.Add(new Facturas()
{
    Id = 2,
    Codigo = "F-103",
    FechaCompra = new DateTime(2025, 2, 24),
    _Pedido = lista_Pedidos[1],
    _Usuario = lista_Usuarios[2],
    _Metodos_De_Pago = lista_Metodos_De_Pagos[0],
    Estado = "Pagado",
    Total = 1300000
});
lista_Facturas.Add(new Facturas()
{
    Id = 3,
    Codigo = "F-104",
    FechaCompra = new DateTime(2025, 2, 24),
    _Pedido = lista_Pedidos[2],
    _Usuario = lista_Usuarios[3],
    _Metodos_De_Pago = lista_Metodos_De_Pagos[2],
    Estado = "Pagado",
    Total = 1300000
});
lista_Facturas.Add(new Facturas()
{
    Id = 4,
    Codigo = "F-105",
    FechaCompra = new DateTime(2025, 2, 27),
    _Pedido = lista_Pedidos[3],
    _Usuario = lista_Usuarios[4],
    _Metodos_De_Pago = lista_Metodos_De_Pagos[2],
    Estado = "Pagado",
    Total = 150000
});
lista_Facturas.Add(new Facturas()
{
    Id = 5,
    Codigo = "F-106",
    FechaCompra = new DateTime(2025, 3, 1),
    _Pedido = lista_Pedidos[4],
    _Usuario = lista_Usuarios[5],
    _Metodos_De_Pago = lista_Metodos_De_Pagos[0],
    Estado = "Pendiente",
    Total = 80000
});

var lista_Productos_Facturas = new List<Productos_Facturas>();
lista_Productos_Facturas.Add(new Productos_Facturas()
{
    Id = 1,
    _Factura = lista_Facturas[0],
    _Producto = lista_Productos[0],
    Cantidad = 2,
    IVA = 0.6m,
    PrecioUnitario = 300000,
    Total = 600000
});
lista_Productos_Facturas.Add(new Productos_Facturas()
{
    Id = 2,
    _Factura = lista_Facturas[0],
    _Producto = lista_Productos[1],
    Cantidad = 1,
    IVA = 0.6m,
    PrecioUnitario = 250000,
    Total = 250000
});
lista_Productos_Facturas.Add(new Productos_Facturas()
{
    Id = 3,
    _Factura = lista_Facturas[1],
    _Producto = lista_Productos[2],
    Cantidad = 1,
    IVA = 0.6m,
    PrecioUnitario = 500000,
    Total = 500000
});
lista_Productos_Facturas.Add(new Productos_Facturas()
{
    Id = 4,
    _Factura = lista_Facturas[1],
    _Producto = lista_Productos[3],
    Cantidad = 1,
    IVA = 0.6m,
    PrecioUnitario = 800000,
    Total = 800000
});
lista_Productos_Facturas.Add(new Productos_Facturas()
{
    Id = 5,
    _Factura = lista_Facturas[2],
    _Producto = lista_Productos[4],
    Cantidad = 5,
    IVA = 0.6m,
    PrecioUnitario = 50000,
    Total = 250000
});
lista_Productos_Facturas.Add(new Productos_Facturas()
{
    Id = 6,
    _Factura = lista_Facturas[3],
    _Producto = lista_Productos[5],
    Cantidad = 3,
    IVA = 0.6m,
    PrecioUnitario = 50000,
    Total = 150000
});
lista_Productos_Facturas.Add(new Productos_Facturas()
{
    Id = 7,
    _Factura = lista_Facturas[4],
    _Producto = lista_Productos[6],
    Cantidad = 1,
    IVA = 0.6m,
    PrecioUnitario = 80000,
    Total = 80000
});

// Asociar productos con facturas
lista_Facturas[0].ProductosFactura.Add(lista_Productos_Facturas[0]);
lista_Facturas[0].ProductosFactura.Add(lista_Productos_Facturas[1]);
lista_Facturas[1].ProductosFactura.Add(lista_Productos_Facturas[2]);
lista_Facturas[1].ProductosFactura.Add(lista_Productos_Facturas[3]);
lista_Facturas[2].ProductosFactura.Add(lista_Productos_Facturas[4]);
lista_Facturas[3].ProductosFactura.Add(lista_Productos_Facturas[5]);
lista_Facturas[4].ProductosFactura.Add(lista_Productos_Facturas[6]);

// Mostrar datos en consola
foreach (var factura in lista_Facturas)
{
Console.WriteLine($"Cliente: {factura._Usuario.NombreCompleto}");
Console.WriteLine($"Factura: {factura.Codigo} | Total: {factura.Total:C}");
Console.WriteLine($"Metodo de pago: {factura._Metodos_De_Pago.TipoPago}");
Console.WriteLine("Productos comprados:");

foreach (var item in factura.ProductosFactura)
{
    Console.WriteLine($"- {item._Producto.Nombre} | Cantidad: {item.Cantidad} | Total: {item.Total:C}");
}
Console.WriteLine();
}

/*Console.WriteLine(lista_Usuarios.Count);
Console.WriteLine(lista_Metodos_De_Pagos.Count);
Console.WriteLine(lista_Pedidos.Count);
Console.WriteLine(lista_Envios.Count);
Console.WriteLine(lista_Categorias.Count);
Console.WriteLine(lista_Productos.Count);
Console.WriteLine(lista_Facturas.Count);
Console.WriteLine(lista_Productos_Facturas.Count);*/

public class Usuarios
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public string NombreCompleto { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public string Rol { get; set; }
    public string Telefono { get; set; }
    public int Pedido { get; set; }
    public Pedidos? _Pedido { get; set; }
}

public class Pedidos
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public DateTime FechaCompra { get; set; }
    public string Direccion { get; set; }
    public int Envio {get;set;}
    public Envios? _Envio { get; set; }
}

public class Envios
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public int Pedido { get; set; }
    public string Tipo { get; set; }
    public string Estado { get; set; }
    public DateTime FechaEntrega { get; set; }
    public Pedidos? _Pedido { get; set; }
}

public class Facturas
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public DateTime FechaCompra { get; set; }
    public int Pedido { get; set; }
    public int Usuario { get; set; }
    public int Metodos_De_Pago { get; set; }
    public string Estado { get; set; }
    public decimal Total { get; set; }
    public Pedidos? _Pedido { get; set; }
    public Usuarios? _Usuario { get; set; }
    public Metodos_De_Pagos? _Metodos_De_Pago { get; set; }
    public List<Productos_Facturas> ProductosFactura { get; set; } = new List<Productos_Facturas>();

}

public class Metodos_De_Pagos
{
    public int Id { get; set; }
    public string TipoPago { get; set; }
    public string Descripcion { get; set; }
}

public class Productos
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Talla { get; set; }
    public int Categoria { get; set; }
    public string Material { get; set; }
    public Categorias? _Categoria { get; set; }
}

public class Categorias
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
}

public class Productos_Facturas
{
    public int Id { get; set; }
    public int Factura { get; set; }
    public int Producto { get; set; }
    public int Cantidad { get; set; }
    public decimal IVA { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Total { get; set; }
    public Productos? _Producto {get; set;}
    public Facturas? _Factura {get; set;}
}
