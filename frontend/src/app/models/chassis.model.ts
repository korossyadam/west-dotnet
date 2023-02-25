export class Chassis {
   public chassisIndex: number;
   public brand: string;
   public name: string;
   public year: string;
   public hasImage: boolean;

   constructor(chassisIndex: number, brand: string, name: string, year: string, hasImage: boolean) {
      this.chassisIndex = chassisIndex;
      this.brand = brand;
      this.name = name;
      this.year = year;
      this.hasImage = hasImage;
   }
}
