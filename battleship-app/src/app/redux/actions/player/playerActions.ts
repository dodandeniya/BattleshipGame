import * as actions from "../../constants";
import * as api from "../../../apis/playerApi";
import { setErrors } from "../errors/errorsActions";

export const createPlayer = (name: string) => async (
  dispatch: any,
  getState: any
) => {
  try {
    dispatch({ type: actions.CREATE_PLAYER_REQUEST });
    const data = await api.createPlayer(name);
    dispatch({
      type: actions.CREATE_PLAYER_SUCCESS,
      payload: data,
    });
  } catch (error) {
    dispatch({
      type: actions.CREATE_PLAYER_FAIL,
      payload:
        error.response && error.response.data.message
          ? error.response.data.message
          : error.message,
    });
    dispatch(setErrors(error));
  }
};

export const getPlayersList = () => async (dispatch: any, getState: any) => {
  try {
    dispatch({ type: actions.GET_PLAYERS_LIST_REQUEST });
    const data = await api.getPlayers();
    dispatch({
      type: actions.GET_PLAYERS_LIST_SUCCESS,
      payload: data,
    });
  } catch (error) {
    dispatch({
      type: actions.GET_PLAYERS_LIST_FAIL,
      payload:
        error.response && error.response.data.message
          ? error.response.data.message
          : error.message,
    });
    dispatch(setErrors(error));
  }
};

export const getShipList = () => async (dispatch: any, getState: any) => {
  try {
    dispatch({ type: actions.GET_SHIP_LIST_REQUEST });
    const data = await api.getShipList();
    dispatch({
      type: actions.GET_SHIP_LIST_SUCCESS,
      payload: data,
    });
  } catch (error) {
    dispatch({
      type: actions.GET_SHIP_LIST_FAIL,
      payload:
        error.response && error.response.data.message
          ? error.response.data.message
          : error.message,
    });
    dispatch(setErrors(error));
  }
};

export const getPlayerShootStatus = (x: number, y: number) => async (
  dispatch: any,
  getState: any
) => {
  try {
    const params = {
      "position.xPosition": x,
      "position.yPosition": y,
    };

    dispatch({ type: actions.GET_SHOOT_STATUS_REQUEST });
    const data = await api.getPlayerShootStatus(params);
    dispatch({
      type: actions.GET_SHOOT_STATUS_SUCCESS,
      payload: data,
    });
  } catch (error) {
    dispatch({
      type: actions.GET_SHOOT_STATUS_FAIL,
      payload:
        error.response && error.response.data.message
          ? error.response.data.message
          : error.message,
    });
    dispatch(setErrors(error));
  }
};
