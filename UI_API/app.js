const routes = [
    {path: '/home',component:home},
    {path: '/vueapi',component:vueapi}
]

const router = new VueRouter({
    routes
})

const app = new Vue({
    router
}).$mount('#app')