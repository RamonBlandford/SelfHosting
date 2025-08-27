<template>
  <div class="redshoes-main">
    <header class="redshoes-header">
      <h1 class="redshoes-title">
        Case Studies <br />
      </h1>
      <p class="redshoes-subtitle">
        Here are some of our client successes.
      </p>
    </header>
    <br>
    <section class="case-studies-section">
      <!-- Row 1: Governmental Data Analytics -->
      <div class="case-study-row">
        <div class="case-study-tile">
          <h3 class="redshoes-tile-title">Governmental Data Analytics</h3>
          <div class="case-study-image-container">
            <img
              src="/src/assets/burndown_monthly.png"
              class="case-study-image"
              alt="Healthcare Data Integration"
            />
          </div>
        </div>
        <div class="case-study-content" @click="showPopup3 = true">
          <p class="redshoes-tile-desc">
            Red Shoes Technology helped an Australian government body get insights into previously disorganised data.<br><br>
            [Click to read more]
          </p>
        </div>
      </div>

      <!-- Row 2: Medical Clinic Demand Upsize and Data Analysis -->
      <div class="case-study-row">
        <div class="case-study-tile">
          <h3 class="redshoes-tile-title">Medical Clinic Demand Upsize and Data Analysis</h3>
          <div class="case-study-image-container">
            <img
              src="/src/assets/clinic.webp"
              class="case-study-image"
              alt="Healthcare Data Integration"
            />
          </div>
        </div>
        <div class="case-study-content" @click="showPopup2 = true">
          <p class="redshoes-tile-desc">
            Red Shoes Technology helped a clinic integrate disparate data sources for improved patient care and reporting.<br><br>
            [Click to read more]
          </p>
        </div>
      </div>

      <!-- Row 3: Call Centre Stabilization and Upgrade -->
      <div class="case-study-row">
        <div class="case-study-tile">
          <h3 class="redshoes-tile-title">Call Centre Stabilization and Upgrade</h3>
          <div class="case-study-image-container">
            <img
              src="/src/assets/call_centre.webp"
              class="case-study-image"
              alt="Call Centre Stabilization"
            />
          </div>
        </div>
        <div class="case-study-content" @click="showPopup1 = true">
          <p class="redshoes-tile-desc">
            Red Shoes Technology was contacted by a call centre aiming to modernise their IT systems and increase reliability. The company's business systems needed uplift.
            <br><br>
            [Click to read more]
          </p>
        </div>
      </div>
    </section>

    <!-- Popup 1 -->
    <div v-if="showPopup1" class="popup-overlay">
      <div class="popup-content">
        <button class="popup-close" @click="showPopup1 = false">×</button>
        <h3 class="popup-title">Call Centre Stabilization and Upgrade</h3>
        <div class="popup-text">
          <br>
          <b>About the Client</b><br>
          This national call centre manages voice, pager and other communications for clients, including high-priority medical and safety-critical recipients. Concerned about the ageing and reliability of their IT systems, the owner contacted Red Shoes Technology.<br><br>

          <b>The Problem</b><br>
          The call centre's software and systems were outdated, impacting usability, reliability, and business continuity.<br><br>

          <b>The Solution</b><br>
          Red Shoes Technology analysed the IT environment and incrementally replaced obsolete systems. New custom communication modules were developed and integrated without service outages. In a second phase, report automation software was introduced to improve efficiency and customer communication.<br><br>

          <b>Subsequent Engagement</b><br>
          Following successful outcomes, Red Shoes Technology was re-engaged to upgrade the primary client messaging system. A structured plan guided the process through confirmation of business operations, gap analysis, data migration, testing, and final cutover. The result was a modern, reliable, and efficient call centre IT environment.
        </div>
      </div>
    </div>

    <!-- Popup 2 -->
    <div v-if="showPopup2" class="popup-overlay">
      <div class="popup-content">
        <button class="popup-close" @click="showPopup2 = false">×</button>
        <h3 class="popup-title">Healthcare Data Integration</h3>
        <div class="popup-text">
          <br><b>About the Client</b><br>
          The client is a healthcare practice owner in inner Melbourne, managing daily accounts and bookings for dozens of clients.<br><br>

          <b>The Problem</b><br>
          During the pandemic, the client struggled with the shift to virtual appointments. Manual invoicing, payments, and reminders became increasingly time-consuming during lockdowns.<br><br>

          <b>The Solution</b><br>
          We implemented a patient CRM with automated billing, reminders, payments, rebate processing and invoicing, reducing the manual workload.<br><br>

          <b>Subsequent Engagement</b><br>
          With daily processes optimised, attention turned to business growth. Key data insights were locked within booking systems and not easily accessible.<br><br>

          <b>The Solution</b><br>
          We transformed de-identified patient data into valuable business insights, highlighting client demographics, retention, and referral sources.<br><br>

          <b>The Result</b><br>
          The practice gained clear insights to focus client acquisition efforts and successfully grew their customer base.
        </div>
      </div>
    </div>

    <!-- Popup 3 -->
    <div v-if="showPopup3" class="popup-overlay">
      <div class="popup-content">
        <button class="popup-close" @click="showPopup3 = false">×</button>
        <h3 class="popup-title">Australian governmental data-analytics</h3>
        <div class="popup-text">
        <br>
          <b>About the Client</b><br>
          The client is a government body responsible for managing large volumes of operational data across multiple departments.<br><br>

          <b>The Problem</b><br>
          The client possessed data stored across multiple sources in unstructured formats, making it difficult to access, integrate, and use at scale for reporting and analysis.<br><br>

          <b>The Solution</b><br>
          We implemented a data-meshing strategy combined with advanced data transformation techniques to clean, structure, and organise the data. This prepared the datasets for seamless use with dashboard visualisations.<br><br>

          <b>The Result</b><br>
          The client now benefits from dynamic, easy-to-use data visualisation dashboards, enabling effortless access to insights that were previously inaccessible or hidden within unstructured data.
        </div>
      </div>
    </div>

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
