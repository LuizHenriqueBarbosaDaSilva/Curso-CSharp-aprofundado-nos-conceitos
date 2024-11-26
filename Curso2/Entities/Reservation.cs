using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso2.Entities.Exceptions;

namespace Curso2.Entities
{
    /* 
    Problema exemplo 

    Fazer um programa para ler os dados de uma reserva de hotel (numero do quarto, data de entrada e data de saida)
    e mostrar os dados da reserva, inclusive sua duração em dias. Em seguida, ler novas datas de entrada e saida, atualizar
    a reserva, e mostrar novamente a reserva com os dados atualizados o programa não deve
    aceitar dados invalidos para a reserva, conforme as seguintes regras:
    - Alterações de reserva so podem ocorrer para datas futuras
    - A data de saida deve ser maior que a data de entrada

    Class Reservation
    - roomNumber : integer
    - checkIn : Date
    - checkOut : Date

    Methods:
    + duration(): Integer
    + updateDates(checkIn : Date, checkOut : Date) : void
        */
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn <= checkOut)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in date.");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckIn.Subtract(CheckOut);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            }
            if (checkIn <= checkOut)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in date.");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString() 
        {
            return $"Reservation: Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }

    }
}
