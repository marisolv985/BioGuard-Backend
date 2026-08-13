using System.ComponentModel.DataAnnotations;

namespace BioGuard.Api.DTOs;

public record AlertaResponse(
    string Id, string PacienteId, string Tipo, string Nivel,
    string Titulo, string Mensaje, bool Atendida,
    DateTime FechaCreacion, DateTime? FechaAtencion);

public record CrearAlertaRequest(
    [Required] string PacienteId,
    [Required] [StringLength(100)] string Tipo,
    [Required] [StringLength(50)] string Nivel,
    [Required] [StringLength(200)] string Titulo,
    [Required] [StringLength(500)] string Mensaje,
    int? PulsoBpm, double? TemperaturaC,
    double? SudoracionGsr, double? ProbabilidadPico,
    double? StressScore = null, double? HrvRmssd = null, double? Spo2 = null,
    string? DeviceId = null, bool? IsSimulated = null,
    double? Latitud = null, double? Longitud = null,
    DateTime? Timestamp = null);

public record ResolverAlertaRequest(
    [Required] string CuidadorId,
    [StringLength(500)] string? AccionTomada);
