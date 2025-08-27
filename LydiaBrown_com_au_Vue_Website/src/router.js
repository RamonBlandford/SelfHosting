
import { createRouter, createWebHistory } from 'vue-router'
import HomePage from './pages/HomePage.vue'
import Contact from './pages/Contact.vue'

const routes = [
  { path: '/', component: HomePage },
//  { path: '/Data-Analytics', component: DataAnalytics },
//  { path: '/Software', component: Software },
//  { path: '/CaseStudies', component: CaseStudies },
//  { path: '/About', component: About },
  { path: '/Contact', component: Contact },
]

const router = createRouter({
  history: createWebHistory(),
  routes,
})


export default router
