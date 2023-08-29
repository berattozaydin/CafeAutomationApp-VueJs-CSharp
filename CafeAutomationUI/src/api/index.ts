import axios from "axios";

//export const domainAddress = "http://localhost:5035";
//export const baseApiURL = domainAddress + "/api/";

export const domainAddress = "";
export const baseApiURL = domainAddress + "/api/";

export const api = axios.create({
  baseURL: baseApiURL,
});
//export const api = axios.create();

export default api;