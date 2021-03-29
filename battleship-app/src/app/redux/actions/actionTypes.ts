import * as actions from "../constants";

interface IPlayerTypes {
  type:
    | typeof actions.CREATE_PLAYER_FAIL
    | typeof actions.CREATE_PLAYER_REQUEST
    | typeof actions.CREATE_PLAYER_SUCCESS;

  payload: any;
}

export type PlayerTypes = IPlayerTypes;
