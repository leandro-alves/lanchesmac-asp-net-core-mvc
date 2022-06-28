using LanchesMac.Context;

namespace LanchesMac.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;

        //Injeta o contexto no construtor
        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            //Define uma sessão
            ISession session = 
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //Obtém um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            //Obtém ou gera o Id do carrinho
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            //Atribui o Id do carrinho na sessão
            session.SetString("CarrinhoId", carrinhoId);

            //Retorna o carrinho com o contexto e o Id abribuído ou obtido
            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };
        }

        public void AdicionarAoCarrinho(CarrinhoCompraItem carrinhoCompraItem)
        {

        }

        public void RemoverDoCarrinho(int carrinhoCompraItemId)
        {

        }

        public void GetCarrinhoCompraItens()
        {

        }

        public void LimparCarrinho()
        {

        }

        public void GetCarrinhoCompraTotal()
        {

        }
    }
}
