<template>
  <div class="case-studies-page">
    <section class="case-hero">
      <div class="case-hero-copy">
        <p class="eyebrow">Case Studies</p>
        <h1>Selected work showing how we solve messy technology problems.</h1>
        <p>
          Each example follows the same pattern: understand the operational pain, reduce the technical risk, and leave the client with something they can keep using.
        </p>
      </div>

      <div class="case-hero-panel">
        <p class="panel-label">What the work tends to deliver</p>
        <ul>
          <li>Cleaner reporting and better visibility.</li>
          <li>More reliable systems and fewer workarounds.</li>
          <li>Practical improvements that fit the organisation.</li>
        </ul>
      </div>
    </section>

    <section class="case-grid">
      <article class="case-card">
        <div class="case-card-media">
          <img src="/src/assets/burndown_monthly.png" alt="Monthly burndown report" />
        </div>
        <div class="case-card-body">
          <p class="card-label">Government data analytics</p>
          <h2>Making unstructured operational data useful</h2>
          <p>A public-sector client needed multiple data sources cleaned and prepared for analysis.</p>
          <button class="button button-secondary case-button" @click="showPopup3 = true">Read more</button>
        </div>
      </article>

      <article class="case-card">
        <div class="case-card-media">
          <img src="/src/assets/clinic.webp" alt="Clinic workflow visual" />
        </div>
        <div class="case-card-body">
          <p class="card-label">Healthcare workflow</p>
          <h2>Reducing admin load for a medical clinic</h2>
          <p>A clinic needed a more efficient patient workflow and better reporting across its tools.</p>
          <button class="button button-secondary case-button" @click="showPopup2 = true">Read more</button>
        </div>
      </article>

      <article class="case-card">
        <div class="case-card-media">
          <img src="/src/assets/call_centre.webp" alt="Call centre operations visual" />
        </div>
        <div class="case-card-body">
          <p class="card-label">Operational systems</p>
          <h2>Stabilising a call centre upgrade</h2>
          <p>An ageing communications environment needed a safer path to modernisation and support.</p>
          <button class="button button-secondary case-button" @click="showPopup1 = true">Read more</button>
        </div>
      </article>
    </section>

    <section class="case-proof-band">
      <article class="proof-card">
        <p class="card-label">Pattern</p>
        <h3>Move from uncertainty to a workable system.</h3>
        <p>The best projects do not just fix a single pain point. They improve the way a team works every day.</p>
      </article>
      <article class="proof-card">
        <p class="card-label">Pattern</p>
        <h3>Make data easier to trust.</h3>
        <p>Reporting matters when people can rely on it without rechecking numbers in every meeting.</p>
      </article>
      <article class="proof-card">
        <p class="card-label">Pattern</p>
        <h3>Keep the delivery practical.</h3>
        <p>Solutions should be maintainable, understandable, and aligned to the business context.</p>
      </article>
    </section>

    <section class="cta-strip">
      <div>
        <p class="eyebrow">Next step</p>
        <h2>Need a similar result for your own system or process?</h2>
      </div>
      <RouterLink class="button button-primary" to="/Contact">Talk to us</RouterLink>
    </section>

    <div v-if="showPopup1" class="popup-overlay">
      <div class="popup-content">
        <button class="popup-close" @click="showPopup1 = false">×</button>
        <p class="popup-label">Operational systems</p>
        <h3>Call centre stabilization and upgrade</h3>
        <div class="popup-text">
          <p>This national call centre needed ageing systems replaced without interrupting service.</p>
          <p><strong>The problem:</strong> the software stack was outdated and increasingly unreliable.</p>
          <p><strong>The solution:</strong> obsolete systems were replaced incrementally, communication modules were modernised, and automation improved efficiency.</p>
          <p><strong>The result:</strong> a more reliable, efficient environment with a structured upgrade path for the client messaging system.</p>
        </div>
      </div>
    </div>

    <div v-if="showPopup2" class="popup-overlay">
      <div class="popup-content">
        <button class="popup-close" @click="showPopup2 = false">×</button>
        <p class="popup-label">Healthcare workflow</p>
        <h3>Medical clinic demand upsize and data analysis</h3>
        <div class="popup-text">
          <p>A healthcare practice needed help turning manual admin into a smoother digital workflow.</p>
          <p><strong>The problem:</strong> virtual appointments and manual billing created extra work during lockdowns.</p>
          <p><strong>The solution:</strong> automated billing, reminders, and payment processing reduced effort and improved accuracy.</p>
          <p><strong>The result:</strong> the practice gained better visibility into retention and referrals, supporting growth decisions.</p>
        </div>
      </div>
    </div>

    <div v-if="showPopup3" class="popup-overlay">
      <div class="popup-content">
        <button class="popup-close" @click="showPopup3 = false">×</button>
        <p class="popup-label">Government analytics</p>
        <h3>Governmental data analytics</h3>
        <div class="popup-text">
          <p>A public-sector client needed data from multiple sources prepared for reporting and analysis.</p>
          <p><strong>The problem:</strong> unstructured data made access and integration difficult at scale.</p>
          <p><strong>The solution:</strong> data was cleaned, structured, and organised for dashboard use.</p>
          <p><strong>The result:</strong> the client gained practical, visual reporting from information that had previously been hard to use.</p>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue'

const showPopup1 = ref(false)
const showPopup2 = ref(false)
const showPopup3 = ref(false)
</script>

<style scoped>
.case-studies-page {
  max-width: 1240px;
  margin: 0 auto;
  padding: 1.25rem 1rem 4rem;
  color: #1f1a1a;
  font-family: Inter, "Segoe UI", Arial, sans-serif;
}

.case-hero,
.case-grid,
.case-proof-band,
.cta-strip {
  display: grid;
  gap: 1rem;
}

.case-hero {
  padding: 2rem 0 1.5rem;
}

.case-hero-copy,
.case-hero-panel,
.case-card,
.proof-card,
.cta-strip,
.popup-content {
  background: rgba(255, 255, 255, 0.88);
  border: 1px solid rgba(123, 21, 28, 0.09);
  box-shadow: 0 18px 45px rgba(31, 16, 18, 0.08);
  backdrop-filter: blur(10px);
  border-radius: 1.5rem;
}

.case-hero-copy,
.case-hero-panel,
.proof-card,
.cta-strip,
.popup-content {
  padding: 1.5rem;
}

.case-hero h1,
.case-card h2,
.proof-card h3,
.cta-strip h2,
.popup-content h3 {
  margin: 0;
  font-family: Georgia, "Times New Roman", serif;
  letter-spacing: -0.03em;
  color: #170f10;
}

.case-hero h1 {
  font-size: clamp(2.4rem, 7vw, 4.8rem);
  line-height: 0.98;
  max-width: 12ch;
}

.case-hero p,
.case-hero li,
.case-card p,
.proof-card p,
.popup-text p {
  margin: 0;
  color: #514548;
  line-height: 1.7;
}

.eyebrow,
.panel-label,
.card-label,
.popup-label {
  margin: 0 0 0.85rem;
  color: #9c1c24;
  text-transform: uppercase;
  letter-spacing: 0.18em;
  font-size: 0.74rem;
  font-weight: 800;
}

.case-hero-panel ul {
  margin: 0;
  padding-left: 1.1rem;
  color: #514548;
  line-height: 1.7;
}

.case-hero-panel li + li {
  margin-top: 0.35rem;
}

.case-card {
  overflow: hidden;
}

.case-card-media {
  height: 14rem;
  background: #1a1112;
}

.case-card-media img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.case-card-body {
  padding: 1.35rem;
}

.case-card h2 {
  font-size: 1.55rem;
  margin-bottom: 0.5rem;
}

.case-button {
  margin-top: 1rem;
}

.proof-card h3 {
  font-size: 1.18rem;
  margin-bottom: 0.35rem;
}

.cta-strip {
  align-items: center;
  margin-top: 2rem;
  background: linear-gradient(135deg, rgba(248, 239, 239, 0.96), rgba(255, 255, 255, 0.92));
}

.button {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  min-height: 3rem;
  padding: 0.85rem 1.25rem;
  border-radius: 999px;
  text-decoration: none;
  font-weight: 800;
}

.button-primary {
  background: linear-gradient(135deg, #b51721 0%, #e23d33 100%);
  color: #fff;
}

.button-secondary {
  background: rgba(255, 255, 255, 0.8);
  color: #7b151c;
  border: 1px solid rgba(123, 21, 28, 0.18);
}

.popup-overlay {
  position: fixed;
  inset: 0;
  background: rgba(18, 12, 13, 0.55);
  display: grid;
  place-items: center;
  padding: 1rem;
  z-index: 9999;
}

.popup-content {
  position: relative;
  max-width: 36rem;
  width: 100%;
}

.popup-content h3 {
  font-size: 1.8rem;
  margin-bottom: 0.75rem;
}

.popup-close {
  position: absolute;
  top: 0.75rem;
  right: 1rem;
  border: none;
  background: transparent;
  color: #7b151c;
  font-size: 2rem;
  cursor: pointer;
}

@media (min-width: 900px) {
  .case-studies-page {
    padding: 2rem 2rem 5rem;
  }

  .case-hero {
    grid-template-columns: minmax(0, 1.08fr) minmax(0, 0.92fr);
    gap: 1.25rem;
    padding-top: 3rem;
  }

  .case-grid,
  .case-proof-band {
    grid-template-columns: repeat(3, minmax(0, 1fr));
  }

  .cta-strip {
    grid-template-columns: minmax(0, 1fr) auto;
  }
}
</style>
