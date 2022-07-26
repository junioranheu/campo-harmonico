List<string> campoHarmonicoA = new(new string[] { "A", "Bm", "C#m", "D", "E", "F#m" });
List<string> campoHarmonicoB = new(new string[] { "B", "C#m", "D#m", "E", "F#", "G#m" });
List<string> campoHarmonicoC = new(new string[] { "C", "Dm", "Em", "F", "G", "Am" });
List<string> campoHarmonicoD = new(new string[] { "D", "Em", "F#m", "G", "A", "Bm" });
List<string> campoHarmonicoE = new(new string[] { "E", "F#m", "G#m", "A", "B", "C#m" });
List<string> campoHarmonicoF = new(new string[] { "F", "Gm", "Am", "A#", "C", "Dm" });
List<string> campoHarmonicoG = new(new string[] { "G", "Am", "Bm", "C", "D", "Em" });
List<List<string>> listaCamposHarmonicos = new(new List<string>[] { campoHarmonicoA, campoHarmonicoB, campoHarmonicoC, campoHarmonicoD, campoHarmonicoE, campoHarmonicoF, campoHarmonicoG });
int pontos = 0;

foreach (var campo in listaCamposHarmonicos)
{
    string tom = campo[0];
    campo.RemoveAt(0);
    Console.WriteLine($"\nCampo harmônico de {tom}");

    foreach (var nota in campo.ToList())
    {
        Tuple<string, string> itemSelecionado = SelecionarNota(campo);

        if (campo.Count > 0)
        {
            Console.Write($"Qual é a {itemSelecionado.Item2} de {tom}? ");
            string resposta = Console.ReadLine();

            if (resposta?.ToLowerInvariant() != itemSelecionado.Item1.ToString().ToLowerInvariant())
            {
                Console.Write("\n");

                while (true)
                {
                    Console.WriteLine($"Você perdeu com {pontos} {(pontos == 1 ? "ponto" : "pontos")}!");
                    Thread.Sleep(1000);
                }
            }

            pontos++;
        }
    }
}

Console.ReadKey();

static Tuple<string, string> SelecionarNota(List<string> campo)
{
    // Randomizar;
    Random? random = new();
    int index = 0;
    string nota = "";
    bool isOk = false;

    do
    {
        index = random.Next(campo.Count);
        nota = campo[index];

        if (nota != "")
        {
            isOk = true;
        }
    } while (!isOk);

    // Atualizar valor do item na lista;
    campo[index] = "";

    // Verificar texto;
    string texto = SelecionarTexto(index);

    return Tuple.Create(nota, texto);
}

static string SelecionarTexto(int index)
{
    if (index == 0)
    {
        return "segunda";
    }
    else if (index == 1)
    {
        return "terceira";
    }
    else if (index == 2)
    {
        return "quarta";
    }
    else if (index == 3)
    {
        return "quinta";
    }
    else if (index == 4)
    {
        return "sexta";
    }

    return "";
}