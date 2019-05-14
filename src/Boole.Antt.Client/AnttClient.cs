using antt.gov.br.monitriip.v1._0;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Boole.Antt.Client
{
    public class MonitriipClient : HttpClient, IMonitriipClient
    {

        protected string  URL_HOMOLOGACAO_BASE = "http://appservices.antt.gov.br:8000/antt/monitriip.validacao/rest/";


        public MonitriipClient(string token)
        {

            Timeout = new TimeSpan(0, 0, 3);
            BaseAddress = new Uri(URL_HOMOLOGACAO_BASE);
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
        }

        public MonitriipClient(string urlBase, string token)
        {

            Timeout = new TimeSpan(0, 0, 3);
            BaseAddress = new Uri(urlBase);
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
        }

        public MonitriipClient(int timeout, string urlBase, string token)
        {
           
            Timeout = (timeout > 0) ? new TimeSpan(0, 0, timeout) : new TimeSpan(0, 0, 3);
            BaseAddress = new Uri(urlBase);
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
        }

        public async Task<resultadoOperacao> InserirLogBilheteEmbarque(bilheteEmbarque bilheteEmbarque)
        {
            var res = this.PostAsXmlAsync("InserirLogBilheteEmbarque", bilheteEmbarque);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogCancelarPassagem(cancelarPassagem cancelamentoPassagem)
        {
            var res = this.PostAsXmlAsync("InserirLogCancelarPassagem", cancelamentoPassagem);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogCartaoEmitidoRecargaEfetuada(cartaoEmitidoRecargaEfetuada cartaoEmitidoRecargaEfetuada)
        {
            var res = this.PostAsXmlAsync("InserirLogCartaoEmitidoRecargaEfetuada", cartaoEmitidoRecargaEfetuada);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogDetectorParada(detectorParada detectorParada)
        {
            var res = this.PostAsXmlAsync("InserirLogDetectorParada", detectorParada);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogInicioFimViagemFretado(inicioFimViagemFretado inicioFimViagemFretado)
        {
            var res = this.PostAsXmlAsync("InserirLogInicioFimViagemFretado", inicioFimViagemFretado);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogInicioFimViagemRegular(inicioFimViagemRegular inicioFimViagemRegular)
        {
            var res = this.PostAsXmlAsync("InserirLogInicioFimViagemRegular", inicioFimViagemRegular);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogJornadaTrabalhoMotorista(jornadaTrabalhoMotorista jornadaTrabalhoMotorista)
        {
            var res = this.PostAsXmlAsync("InserirLogJornadaTrabalhoMotorista", jornadaTrabalhoMotorista);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogLeitorCartaoRFID(leitorCartaoRFID cartaoRFID)
        {
            var res = this.PostAsXmlAsync("InserirLogLeitorCartaoRFID", cartaoRFID);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogRegistroOcorrenciaRodoviario(registroOcorrenciaRodoviario ocorrencia)
        {
            var res = this.PostAsXmlAsync("InserirLogRegistroOcorrenciaRodoviario", ocorrencia);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogRegistroOcorrenciaSemiUrbano(registroOcorrenciaSemiurbano ocorrencia)
        {
            var res = this.PostAsXmlAsync("InserirLogRegistroOcorrenciaSemiUrbano", ocorrencia);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogVelocidadeTempoLocalizacao(velocidadeTempoLocalizacao velocidadeTempoLocalizacao)
        {
            var res = this.PostAsXmlAsync("InserirLogVelocidadeTempoLocalizacao", velocidadeTempoLocalizacao);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }

        public async Task<resultadoOperacao> InserirLogVendaPassagem(vendaPassagem passagem)
        {
            var res = this.PostAsXmlAsync("InserirLogVendaPassagem", passagem);
            return await res.Result.Content.ReadAsAsync<resultadoOperacao>();
        }
    }
}
