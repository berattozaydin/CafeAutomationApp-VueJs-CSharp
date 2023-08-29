import './assets/main.css'

import { createApp } from 'vue'
import { createPinia } from 'pinia'
import PrimeVue from "primevue/config";
import PrimeToastService from "primevue/toastservice"; 
import PrimeConfirmationService from "primevue/confirmationservice"; 
import App from './App.vue'
import router from './router'
import {install} from "./api/config"; 
const app = createApp(App)

app.use(createPinia())
app.use(router)
app.use(PrimeVue);
app.use(PrimeToastService);
app.use(PrimeConfirmationService); 
install();
app.mount('#app')
