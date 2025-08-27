
import { createRouter, createWebHistory } from 'vue-router'
import HomePage from './pages/HomePage.vue'
import DataAnalytics from './pages/DataAnalytics.vue'
import Software from './pages/Software.vue'
import CaseStudies from './pages/CaseStudies.vue'
import About from './pages/About.vue'
import Contact from './pages/Contact.vue'

const routes = [
  { path: '/', component: HomePage },
  { path: '/Data-Analytics', component: DataAnalytics },
  { path: '/Software', component: Software },
  { path: '/CaseStudies', component: CaseStudies },
  { path: '/About', component: About },
  { path: '/Contact', component: Contact },
]

const router = createRouter({
  history: createWebHistory(),
  routes,
})

router.afterEach((to) => {
  if (window.gtag) {
    window.gtag('config', 'G-Y56EZVM6KG', {
      page_path: to.fullPath,
    });
  }
});

export default router
