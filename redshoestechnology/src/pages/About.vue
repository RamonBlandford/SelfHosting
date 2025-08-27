<template>
  <div class="redshoes-main">
    <header class="redshoes-header">
      <h1 class="redshoes-title">
        About the Founder<br />
      </h1>
      <p class="redshoes-subtitle">
        Meet the Funder of Red Shoes Technology.
      </p>
    </header>
    <br>
    <section class="case-studies-section">

      <!-- Row 2: About company -->
      <div class="case-study-row">
        <div class="case-study-tile">
          <h3 class="redshoes-tile-title">About</h3>
          <div class="case-study-image-container">
            <img
              src="/src/assets/organisation_default.png"
              class="case-study-image"
              alt="about_organisation"
            />
          </div>
        </div>
        <div class="case-study-content" @click="showPopup3 = true">
          <p class="redshoes-tile-desc">
            
Red Shoes Technology professionals have proven experience serving sectors such as:<br>

Emergency Services<br>

B2B Finance<br>

Private R&D<br>

MedTech<br>

Sports Technology<br>

Defence<br><br>

​

Red Shoes professionals have provided consultation and technical expertise to organisations including:<br>

Victoria Police<br>

Department of Defence<br>

Call Service Australia<br>

Psychology Clinic*<br>

IBM<br>

​

<br><br><small>* Name withheld for privacy reasons.</small><br><br>
            
          </p>
        </div>
      </div>

      <!-- Row 1: About founder -->
      <div class="case-study-row">
        <div class="case-study-tile">
          <h3 class="redshoes-tile-title">About</h3>
          <div class="case-study-image-container">
            <img
              src="/src/assets/founder_small.png"
              class="case-study-image"
              alt="About Founder"
            />
          </div>
        </div>
        <div class="case-study-content" @click="showPopup3 = true">
          <p class="redshoes-tile-desc">
            
The Red Shoes Technical Principal is Ramon, a highly accomplished technology professional with leadership experience across multiple sectors.

He has proven experience providing high-level architectural direction, detailed design and project leadership delivering multi-million-dollar projects.    

Alongside his corporate background, Ramon is passionate about helping small and medium-sized businesses streamline their technology and automate systems. He has helped small business keep their digital systems afloat by implementing new systems and repairing old modules.    
Outside of work, Ramon is an engaged father and husband and his hobbies include designing cocktails for friends & family and performing home rennovation. 

<br><br>
            
          </p>
        </div>
      </div>

    </section>


    <footer class="redshoes-footer">
      <h2 class="redshoes-footer-title">Book a Free 15-Minute Consultation</h2>
        <router-link to="/Contact">
          <button class="redshoes-btn-primary">Contact Us</button>
        </router-link>
    </footer>
  </div>
</template>

<script setup>
import { ref } from 'vue'
const showPopup1 = ref(false)
const showPopup2 = ref(false)
const showPopup3 = ref(false)
</script>

