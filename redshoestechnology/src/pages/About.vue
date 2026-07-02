<template>
  <div class="about-page">
    <section class="about-hero">
      <div class="about-hero-copy">
        <p class="eyebrow">About</p>
        <h1>Founder-led delivery with broad technical experience and a practical mindset.</h1>
        <p>
          Red Shoes Technology is led by Ramon, who brings architectural, delivery, and hands-on problem-solving experience across a range of demanding environments.
        </p>
      </div>

      <div class="about-hero-panel">
        <img src="/src/assets/founder_small.png" alt="Founder portrait" />
      </div>
    </section>

    <section class="about-grid">
      <article class="about-card about-card-wide">
        <p class="card-label">The founder</p>
        <h2>Experienced with delivery at both enterprise and small-business scale.</h2>
        <p>
          Ramon has provided high-level architectural direction, detailed design, and project leadership on multi-million-dollar work, while also helping smaller organisations keep systems running and evolving.
        </p>
      </article>

      <article class="about-card">
        <p class="card-label">Focus</p>
        <h2>Clear technical decisions</h2>
        <p>Good delivery starts with making the right engineering choice early, then carrying it through with consistency.</p>
      </article>

      <article class="about-card">
        <p class="card-label">Focus</p>
        <h2>Practical business value</h2>
        <p>The work is aimed at improving reliability, reducing waste, and making daily operations easier to manage.</p>
      </article>
    </section>

    <section class="experience-band">
      <article class="experience-card">
        <div class="experience-media">
          <img src="/src/assets/organisation_default.png" alt="Organisation overview" />
        </div>
        <div class="experience-copy">
          <p class="eyebrow">Experience</p>
          <h2>Work across sectors where reliability matters.</h2>
          <p>
            Red Shoes Technology has supported emergency services, finance, private R&amp;D, medtech, sports technology, and defence-related environments.
          </p>
        </div>
      </article>

      <article class="experience-card experience-card-list">
        <div class="experience-copy">
          <p class="eyebrow">Selected organisations</p>
          <ul>
            <li>Victoria Police</li>
            <li>Department of Defence</li>
            <li>Call Service Australia</li>
            <li>Psychology clinic, name withheld for privacy</li>
            <li>IBM</li>
          </ul>
        </div>
      </article>
    </section>

    <section class="about-footer-strip">
      <div>
        <p class="eyebrow">Next step</p>
        <h2>Need a partner who can think like an architect and work like a delivery lead?</h2>
      </div>
      <RouterLink class="button button-primary" to="/Contact">Get in touch</RouterLink>
    </section>
  </div>
</template>

<script setup>
</script>

<style scoped>
.about-page {
  max-width: 1240px;
  margin: 0 auto;
  padding: 1.25rem 1rem 4rem;
  color: #1f1a1a;
  font-family: Inter, "Segoe UI", Arial, sans-serif;
}

.about-hero,
.about-grid,
.experience-band,
.about-footer-strip {
  display: grid;
  gap: 1rem;
}

.about-hero {
  padding: 2rem 0 1.5rem;
}

.about-hero-copy,
.about-hero-panel,
.about-card,
.experience-card,
.about-footer-strip {
  background: rgba(255, 255, 255, 0.88);
  border: 1px solid rgba(123, 21, 28, 0.09);
  box-shadow: 0 18px 45px rgba(31, 16, 18, 0.08);
  backdrop-filter: blur(10px);
  border-radius: 1.5rem;
}

.about-hero-copy,
.about-card,
.experience-copy,
.about-footer-strip {
  padding: 1.5rem;
}

.about-hero-panel {
  overflow: hidden;
}

.about-hero-panel img {
  display: block;
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.about-page h1,
.about-card h2,
.experience-copy h2,
.about-footer-strip h2 {
  margin: 0;
  font-family: Georgia, "Times New Roman", serif;
  letter-spacing: -0.03em;
  color: #170f10;
}

.about-page h1 {
  font-size: clamp(2.4rem, 7vw, 4.8rem);
  line-height: 0.98;
  max-width: 12ch;
}

.about-page p,
.about-page li {
  margin: 0;
  color: #514548;
  line-height: 1.7;
}

.eyebrow,
.card-label {
  margin: 0 0 0.85rem;
  color: #9c1c24;
  text-transform: uppercase;
  letter-spacing: 0.18em;
  font-size: 0.74rem;
  font-weight: 800;
}

.about-card-wide {
  grid-column: 1 / -1;
}

.experience-band {
  padding-top: 0.5rem;
}

.experience-card {
  overflow: hidden;
}

.experience-media {
  height: 15rem;
  background: #1a1112;
}

.experience-media img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.experience-copy ul {
  margin: 0;
  padding-left: 1.1rem;
}

.experience-copy li + li {
  margin-top: 0.35rem;
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

.about-footer-strip {
  align-items: center;
  margin-top: 2rem;
  background: linear-gradient(135deg, rgba(248, 239, 239, 0.96), rgba(255, 255, 255, 0.92));
}

@media (min-width: 900px) {
  .about-page {
    padding: 2rem 2rem 5rem;
  }

  .about-hero {
    grid-template-columns: minmax(0, 1.08fr) minmax(0, 0.92fr);
    gap: 1.25rem;
    padding-top: 3rem;
  }

  .about-grid {
    grid-template-columns: repeat(3, minmax(0, 1fr));
  }

  .experience-card {
    display: grid;
    grid-template-columns: minmax(0, 0.9fr) minmax(0, 1.1fr);
  }

  .experience-media {
    height: auto;
    min-height: 100%;
  }

  .about-footer-strip {
    grid-template-columns: minmax(0, 1fr) auto;
  }
}
</style>

