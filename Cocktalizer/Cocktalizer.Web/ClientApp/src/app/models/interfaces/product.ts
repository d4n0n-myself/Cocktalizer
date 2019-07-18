import {MeasurementType} from "../enums/measurementType";

export interface Product {
  name: string;
  category: string;
  price: number;
  type: MeasurementType;
}
