import Vue from 'vue';
import App from './App.vue';

export const progressBarBus = new Vue();
export const quoteAdderBus = new Vue();
export const quoteRemoverBus = new Vue();

new Vue({
  el: '#app',
  render: h => h(App)
});
