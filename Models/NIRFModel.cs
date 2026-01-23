using College.Entities;

namespace College.Models;

public class NIRFModel
{
    public List<NIRFDetails> LstNIRFDetails { get; set; } = [];
    public List<NIRFDocument> LstNIRFDocument { get; set; } = [];
    public List<NIRFDocumentRanking> LstNIRFDocumentRanking { get; set; } = [];
}
