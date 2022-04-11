using System;
using System.Collections.Generic;
namespace PPE_Desktop
{
    public static class Utilitaires
    {

        public static List<Participant> CollectionNom(List<Participant> Participants, string LeNom)
        {
            List<Participant> LesParticipantsAvecNom = new List<Participant>();
            foreach (Participant UnParticipant in Participants)
            {
                if (UnParticipant.ParticipantNom == LeNom)
                    LesParticipantsAvecNom.Add(UnParticipant);
            }
            return LesParticipantsAvecNom;
        }

        public static int PossedeParticipants(List<Participant> Participants, string LeNom)
        {
            List<Participant> LesParticipantsAvecNom = new List<Participant>();
            LesParticipantsAvecNom = CollectionNom(Participants, LeNom);
            return LesParticipantsAvecNom.Count;
        }
    }
}
