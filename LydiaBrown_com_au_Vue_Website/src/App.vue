<template>
  <div class="app-main">
    <nav class="app-navbar">
      <div class="app-logo">
        <router-link to="/">
          <img src="/src/assets/resized_white.jpg" alt="Logo" class="app-logo-img" />
        </router-link>
      </div>
      
      <!-- Mobile Menu Toggle Button -->
      <button 
        class="mobile-menu-toggle" 
        @click="showMobileMenu = !showMobileMenu"
        :class="{ 'active': showMobileMenu }"
        aria-label="Toggle navigation menu"
      >
        <span class="hamburger-line"></span>
        <span class="hamburger-line"></span>
        <span class="hamburger-line"></span>
      </button>

      <!-- Navigation Links -->
      <div class="nav-links" :class="{ 'mobile-open': showMobileMenu }">
        <RouterLink 
          class="app-nav-link" 
          to="/" 
          @click="closeMobileMenu"
        >Home</RouterLink>


        <RouterLink 
          class="app-nav-link" 
          to="/Contact" 
          @click="closeMobileMenu"
        >Contact</RouterLink>
      </div>
    </nav>

    <transition name="fade" mode="out-in">
      <RouterView />
    </transition>
  </div>
</template>

<script setup>
import { ref, onMounted, onUnmounted } from 'vue'

const showMobileMenu = ref(false)

const closeMobileMenu = () => {
  showMobileMenu.value = false
}

// Close mobile menu when clicking outside
const handleClickOutside = (event) => {
  if (!event.target.closest('.app-navbar')) {
    showMobileMenu.value = false
  }
}

// Close mobile menu on window resize
const handleResize = () => {
  if (window.innerWidth >= 768) {
    showMobileMenu.value = false
  }
}

onMounted(() => {
  document.addEventListener('click', handleClickOutside)
  window.addEventListener('resize', handleResize)
})

onUnmounted(() => {
  document.removeEventListener('click', handleClickOutside)
  window.removeEventListener('resize', handleResize)
})
</script>

<style scoped>
/* Base styles - Mobile first */
.app-main {
  min-height: 100vh;
  display: flex;
  flex-direction: column;
}

.app-navbar {
  /* Keep original styling */
  padding: 0.25rem 1rem; /* Reduced top/bottom from 0.5rem to 0.25rem */
  display: flex;
  align-items: center;
  justify-content: space-between;
  position: relative;
}

.app-logo {
  flex-shrink: 0;
}

.app-logo-img {
  height: 32px;
  width: auto;
}

/* Mobile Menu Toggle Button */
.mobile-menu-toggle {
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  width: 24px;
  height: 24px;
  background: transparent;
  border: none;
  cursor: pointer;
  padding: 0;
  z-index: 10;
}

.hamburger-line {
  width: 24px;
  height: 2px;
  background: #334155;
  border-radius: 1px;
  transition: all 0.3s ease;
  transform-origin: 1px;
}

.mobile-menu-toggle.active .hamburger-line:nth-child(1) {
  transform: rotate(45deg);
}

.mobile-menu-toggle.active .hamburger-line:nth-child(2) {
  opacity: 0;
}

.mobile-menu-toggle.active .hamburger-line:nth-child(3) {
  transform: rotate(-45deg);
}

/* Navigation Links - Mobile */
.nav-links {
  position: absolute;
  top: 100%;
  left: 0;
  right: 0;
  background: inherit;
  display: flex;
  flex-direction: column;
  padding: 0;
  max-height: 0;
  overflow: hidden;
  transition: all 0.3s ease;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  border-radius: 0 0 0.5rem 0.5rem;
}

.nav-links.mobile-open {
  max-height: 250px;
  padding: 0.375rem 0; /* Reduced top/bottom from 0.75rem to 0.375rem */
}

.app-nav-link {
  text-decoration: none;
  padding: 0.25rem 1rem; /* Reduced top/bottom from 0.5rem to 0.25rem */
  font-weight: 700; /* Increased from 500 to 700 */
  transition: all 0.3s ease;
  display: block;
  border-bottom: 1px solid rgba(51, 65, 85, 0.1);
}

.app-nav-link:last-child {
  border-bottom: none;
}

/* Tablet styles */
@media (min-width: 768px) {
  .app-navbar {
    padding: 0.375rem 2rem; /* Reduced top/bottom from 0.75rem to 0.375rem */
  }
  
  .app-logo-img {
    height: 36px;
  }
  
  .mobile-menu-toggle {
    display: none;
  }
  
  .nav-links {
    position: static;
    flex-direction: row;
    background: transparent;
    max-height: none;
    overflow: visible;
    padding: 0;
    gap: 0.75rem;
    box-shadow: none;
    border-radius: 0;
  }
  
  .app-nav-link {
    padding: 0.1875rem 0.75rem; /* Reduced top/bottom from 0.375rem to 0.1875rem */
    border: none;
    border-radius: 0.5rem;
    white-space: nowrap;
    font-weight: 700; /* Increased from default to 700 */
  }
}

/* Desktop styles */
@media (min-width: 1024px) {
  .app-navbar {
    padding: 0.375rem 3rem; /* Reduced top/bottom from 0.75rem to 0.375rem */
  }
  
  .app-logo-img {
    height: 40px;
  }
  
  .nav-links {
    gap: 1rem;
  }
  
  .app-nav-link {
    padding: 0.25rem 1rem; /* Reduced top/bottom from 0.5rem to 0.25rem */
    font-size: 1rem;
    font-weight: 800; /* Increased from 700 to 800 for even bolder text */
  }
}

/* Large desktop */
@media (min-width: 1200px) {
  .app-navbar {
    max-width: 1200px;
    margin: 0 auto;
    padding: 0.375rem 2rem; /* Reduced top/bottom from 0.75rem to 0.375rem */
  }
  
  .app-nav-link {
    font-weight: 800; /* Also increase for large desktop */
  }
}

/* Page transition animations */
.fade-enter-active, .fade-leave-active {
  transition: opacity 0.4s ease;
}

.fade-enter-from, .fade-leave-to {
  opacity: 0;
}

/* Ensure RouterView takes full width */
.app-main > div {
  flex: 1;
}

/* Accessibility improvements */
@media (prefers-reduced-motion: reduce) {
  .mobile-menu-toggle,
  .hamburger-line,
  .nav-links,
  .app-nav-link,
  .fade-enter-active,
  .fade-leave-active {
    transition: none;
  }
}

/* Focus styles for keyboard navigation */
.mobile-menu-toggle:focus,
.app-nav-link:focus {
  outline: 2px solid #60a5fa;
  outline-offset: 2px;
}
</style>