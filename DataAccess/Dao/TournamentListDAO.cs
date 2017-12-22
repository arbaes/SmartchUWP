﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao
{
    class TournamentListDAO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ClubId { get; set; }
        public Address Address { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public TournamentState Etat { get; set; }

        public ICollection<long> ParticipantsId { get; set; }
        public ICollection<string> AdminsId { get; set; }

        public ICollection<long> MatchesId { get; set; }

        public TournamentListDAO() { }
        public TournamentListDAO(Tournament tournament )
        {
            Id = tournament.Id;
            Name = tournament.Name;
            if(tournament.Club != null)
            ClubId = tournament.Club.ClubId;

            Address = tournament.Address;
            BeginDate = tournament.BeginDate;
            EndDate = tournament.EndDate;
            Etat = tournament.Etat;
            List<long> users = new List<long>();
            foreach (User joueur in tournament.Participants)
            {
                users.Add(joueur.Id);
            }
            ParticipantsId = users;

            List<string> account = new List<string>();
            /*foreach (TournamentAdmin admin in tournament.Admins)
            {
                account.Add(admin.Account);
            }*/
            AdminsId = account;
        }
    }
}
