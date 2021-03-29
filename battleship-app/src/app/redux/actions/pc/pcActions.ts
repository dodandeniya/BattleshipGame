import * as actions from "../../constants";
import * as api from "../../../apis/pcApi";
import { setErrors } from "../errors/errorsActions";

export const getPCShootStatus = () => async (dispatch: any, getState: any) => {
  try {
    dispatch({ type: actions.GET_PC_SHOOT_STATUS_REQUEST });
    const data = await api.getPCShootStatus();
    dispatch({
      type: actions.GET_PC_SHOOT_STATUS_SUCCESS,
      payload: data,
    });
  } catch (error) {
    dispatch({
      type: actions.GET_PC_SHOOT_STATUS_FAIL,
      payload:
        error.response && error.response.data.message
          ? error.response.data.message
          : error.message,
    });
    dispatch(setErrors(error));
  }
};
