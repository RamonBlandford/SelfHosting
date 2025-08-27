<template>
  <div class="redshoes-main">
    <header class="redshoes-header">
      <h1 class="redshoes-title">
        Turn Your Data Into Business Decisions<br />
      </h1>
      <p class="redshoes-subtitle">
        Find the secrets and trends hidden in your data in three steps.
      </p>
    </header>

    <!-- Overview Section -->
    <section class="redshoes-section overview-section">
      <div class="redshoes-tile">
        <h3 class="redshoes-tile-title">1) Explore</h3>
        <div class="overview-image-container">
          <img
            src="/src/assets/data_analytics_explore.png"
            class="overview-image"
            alt="Explore"
          />
        </div>
      </div>

      <div class="redshoes-tile">
        <h3 class="redshoes-tile-title">2) Enrich</h3>
        <div class="overview-image-container">
          <img
            src="/src/assets/data_analytics_enrich.png"
            class="overview-image"
            alt="Enrich"
          />
        </div>
      </div>

      <div class="redshoes-tile">
        <h3 class="redshoes-tile-title">3) Present</h3>
        <div class="overview-image-container">
          <img
            src="/src/assets/data_analytics_present.png"
            class="overview-image"
            alt="Present"
          />
        </div>
      </div>
    </section>

    <br>

    <!-- Detailed Section -->
    <section class="detailed-section">
      <!-- Row 1 -->
      <div class="detail-row">
        <div class="detail-content">
          <h3 class="redshoes-tile-title">1) Explore</h3>
          <p class="redshoes-tile-desc">
            Identify new revenue streams and efficiency gains - Unlock information buried in files, databases, and systems.<br><br>
            <em>Benefit</em>: Confidently base decisions on accurate, reliable data
          </p>
        </div>
        <div class="detail-image-container">
          <img
            src="/src/assets/sentiment_analysis.png"
            class="analytics-image-fit"
            alt="Sentiment Analysis"
          />
        </div>
      </div>
      
      <!-- Row 2 -->
      <div class="detail-row">
        <div class="detail-content">
          <h3 class="redshoes-tile-title">2) Enrich</h3>
          <p class="redshoes-tile-desc">
            Base your decisions on reliable, enriched data. We enhance it with additional sources or AI where appropriate.<br><br>
            <em>Benefit</em>: Trust your data to make informed decisions.
          </p>
        </div>
        <div class="detail-image-container">
          <img
            src="/src/assets/wordcloud.png"
            class="analytics-image-fit"
            alt="Wordcloud"
          />
        </div>
      </div>
      
      <!-- Row 3 -->
      <div class="detail-row">
        <div class="detail-content">
          <h3 class="redshoes-tile-title">3) Present</h3>
          <p class="redshoes-tile-desc">
            Make confident decisions, backed by data you understand.<br><br>
            <em>Benefit</em>: Make decisions with confidence, supported by clear, actionable insights.
          </p>
        </div>
        <div class="detail-image-container">
          <img
            src="/src/assets/burndown_monthly.png"
            class="analytics-image-fit"
            alt="Burndown"
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

