using System;

namespace elephanet_demo
{
    public class Toilet
    {
        public Guid Id { get;set;}
        public int ToiletID {get;set;} 
        public string URL {get;set;}
        public string Name {get;set;}
        public string Address {get;set;}
        public string Town {get;set;}
        public string State {get;set; }
        public string Postcode {get;set;}
        public string AddressNote {get;set;}
        public bool Male {get;set;}
        public bool Female {get;set;}
        public bool Unisex {get;set;}
        public string FacilityType {get;set;}
        public string ToiletType {get;set;}
        public bool AccessLimited {get;set;}
        public bool PaymentRequired {get;set;}
        public bool KeyRequired {get;set;}
        public string AccessNote {get;set;}
        public bool Parking {get;set;}
        public string ParkingNote {get;set;}
        public bool AccessibleMale {get;set;}
        public bool AcessibleFemale {get;set;}
        public bool AccessibleUnisex {get;set;}
        public string AccessibleNote {get;set;}
        public bool Mlak {get;set;}
        public bool ParkingAccessible {get;set;}
        public string AccessibleParkingNote {get;set;}
        public string IsOpen {get;set;}
        public string OpeningHoursSchedule {get;set;}
        public string OpeningHoursNote {get;set;}
        public bool BabyChange {get;set;}
        public bool Showers {get;set;}
        public bool DrinkingWater {get;set;}
        public bool SharpsDisposal {get;set;}
        public bool SanitaryDisposal {get;set;}
        public string IconUrl {get;set;}
        public string IconAltText {get;set;}
        public string Notes {get;set;}
        public string Status {get;set;}
        public double Latitude {get;set;}
        public double Longitude { get; set; }
    }

}
