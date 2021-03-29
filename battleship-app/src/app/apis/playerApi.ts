import axios from "axios";
import { getConfig, apiUrl } from "../shared/utils/apiConfigs";
import { handleResponse, handleError } from "../shared/utils/apiUtils";

export const createPlayer = async (name: string) => {
  return await axios
    .post(`${apiUrl}/Player`, { name: name }, getConfig())
    .then(handleResponse)
    .catch(handleError);
};
