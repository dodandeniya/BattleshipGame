import { ShootStatus } from "../enums/shootStatus";
import IPosition from "./IPosition";

export default interface IShootStatus {
  shootStatus: ShootStatus;
  position: IPosition;
}
