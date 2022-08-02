using NerdStore.BDD.Tests.Config;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace NerdStore.BDD.Tests.Pedido
{
    [Binding]
    [CollectionDefinition(nameof(AutomacaoWebFixtureCollection))]
    public class Pedido_AdicionarItemAoCarrinhoStepDefinitions
    { 
        private readonly AutomacaoWebTestsFixture _testsFixture;
        private readonly PedidoTela _pedidoTela;

        private string _urlProduto;

        public Pedido_AdicionarItemAoCarrinhoStepDefinitions(AutomacaoWebTestsFixture testsFixture)
        {
            _testsFixture = testsFixture;
            _pedidoTela = new PedidoTela(testsFixture.BrowserHelper);

        
        }

        [Given(@"Que um produto esteja na vitrine")]
        public void GivenQueUmProdutoEstejaNaVitrine()
        {
            //Arrange
            _pedidoTela.AcessarVitrineDeProdutos();

            //Act
            _pedidoTela.ObterDetalhesDoProduto();
            _urlProduto = _pedidoTela.ObterUrl();

            //Assert
            Assert.True(_pedidoTela.ValidarProdutoDisponivel());           


        }

        [Given(@"Esteja disponível no estoque")]
        public void GivenEstejaDisponivelNoEstoque()
        {
           //Arrange

           //Act

           //Assert
        }

        [Given(@"O usuário esteja logado")]
        public void GivenOUsuarioEstejaLogado()
        {
                //Arrange

                //Act

                //Assert
        }

        [When(@"O usuário adicionar uma unidade ao carrinho")]
        public void WhenOUsuarioAdicionarUmaUnidadeAoCarrinho()
        {
                //Arrange

                //Act

                //Assert
        }

        [Then(@"O usuário será redirecionado ao resumo da compra")]
        public void ThenOUsuarioSeraRedirecionadoAoResumoDaCompra()
        {
                //Arrange

                //Act

                //Assert
        }

        [Then(@"O valor total do pedido será exatamente o valor do item adicionado")]
        public void ThenOValorTotalDoPedidoSeraExatamenteOValorDoItemAdicionado()
        {
            //Arrange

            //Act

            //Assert
        }

        [When(@"O usuário adicionar um item acima da quantidade máxima permitida")]
        public void WhenOUsuarioAdicionarUmItemAcimaDaQuantidadeMaximaPermitida()
        {
            //Arrange

            //Act

            //Assert
        }

        [Then(@"Receberá uma mensagem de erro mencionando que foi ultrapassada a quantidade limite")]
        public void ThenReceberaUmaMensagemDeErroMencionandoQueFoiUltrapassadaAQuantidadeLimite()
        {
            //Arrange

            //Act

            //Assert
        }

        [Given(@"O mesmo produto já tenha sido adicionado ao carrinho anteriomente")]
        public void GivenOMesmoProdutoJaTenhaSidoAdicionadoAoCarrinhoAnteriomente()
        {
            //Arrange

            //Act

            //Assert
        }

        [Then(@"A quantidade de itens daquele produto terá sido acrescida em uma unidade a mais")]
        public void ThenAQuantidadeDeItensDaqueleProdutoTeraSidoAcrescidaEmUmaUnidadeAMais()
        {
            //Arrange

            //Act

            //Assert
        }

        [Then(@"O valor total do pedido será a multiplicação da quantidade de itens pelo valor unitário")]
        public void ThenOValorTotalDoPedidoSeraAMultiplicacaoDaQuantidadeDeItensPeloValorUnitario()
        {
            //Arrange

            //Act

            //Assert
        }

        [Given(@"E esteja disponível no estoque")]
        public void GivenEEstejaDisponivelNoEstoque()
        {
            //Arrange

            //Act

            //Assert
        }

        [Given(@"O mesmo produto já tenha sido adicionado ao carrinho anteriormente")]
        public void GivenOMesmoProdutoJaTenhaSidoAdicionadoAoCarrinhoAnteriormente()
        {
            //Arrange

            //Act

            //Assert
        }

        [When(@"O usuário adicionar q quantidade máxima permitida ao carrinho")]
        public void WhenOUsuarioAdicionarQQuantidadeMaximaPermitidaAoCarrinho()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
