using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class DiagnosticModel
    {
        [Key]
        public int IdDiagnostic { get; set; }
        public int IdPA { get; set; }
        [Required]
        public bool AssistantDiagnostic { get; set; }
        [Required]
        public string? AssistantDistDiagnostic { get; set; }
        [Required]
        public string? TransportMethodPA { get; set; }
        [Required]
        public string? HobbiesDiagnostic { get; set; }
        [Required]
        public bool AmenitiesDiagnostic { get; set; }
        [Required]
        public bool PracticeSportDiagnostic { get; set; }
        [Required]
        public string? NameSportDiagnostic { get; set; }
        [Required]
        public string? FellTimeDiagnostic { get; set; }
        public bool DispositifDiagnostic { get; set; }
        [Required]
        public bool VisualProblemDiagnostic { get; set; }
        [Required]
        public bool HealthMonitoringDiagnostic { get; set; }
        [Required]
        public bool HearingProblemDiagnostic { get; set; }
        [Required]
        public bool MemoryProblemDiagnostic { get; set; }
        [Required]
        public bool NecessaryAccompanimentDiagnostic { get; set; }
        [Required]
        public bool AssuranceContractDiagnostic { get; set; }
        [Required]
        public bool MarcheAccesDiagnostic { get; set; }
        [Required]
        public bool CommunePartiDiagnostic { get; set; }
        [Required]
        public string? BuildingPeriodDiagnostic { get; set; }
        [Required]
        public bool ConditionerAirDiagnostic { get; set; }
        [Required]
        public string? DetectorDiagnostic { get; set; }
        [Required]
        public string? HotHomeDiagnostic { get; set; }
    }
}
