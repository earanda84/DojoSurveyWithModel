#pragma warning disable CS8618
// Referencia al nombre de trabajo del controlador de las rutas
namespace DojoSurveyWithModel.Models;

// Clase con atributos para la requeste del formulario.
public class Survey
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Language { get; set; }
    public string Comment { get; set; }
}