import axios from "axios";
import { getConfig, apiUrl } from "../shared/utils/apiConfigs";
import { handleResponse, handleError } from "../shared/utils/apiUtils";

export const getPCShootStatus = async () => {
  return await axios
    .get(`${apiUrl}/PC/ShootStatus`, getConfig())
    .then(handleResponse)
    .catch(handleError);
};
