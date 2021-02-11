using Capacitacion.Core.Suma;
using System.Threading.Tasks;

namespace Capacitacion.Infraestructura.Transversal.GenericMethods
{
    public interface IHttpBaseClientGenericMethods
    {
        Task<T> Get<T>(string path, string request) where T : OperacionDto;
        Task<T> Post<T>(string path, T request) where T : OperacionDto;
        T Put<T>(string path, T request) where T : OperacionDto;
        T Patch<T>(string path, T request) where T : OperacionDto;
    }
}
