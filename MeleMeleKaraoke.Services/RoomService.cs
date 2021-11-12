using MeleMeleKarake.domain;
using MeleMeleKaraoke.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeleMeleKaraoke.Services
{
    public class RoomService
    {
        public AppDbContext DbContext { get; set; }
        public RoomService(AppDbContext dbContext)
        {
            this.DbContext = DbContext;
        }
        public async Task<Room> AddRoom(Room Room)
        {

            this.DbContext.Set<Room>().Add(Room);
            await this.DbContext.SaveChangesAsync();
            return Room;
        }
        public async Task<List<Room>> GetAllRooms()
        {
            return await this.DbContext.Set<Room>().ToListAsync();
        }
    }
}
