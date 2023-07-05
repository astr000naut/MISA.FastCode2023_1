import { createApp } from 'vue'
import App from './App.vue'
import MSCombobox from 'ms-combobox'
import MTextField from './components/base/textfield/MTextfield.vue'
import MButton from './components/base/button/MButton.vue'
import router from '@/router/router.js'
import emitter from 'tiny-emitter/instance'
import MISAResource from './helpers/resource'
import MISAEnum from './helpers/enum'
import axios from 'axios'

const app = createApp(App);
app.component("m-combobox",MSCombobox)
    .component('m-textfield', MTextField)
    .component('m-button',MButton)

app.config.globalProperties.$_emitter = emitter;
app.config.globalProperties.$_MISAResource = MISAResource;
app.config.globalProperties.$_MISAEnum = MISAEnum;
app.config.globalProperties.$_LANG_CODE = "VN";
app.config.globalProperties.$_axios = axios;
app.use(router);
app.mount('#app')
export default app;
