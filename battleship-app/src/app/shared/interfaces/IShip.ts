import { ShipType } from "../enums/shipType";
import IPosition from "./IPosition";

export default interface IShip {
  shipName: string;
  isSunk: boolean;
  lifeRemaining: number;
  size: number;
  boardPositions: Array<IPosition>;
  shipType: ShipType;
}
