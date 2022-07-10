using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MyHotel.Business.Exceptions;
using MyHotel.Business.Models;
using MyHotel.Business.Services.IServices;
using MyHotel.Domain.Entities;
using MyHotel.Domain.IRepositories;

namespace MyHotel.Business.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;
        public ReservationService(
            IReservationRepository reservationRepository, 
            IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }
        public int AddReservation(ReservationModel reservationModel)
        {
            var availableRooms = _reservationRepository
                .GetAvailableRooms(reservationModel.CheckIn, reservationModel.CheckOut)
                .ToList();

            if (CheckAvailability(reservationModel, availableRooms))
            {
                var reservation = _mapper.Map<Reservation>(reservationModel);
                reservation.Rooms = SelectRoomsForReservation(reservation, availableRooms);

                var createdReservation = _reservationRepository.Add(reservation);
                return createdReservation.Id;
            }
            throw new NotAvailableException("The reservation can't be fulfilled anymore");
        }

        public bool CheckReservation(ReservationModel reservationModel)
        {
            var availableRooms = _reservationRepository
                .GetAvailableRooms(reservationModel.CheckIn, reservationModel.CheckOut)
                .ToList();
            return CheckAvailability(reservationModel, availableRooms);
        }

        private static bool CheckAvailability(ReservationModel reservationModel, ICollection<Room> rooms)
        {
            if (rooms.Count < reservationModel.Rooms.Count)
                return false;

            var neededRooms = reservationModel.Rooms.GroupBy(x => x.Capacity);
            foreach (var roomCapacity in neededRooms)
            {
                if (rooms.Count(x => x.Capacity == roomCapacity.Key) < roomCapacity.Count())
                    return false;
            }

            return true;
        }

        private static ICollection<Room> SelectRoomsForReservation(Reservation reservation, ICollection<Room> rooms)
        {
            var selectedRooms = new List<Room>();
            var neededRooms = reservation.Rooms.GroupBy(room => room.Capacity);
            foreach (var group in neededRooms)
            {
                var neededNumberOfRooms = group.ToList().Count;
                selectedRooms.AddRange(rooms.Where(room => room.Capacity == group.Key).Take(neededNumberOfRooms));
            }
            return selectedRooms;
        }
    }
}
