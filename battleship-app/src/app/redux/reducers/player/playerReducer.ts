import { PlayerTypes } from "../../actions/actionTypes";
import * as actions from "../../constants";
import {
  initialPlayer,
  initialPlayerList,
  initialShipList,
  initialShootStatus,
} from "../../initialStates";

export const playerReducer = (state = initialPlayer, action: PlayerTypes) => {
  switch (action.type) {
    case actions.CREATE_PLAYER_REQUEST:
      return state;

    case actions.CREATE_PLAYER_SUCCESS:
      return { userId: action.payload };

    case actions.CREATE_PLAYER_FAIL:
      return { error: action.payload as string };

    default:
      return state;
  }
};

export const playersListReducer = (
  state = initialPlayerList,
  action: PlayerTypes
) => {
  switch (action.type) {
    case actions.GET_PLAYERS_LIST_REQUEST:
      return state;

    case actions.GET_PLAYERS_LIST_SUCCESS:
      return action.payload;

    case actions.GET_PLAYERS_LIST_FAIL:
      return { error: action.payload as string };

    default:
      return state;
  }
};

export const getShipListReducer = (
  state = initialShipList,
  action: PlayerTypes
) => {
  switch (action.type) {
    case actions.GET_SHIP_LIST_REQUEST:
      return state;

    case actions.GET_SHIP_LIST_SUCCESS:
      return action.payload;

    case actions.GET_SHIP_LIST_FAIL:
      return { error: action.payload as string };

    default:
      return state;
  }
};

export const getPlayerShootStatusReducer = (
  state = initialShootStatus,
  action: PlayerTypes
) => {
  switch (action.type) {
    case actions.GET_SHOOT_STATUS_REQUEST:
      return state;

    case actions.GET_SHOOT_STATUS_SUCCESS:
      return action.payload;

    case actions.GET_SHOOT_STATUS_FAIL:
      return { error: action.payload as string };

    default:
      return state;
  }
};
