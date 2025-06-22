// string diretorio = "diretorio-aux";
// string arquivoSemExtensao = "arquivo";

// string path = Path.Combine(diretorio, arquivoSemExtensao);

// ArquivosDiretoriosStreams arquivosDiretoriosStreams = new();
// arquivosDiretoriosStreams.EscreverDocumento(path);
// arquivosDiretoriosStreams.LerDocumento(path);

// path = Path.Combine(diretorio, arquivoSemExtensao);
// Usuario usuario = new("NOME");

// SerializadorJson serializadorJson = new();
// serializadorJson.SerializarJson(path, usuario);
// serializadorJson.DeserializarJson(path, usuario.GetType());

// Classe classe1 = new(true);
// Classe classe2 = new(true);
// Classe classe3 = new(true);

// classe1.TestarArgumentosPorValor();
// classe1.TestarArgumentosPorReferencia();

// Enum testeEnum = new();
// testeEnum.TestarEnum();

// TratamentoDeErros t = new();
// t.TestarTryCatch();

// RepeticaoGotoLabel r = new();
// r.TestarRepeticaoGotoLabel();

// RepeticaoWhile r = new();
// r.TestarWhile();

// RepeticaoFor r = new();
// r.TestarRepeticaoFor();

// TesteArray t = new();
// t.TestarArrayBidimensional();
// t.TestarArrayUnidimensional();
// t.TestarClasseArray();

// TesteArrayList t = new();
// t.TestarArrayList();

// TesteList t = new();
// t.TestarList();

// TratamentoDeErros t = new();
// t.TestarNovaExcecao();

// Eventos e = new();
// e.TestarEventoNotificacao();

BaseAssincrona b = new();
b.TestarMetodoSincrono();

Console.ReadKey();

// Console.ReadLine();