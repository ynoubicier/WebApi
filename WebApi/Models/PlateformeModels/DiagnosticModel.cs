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
        public string? AssistantDistDiagnostic { get; set; }
        public string? TransportMethodPA { get; set; }
        public string? HobbiesDiagnostic { get; set; }
        public bool AmenitiesDiagnostic { get; set; }
        public bool PracticeSportDiagnostic { get; set; }
        public string? NameSportDiagnostic { get; set; }
        public string? FellTimeDiagnostic { get; set; }
        public bool DispositifDiagnostic { get; set; }
        public bool VisualProblemDiagnostic { get; set; }
        public bool HealthMonitoringDiagnostic { get; set; }
        public bool HearingProblemDiagnostic { get; set; }
        public bool MemoryProblemDiagnostic { get; set; }
        public bool NecessaryAccompanimentDiagnostic { get; set; }
        public bool AssuranceContractDiagnostic { get; set; }
        public bool MarcheAccesDiagnostic { get; set; }
        public bool CommunePartiDiagnostic { get; set; }
        public string? BuildingPeriodDiagnostic { get; set; }
        public bool ConditionerAirDiagnostic { get; set; }
        public string? DetectorDiagnostic { get; set; }
        public string? HotHomeDiagnostic { get; set; }
    }
}
