<template>
  <div class="redshoes-main">
    <header class="redshoes-header">
      <h1 class="redshoes-title">
        Turn Your Software into a Competitive Advantage<br />
      </h1>
      <p class="redshoes-subtitle">
        Solve performance issues, streamline systems, and create tailored solutions in three steps.
      </p>
    </header>

    <!-- Overview Section -->
    <section class="redshoes-section overview-section">
      <div class="redshoes-tile">
        <h3 class="redshoes-tile-title">1) Evaluate</h3>
        <div class="overview-image-container">
          <img
            src="/src/assets/software_evaluate.png"
            class="overview-image"
            alt="Evaluate"
          />
        </div>
      </div>

      <div class="redshoes-tile">
        <h3 class="redshoes-tile-title">2) Enhance</h3>
        <div class="overview-image-container">
          <img
            src="/src/assets/software_enhance.png"
            class="overview-image"
            alt="Enhance"
          />
        </div>
      </div>

      <div class="redshoes-tile">
        <h3 class="redshoes-tile-title">3) Support</h3>
        <div class="overview-image-container">
          <img
            src="/src/assets/software_monitoring.png"
            class="overview-image"
            alt="Support"
          />
        </div>
      </div>
    </section>

    <br />

    <!-- Detailed Section -->
    <section class="detailed-section">
      <!-- Row 1 -->
      <div class="detail-row">
        <div class="detail-content">
          <h3 class="redshoes-tile-title">1) Evaluate</h3>
          <p class="redshoes-tile-desc">
            Identify performance gaps, inefficiencies, and risks in your current systems.<br /><br />
            <em>Benefit</em>: Understand where technology is holding you back and where improvements will deliver value.
          </p>
        </div>
        <div class="detail-image-container">
          <img
            src="/src/assets/software_diagnose.webp"
            class="analytics-image-fit"
            alt="System Diagnostic"
          />
        </div>
      </div>

      <!-- Row 2 -->
      <div class="detail-row">
        <div class="detail-content">
          <h3 class="redshoes-tile-title">2) Enhance</h3>
          <p class="redshoes-tile-desc">
            We modernise existing platforms or create tailored solutions designed around your business needs.<br /><br />
            <em>Benefit</em>: Reliable, efficient, and scalable software that fits your operations.
          </p>
        </div>
        <div class="detail-image-container">
          <img
            src="/src/assets/code_design.webp"
            class="analytics-image-fit"
            alt="Development Tools"
          />
        </div>
      </div>

      <!-- Row 3 -->
      <div class="detail-row">
        <div class="detail-content">
          <h3 class="redshoes-tile-title">3) Support</h3>
          <p class="redshoes-tile-desc">
            Ongoing support and maintenance to keep your systems running smoothly.<br /><br />
            <em>Benefit</em>: Confidence your technology is stable and supported so you can focus on business.
          </p>
        </div>
        <div class="detail-image-container">
          <img
            src="/src/assets/software_deploy.webp"
            class="analytics-image-fit"
            alt="Monitoring Dashboard"
          />
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
// No complex logic needed for this static page example
</script>

