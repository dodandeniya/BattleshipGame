import * as actions from "../constants";

interface IPlayerTypes {
  type:
    | typeof actions.CREATE_PLAYER_FAIL
    | typeof actions.CREATE_PLAYER_REQUEST
    | typeof actions.CREATE_PLAYER_SUCCESS
    | typeof actions.GET_PLAYERS_LIST_FAIL
    | typeof actions.GET_PLAYERS_LIST_REQUEST
    | typeof actions.GET_PLAYERS_LIST_SUCCESS
    | typeof actions.GET_SHIP_LIST_FAIL
    | typeof actions.GET_SHIP_LIST_REQUEST
    | typeof actions.GET_SHIP_LIST_SUCCESS
    | typeof actions.GET_SHOOT_STATUS_FAIL
    | typeof actions.GET_SHOOT_STATUS_REQUEST
    | typeof actions.GET_SHOOT_STATUS_SUCCESS;

  payload: any;
}

interface IPCPlayerTypes {
  type:
    | typeof actions.GET_PC_SHOOT_STATUS_FAIL
    | typeof actions.GET_PC_SHOOT_STATUS_REQUEST
    | typeof actions.GET_PC_SHOOT_STATUS_SUCCESS;

  payload: any;
}

export type PlayerTypes = IPlayerTypes;
export type PCPlayerTypes = IPCPlayerTypes;
