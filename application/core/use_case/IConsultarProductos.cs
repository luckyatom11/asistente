using mercaditoutm.application.core.entities;

namespace mercaditoutm.application.core.use_case
{
    public interface IConsultarProductos
    {
        List<Articulo> Ejecutar();
    }
}