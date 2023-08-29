import api from "./index";

export const install = () => {
  /*const authStore = useAuthStore();
  api.defaults.headers.common.Authorization = `bearer ${authStore.user?.token}`;*/

  api.interceptors.response.use(
    (response) => {
      if (response.data.msg && response.data?.success == 1 || (response.data.msg && response.data.isSuccess ==true)) {
        //mbox(response.data.msg);
      } else if (response.data?.success == 0) {
        //mbox(response.data.msg);
        // app.config.globalProperties.$toastError(response.data.msg);
      }
      return response;
    },
    /*(error) => {
      
      if (error.code == "ERR_NETWORK") {
        mbox("Sunucuya bağlanılamıyor...");
      } else {
        mbox(error.response.data.msg);
      }

      if (error.response.status == 401) {
        authStore.user = null;
      }
      // app.config.globalProperties.$toastError(error.message);
      return Promise.reject(error);
    }*/
  );
};