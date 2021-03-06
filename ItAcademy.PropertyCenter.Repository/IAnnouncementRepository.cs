﻿using ItAcademy.PropertyCenter.Entities;
using ItAcademy.PropertyCenter.Repository.Contracts;

namespace ItAcademy.PropertyCenter.Repository
{
    public interface IAnnouncementRepository : IReadOnlyRepository<Announcement>, IPersistRepository<Announcement>
    {
    }
}
