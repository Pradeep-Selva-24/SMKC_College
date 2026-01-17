using College.Entities;

namespace College.DTO;

public class ClubsDTO
{
    public ClubsMaster ClubsMaster = new();
    public List<ClubsDetails> lstClubsDetails = [];
}
